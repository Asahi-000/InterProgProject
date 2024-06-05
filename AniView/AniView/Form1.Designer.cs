namespace AniView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            chbShowPassword = new CheckBox();
            btnSignIn = new Button();
            btnClose = new Button();
            label4 = new Label();
            linkSignUp = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(913, 119);
            label1.Name = "label1";
            label1.Size = new Size(219, 59);
            label1.TabIndex = 1;
            label1.Text = "Sign In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(711, 232);
            label2.Name = "label2";
            label2.Size = new Size(148, 29);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(711, 337);
            label3.Name = "label3";
            label3.Size = new Size(144, 29);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ScrollBar;
            txtUsername.Font = new Font("Verdana", 12F, FontStyle.Bold);
            txtUsername.Location = new Point(711, 264);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(617, 37);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ScrollBar;
            txtPassword.Font = new Font("Verdana", 12F, FontStyle.Bold);
            txtPassword.Location = new Point(711, 369);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(617, 37);
            txtPassword.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Location = new Point(56, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 534);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(56, 229);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(575, 288);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.BackColor = Color.Transparent;
            chbShowPassword.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbShowPassword.ForeColor = Color.LightSeaGreen;
            chbShowPassword.Location = new Point(714, 420);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(217, 29);
            chbShowPassword.TabIndex = 7;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.UseVisualStyleBackColor = false;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.LightSeaGreen;
            btnSignIn.FlatStyle = FlatStyle.Popup;
            btnSignIn.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(711, 538);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(295, 63);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Maroon;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1033, 538);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(295, 63);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(711, 613);
            label4.Name = "label4";
            label4.Size = new Size(274, 25);
            label4.TabIndex = 9;
            label4.Text = "Don't have an account?";
            // 
            // linkSignUp
            // 
            linkSignUp.AutoSize = true;
            linkSignUp.BackColor = Color.Transparent;
            linkSignUp.Font = new Font("Verdana", 10F, FontStyle.Bold);
            linkSignUp.ForeColor = Color.LightSeaGreen;
            linkSignUp.LinkColor = Color.White;
            linkSignUp.Location = new Point(982, 613);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(96, 25);
            linkSignUp.TabIndex = 10;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Sign up";
            linkSignUp.VisitedLinkColor = Color.LightSeaGreen;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1408, 749);
            Controls.Add(linkSignUp);
            Controls.Add(label4);
            Controls.Add(btnClose);
            Controls.Add(btnSignIn);
            Controls.Add(chbShowPassword);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AniView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Panel panel2;
        private PictureBox pictureBox1;
        private CheckBox chbShowPassword;
        private Button btnSignIn;
        private Button btnClose;
        private Label label4;
        private LinkLabel linkSignUp;
    }
}
