using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenewalBrowser
{
    public partial class frmMain : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        CancellationTokenSource tokenSource;

        public frmMain()
        {
            InitializeComponent();
            FormClosing += FrmMain_FormClosing;

            btnRenewalStart.Click += BtnRenewalStart_Click;
            btnRenewalStop.Click += BtnRenewalStop_Click;

            txtWindowCaption.Text = "CRM Ver2.0 - Chrome"; // 기본값
            txtInterval.Text = "1"; // 기본값

            btnRenewalStop.Enabled = false;

            log.Info("프로그램 시작");
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            tokenSource.Cancel();
            log.Info("프로그램 종료");
        }

        private void BtnRenewalStart_Click(object sender, EventArgs e)
        {
            #region 예외처리

            if (txtWindowCaption.Text.Equals(string.Empty) || txtInterval.Text.Equals(string.Empty))
            {
                MessageBox.Show("목표 URI 및 간격을 설정해주세요");
                return;
            }

            int number = 0;

            if (!int.TryParse(txtInterval.Text, out number))
            {
                MessageBox.Show("간격은 숫자만 가능합니다.");
                return;
            }

            if (txtInterval.Text.Equals("0") || number > 10)
            {
                MessageBox.Show("간격은 0분일 수 없고, 10분을 초과할 수 없습니다.");
                return;
            }

            #endregion

            tokenSource = new CancellationTokenSource();

            log.Info("시작 클릭");
            txtWindowCaption.Enabled = false;
            txtInterval.Enabled = false;
            btnRenewalStop.Enabled = true;
            btnRenewalStart.Enabled = false;

            TimerStart(txtWindowCaption.Text, number, tokenSource.Token);
        }

        private void BtnRenewalStop_Click(object sender, EventArgs e)
        {
            log.Info("종료 클릭");
            tokenSource.Cancel();
            txtWindowCaption.Enabled = true;
            txtInterval.Enabled = true;
            btnRenewalStop.Enabled = false;
            btnRenewalStart.Enabled = true;
        }

        private async void TimerStart(string WindowName, int minute, CancellationToken token)
        {
            IntPtr TgtHnd;
            int interval = minute * 60 * 1000;

            while (!token.IsCancellationRequested)
            {
                FindTargetWindow(WindowName, out TgtHnd);
                if (!TgtHnd.Equals(null))
                {
                    Utils.SetForegroundWindow(TgtHnd);
                    Utils.PostMessage(TgtHnd, Utils.WM_KEYDOWN, Utils.VK_F5, IntPtr.Zero);
                    //Utils.keybd_event(Utils.VK_F5, 0, Utils.KEYEVENTF_EXTENDEDKEY | Utils.KEYEVENTF_KEYUP, 0);
                    log.Info("새로고침 완료");
                }
                await Task.Delay(interval, token).ContinueWith(tsk => { }); // ContinueWith 메서드로 인해 try-catch 없이 TaskCanceledException을 잡을 수 있다.
            }
        }

        private bool FindTargetWindow(string RoomName, out IntPtr TgtHnd)
        {
            IntPtr TargetWindowNameHnd = Utils.FindWindow(null, RoomName);

            TgtHnd = TargetWindowNameHnd;

            return true;
        }
    }
}
