namespace EasyBook
{
    partial class MemManagerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.gbox_manager = new System.Windows.Forms.GroupBox();
            this.mtb_hp = new System.Windows.Forms.MaskedTextBox();
            this.tb_pw2 = new System.Windows.Forms.TextBox();
            this.lbl_pw2 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.mtb_resident = new System.Windows.Forms.MaskedTextBox();
            this.btn_Nmem = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.btn_nonInsert = new System.Windows.Forms.Button();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.lbl_resident = new System.Windows.Forms.Label();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.btn_join = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.btn_idCheck = new System.Windows.Forms.Button();
            this.lbl_addr = new System.Windows.Forms.Label();
            this.gbox_manager.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_id.Location = new System.Drawing.Point(5, 30);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(100, 25);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "아이디";
            // 
            // lbl_pw
            // 
            this.lbl_pw.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_pw.Location = new System.Drawing.Point(5, 70);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(100, 25);
            this.lbl_pw.TabIndex = 1;
            this.lbl_pw.Text = "비밀번호";
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_id.Location = new System.Drawing.Point(120, 30);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(120, 25);
            this.tb_id.TabIndex = 2;
            // 
            // tb_pw
            // 
            this.tb_pw.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_pw.Location = new System.Drawing.Point(120, 70);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '*';
            this.tb_pw.Size = new System.Drawing.Size(120, 25);
            this.tb_pw.TabIndex = 3;
            // 
            // gbox_manager
            // 
            this.gbox_manager.Controls.Add(this.mtb_hp);
            this.gbox_manager.Controls.Add(this.tb_id);
            this.gbox_manager.Controls.Add(this.lbl_id);
            this.gbox_manager.Controls.Add(this.tb_pw2);
            this.gbox_manager.Controls.Add(this.tb_pw);
            this.gbox_manager.Controls.Add(this.lbl_pw2);
            this.gbox_manager.Controls.Add(this.lbl_name);
            this.gbox_manager.Controls.Add(this.lbl_pw);
            this.gbox_manager.Controls.Add(this.mtb_resident);
            this.gbox_manager.Controls.Add(this.btn_Nmem);
            this.gbox_manager.Controls.Add(this.tb_name);
            this.gbox_manager.Controls.Add(this.lbl_mail);
            this.gbox_manager.Controls.Add(this.btn_nonInsert);
            this.gbox_manager.Controls.Add(this.tb_addr);
            this.gbox_manager.Controls.Add(this.lbl_resident);
            this.gbox_manager.Controls.Add(this.lbl_hp);
            this.gbox_manager.Controls.Add(this.btn_join);
            this.gbox_manager.Controls.Add(this.btn_Insert);
            this.gbox_manager.Controls.Add(this.btn_Login);
            this.gbox_manager.Controls.Add(this.tb_mail);
            this.gbox_manager.Controls.Add(this.btn_idCheck);
            this.gbox_manager.Controls.Add(this.lbl_addr);
            this.gbox_manager.Location = new System.Drawing.Point(12, 12);
            this.gbox_manager.Name = "gbox_manager";
            this.gbox_manager.Size = new System.Drawing.Size(331, 591);
            this.gbox_manager.TabIndex = 4;
            this.gbox_manager.TabStop = false;
            this.gbox_manager.Text = "로그인";
            // 
            // mtb_hp
            // 
            this.mtb_hp.Location = new System.Drawing.Point(121, 363);
            this.mtb_hp.Name = "mtb_hp";
            this.mtb_hp.Size = new System.Drawing.Size(120, 21);
            this.mtb_hp.TabIndex = 20;
            // 
            // tb_pw2
            // 
            this.tb_pw2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_pw2.Location = new System.Drawing.Point(121, 243);
            this.tb_pw2.Name = "tb_pw2";
            this.tb_pw2.PasswordChar = '*';
            this.tb_pw2.Size = new System.Drawing.Size(120, 25);
            this.tb_pw2.TabIndex = 5;
            // 
            // lbl_pw2
            // 
            this.lbl_pw2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_pw2.Location = new System.Drawing.Point(6, 246);
            this.lbl_pw2.Name = "lbl_pw2";
            this.lbl_pw2.Size = new System.Drawing.Size(100, 25);
            this.lbl_pw2.TabIndex = 4;
            this.lbl_pw2.Text = "비밀번호 확인";
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_name.Location = new System.Drawing.Point(6, 280);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(100, 25);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "성명";
            // 
            // mtb_resident
            // 
            this.mtb_resident.Location = new System.Drawing.Point(121, 325);
            this.mtb_resident.Name = "mtb_resident";
            this.mtb_resident.Size = new System.Drawing.Size(120, 21);
            this.mtb_resident.TabIndex = 19;
            // 
            // btn_Nmem
            // 
            this.btn_Nmem.Location = new System.Drawing.Point(171, 486);
            this.btn_Nmem.Name = "btn_Nmem";
            this.btn_Nmem.Size = new System.Drawing.Size(75, 25);
            this.btn_Nmem.TabIndex = 8;
            this.btn_Nmem.Text = "비회원예매";
            this.btn_Nmem.UseVisualStyleBackColor = true;
            this.btn_Nmem.Click += new System.EventHandler(this.btn_Nmem_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_name.Location = new System.Drawing.Point(121, 280);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(120, 25);
            this.tb_name.TabIndex = 7;
            // 
            // lbl_mail
            // 
            this.lbl_mail.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_mail.Location = new System.Drawing.Point(6, 444);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(100, 25);
            this.lbl_mail.TabIndex = 14;
            this.lbl_mail.Text = "이메일";
            // 
            // btn_nonInsert
            // 
            this.btn_nonInsert.Location = new System.Drawing.Point(171, 517);
            this.btn_nonInsert.Name = "btn_nonInsert";
            this.btn_nonInsert.Size = new System.Drawing.Size(75, 70);
            this.btn_nonInsert.TabIndex = 18;
            this.btn_nonInsert.Text = "비회원\r\n예매 진행";
            this.btn_nonInsert.UseVisualStyleBackColor = true;
            this.btn_nonInsert.Click += new System.EventHandler(this.btn_nonInsert_Click);
            // 
            // tb_addr
            // 
            this.tb_addr.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_addr.Location = new System.Drawing.Point(121, 407);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(120, 25);
            this.tb_addr.TabIndex = 13;
            // 
            // lbl_resident
            // 
            this.lbl_resident.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_resident.Location = new System.Drawing.Point(6, 321);
            this.lbl_resident.Name = "lbl_resident";
            this.lbl_resident.Size = new System.Drawing.Size(100, 25);
            this.lbl_resident.TabIndex = 8;
            this.lbl_resident.Text = "주민번호";
            // 
            // lbl_hp
            // 
            this.lbl_hp.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_hp.Location = new System.Drawing.Point(6, 363);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(100, 25);
            this.lbl_hp.TabIndex = 9;
            this.lbl_hp.Text = "연락처";
            // 
            // btn_join
            // 
            this.btn_join.Location = new System.Drawing.Point(90, 486);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(75, 25);
            this.btn_join.TabIndex = 17;
            this.btn_join.Text = "가입하기";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(90, 517);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 25);
            this.btn_Insert.TabIndex = 7;
            this.btn_Insert.Text = "회원가입";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(9, 486);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 70);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "로그인";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tb_mail
            // 
            this.tb_mail.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_mail.Location = new System.Drawing.Point(121, 444);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(120, 25);
            this.tb_mail.TabIndex = 15;
            // 
            // btn_idCheck
            // 
            this.btn_idCheck.Location = new System.Drawing.Point(9, 556);
            this.btn_idCheck.Name = "btn_idCheck";
            this.btn_idCheck.Size = new System.Drawing.Size(75, 25);
            this.btn_idCheck.TabIndex = 16;
            this.btn_idCheck.Text = "중복확인";
            this.btn_idCheck.UseVisualStyleBackColor = true;
            this.btn_idCheck.Click += new System.EventHandler(this.btn_idCheck_Click);
            // 
            // lbl_addr
            // 
            this.lbl_addr.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_addr.Location = new System.Drawing.Point(6, 407);
            this.lbl_addr.Name = "lbl_addr";
            this.lbl_addr.Size = new System.Drawing.Size(100, 25);
            this.lbl_addr.TabIndex = 12;
            this.lbl_addr.Text = "주소";
            // 
            // MemManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 645);
            this.Controls.Add(this.gbox_manager);
            this.Name = "MemManagerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원관리";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemManagerView_FormClosed);
            this.Load += new System.EventHandler(this.MemManagerView_Load);
            this.gbox_manager.ResumeLayout(false);
            this.gbox_manager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_pw;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.GroupBox gbox_manager;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Nmem;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.Label lbl_addr;
        private System.Windows.Forms.Label lbl_resident;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_pw2;
        private System.Windows.Forms.Label lbl_pw2;
        private System.Windows.Forms.Label lbl_hp;
        private System.Windows.Forms.Button btn_idCheck;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.Button btn_nonInsert;
        private System.Windows.Forms.MaskedTextBox mtb_resident;
        private System.Windows.Forms.MaskedTextBox mtb_hp;
    }
}