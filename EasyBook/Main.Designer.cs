namespace EasyBook
{
    partial class Main
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
            this.btn_easyView = new System.Windows.Forms.Button();
            this.btn_normalView = new System.Windows.Forms.Button();
            this.pbox_Example = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Example)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_easyView
            // 
            this.btn_easyView.AutoSize = true;
            this.btn_easyView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btn_easyView.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_easyView.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_easyView.ForeColor = System.Drawing.Color.White;
            this.btn_easyView.Location = new System.Drawing.Point(0, 0);
            this.btn_easyView.Name = "btn_easyView";
            this.btn_easyView.Size = new System.Drawing.Size(309, 711);
            this.btn_easyView.TabIndex = 0;
            this.btn_easyView.Text = "큰 화면\r\n예매 진행";
            this.btn_easyView.UseVisualStyleBackColor = false;
            this.btn_easyView.Click += new System.EventHandler(this.btn_easyView_Click);
            this.btn_easyView.MouseEnter += new System.EventHandler(this.btn_easyView_MouseEnter);
            this.btn_easyView.MouseLeave += new System.EventHandler(this.btn_easyView_MouseLeave);
            // 
            // btn_normalView
            // 
            this.btn_normalView.AutoSize = true;
            this.btn_normalView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_normalView.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_normalView.Location = new System.Drawing.Point(875, 0);
            this.btn_normalView.Name = "btn_normalView";
            this.btn_normalView.Size = new System.Drawing.Size(309, 711);
            this.btn_normalView.TabIndex = 1;
            this.btn_normalView.Text = "예매 진행";
            this.btn_normalView.UseVisualStyleBackColor = true;
            this.btn_normalView.Click += new System.EventHandler(this.btn_normalView_Click);
            this.btn_normalView.MouseEnter += new System.EventHandler(this.btn_normalView_MouseEnter);
            this.btn_normalView.MouseLeave += new System.EventHandler(this.btn_normalView_MouseLeave);
            // 
            // pbox_Example
            // 
            this.pbox_Example.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbox_Example.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_Example.Location = new System.Drawing.Point(309, 150);
            this.pbox_Example.Margin = new System.Windows.Forms.Padding(10);
            this.pbox_Example.Name = "pbox_Example";
            this.pbox_Example.Padding = new System.Windows.Forms.Padding(5);
            this.pbox_Example.Size = new System.Drawing.Size(566, 561);
            this.pbox_Example.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbox_Example.TabIndex = 3;
            this.pbox_Example.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(309, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(566, 150);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 50);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "통합예약프로그램";
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.pbox_Example);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btn_easyView);
            this.panel2.Controls.Add(this.btn_normalView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 711);
            this.panel2.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "예매화면을 선택하세요.";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Example)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_easyView;
        private System.Windows.Forms.Button btn_normalView;
        private System.Windows.Forms.PictureBox pbox_Example;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

