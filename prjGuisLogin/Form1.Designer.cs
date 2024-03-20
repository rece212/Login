namespace prjGuisLogin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbWelcome = new GroupBox();
            panel1 = new Panel();
            btnWelcome = new Button();
            gbLogin = new GroupBox();
            btnRegPage = new Button();
            btnLogin = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            txtPassLogin = new TextBox();
            txtNameLogin = new TextBox();
            gbRegister = new GroupBox();
            btnLoginScreen = new Button();
            btnRegUser = new Button();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            txtPassRegister = new TextBox();
            txtNameReg = new TextBox();
            gbWelcome.SuspendLayout();
            panel1.SuspendLayout();
            gbLogin.SuspendLayout();
            panel2.SuspendLayout();
            gbRegister.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // gbWelcome
            // 
            gbWelcome.Controls.Add(panel1);
            gbWelcome.Location = new Point(12, 12);
            gbWelcome.Name = "gbWelcome";
            gbWelcome.Size = new Size(332, 222);
            gbWelcome.TabIndex = 0;
            gbWelcome.TabStop = false;
            gbWelcome.Text = "Welcome";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnWelcome);
            panel1.Location = new Point(60, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 1;
            // 
            // btnWelcome
            // 
            btnWelcome.Location = new Point(22, 40);
            btnWelcome.Name = "btnWelcome";
            btnWelcome.Size = new Size(165, 23);
            btnWelcome.TabIndex = 0;
            btnWelcome.Text = "Login and Reg";
            btnWelcome.UseVisualStyleBackColor = true;
            btnWelcome.Click += btnWelcome_Click;
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(btnRegPage);
            gbLogin.Controls.Add(btnLogin);
            gbLogin.Controls.Add(panel2);
            gbLogin.Location = new Point(375, 12);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(332, 222);
            gbLogin.TabIndex = 2;
            gbLogin.TabStop = false;
            gbLogin.Text = "Login";
            gbLogin.Visible = false;
            // 
            // btnRegPage
            // 
            btnRegPage.Location = new Point(18, 186);
            btnRegPage.Name = "btnRegPage";
            btnRegPage.Size = new Size(75, 23);
            btnRegPage.TabIndex = 3;
            btnRegPage.Text = "Register";
            btnRegPage.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(238, 186);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtPassLogin);
            panel2.Controls.Add(txtNameLogin);
            panel2.Location = new Point(60, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 56);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 20);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // txtPassLogin
            // 
            txtPassLogin.Location = new Point(72, 48);
            txtPassLogin.Name = "txtPassLogin";
            txtPassLogin.Size = new Size(100, 23);
            txtPassLogin.TabIndex = 1;
            // 
            // txtNameLogin
            // 
            txtNameLogin.Location = new Point(72, 19);
            txtNameLogin.Name = "txtNameLogin";
            txtNameLogin.Size = new Size(100, 23);
            txtNameLogin.TabIndex = 0;
            // 
            // gbRegister
            // 
            gbRegister.Controls.Add(btnLoginScreen);
            gbRegister.Controls.Add(btnRegUser);
            gbRegister.Controls.Add(panel3);
            gbRegister.Location = new Point(12, 241);
            gbRegister.Name = "gbRegister";
            gbRegister.Size = new Size(332, 222);
            gbRegister.TabIndex = 4;
            gbRegister.TabStop = false;
            gbRegister.Text = "Register";
            gbRegister.Visible = false;
            // 
            // btnLoginScreen
            // 
            btnLoginScreen.Location = new Point(18, 186);
            btnLoginScreen.Name = "btnLoginScreen";
            btnLoginScreen.Size = new Size(75, 23);
            btnLoginScreen.TabIndex = 3;
            btnLoginScreen.Text = "Login Screen";
            btnLoginScreen.UseVisualStyleBackColor = true;
            // 
            // btnRegUser
            // 
            btnRegUser.Location = new Point(215, 186);
            btnRegUser.Name = "btnRegUser";
            btnRegUser.Size = new Size(98, 23);
            btnRegUser.TabIndex = 2;
            btnRegUser.Text = "Register user";
            btnRegUser.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtPassRegister);
            panel3.Controls.Add(txtNameReg);
            panel3.Location = new Point(60, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 56);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 20);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // txtPassRegister
            // 
            txtPassRegister.Location = new Point(72, 48);
            txtPassRegister.Name = "txtPassRegister";
            txtPassRegister.Size = new Size(100, 23);
            txtPassRegister.TabIndex = 1;
            // 
            // txtNameReg
            // 
            txtNameReg.Location = new Point(72, 19);
            txtNameReg.Name = "txtNameReg";
            txtNameReg.Size = new Size(100, 23);
            txtNameReg.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 475);
            Controls.Add(gbRegister);
            Controls.Add(gbLogin);
            Controls.Add(gbWelcome);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbWelcome.ResumeLayout(false);
            panel1.ResumeLayout(false);
            gbLogin.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            gbRegister.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbWelcome;
        private Panel panel1;
        private Button btnWelcome;
        private GroupBox gbLogin;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox txtPassLogin;
        private TextBox txtNameLogin;
        private Button btnRegPage;
        private Button btnLogin;
        private GroupBox gbRegister;
        private Button btnLoginScreen;
        private Button btnRegUser;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private TextBox txtPassRegister;
        private TextBox txtNameReg;
    }
}
