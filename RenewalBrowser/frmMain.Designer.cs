namespace RenewalBrowser
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRenewalStart = new System.Windows.Forms.Button();
            this.txtWindowCaption = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRenewalStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRenewalStart
            // 
            this.btnRenewalStart.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.btnRenewalStart.Location = new System.Drawing.Point(460, 12);
            this.btnRenewalStart.Name = "btnRenewalStart";
            this.btnRenewalStart.Size = new System.Drawing.Size(98, 90);
            this.btnRenewalStart.TabIndex = 0;
            this.btnRenewalStart.Text = "시작";
            this.btnRenewalStart.UseVisualStyleBackColor = true;
            // 
            // txtWindowCaption
            // 
            this.txtWindowCaption.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.txtWindowCaption.Location = new System.Drawing.Point(159, 12);
            this.txtWindowCaption.Name = "txtWindowCaption";
            this.txtWindowCaption.Size = new System.Drawing.Size(295, 42);
            this.txtWindowCaption.TabIndex = 1;
            this.txtWindowCaption.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "타겟 이름 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInterval
            // 
            this.txtInterval.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.txtInterval.Location = new System.Drawing.Point(159, 60);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(71, 42);
            this.txtInterval.TabIndex = 1;
            this.txtInterval.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "간격 조절(분) :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRenewalStop
            // 
            this.btnRenewalStop.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.btnRenewalStop.Location = new System.Drawing.Point(564, 12);
            this.btnRenewalStop.Name = "btnRenewalStop";
            this.btnRenewalStop.Size = new System.Drawing.Size(98, 90);
            this.btnRenewalStop.TabIndex = 0;
            this.btnRenewalStop.Text = "종료";
            this.btnRenewalStop.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 112);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.txtWindowCaption);
            this.Controls.Add(this.btnRenewalStop);
            this.Controls.Add(this.btnRenewalStart);
            this.Name = "frmMain";
            this.Text = "자동 새로고침";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRenewalStart;
        private System.Windows.Forms.RichTextBox txtWindowCaption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRenewalStop;
    }
}

