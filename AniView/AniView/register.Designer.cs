namespace AniView
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            btnSignIn = new Button();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.Black;
            btnSignIn.FlatStyle = FlatStyle.Popup;
            btnSignIn.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(1045, 578);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(295, 63);
            btnSignIn.TabIndex = 18;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightSeaGreen;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(723, 578);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(295, 63);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(68, 236);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(575, 288);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Location = new Point(68, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 534);
            panel2.TabIndex = 16;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ScrollBar;
            txtPassword.Font = new Font("Verdana", 12F, FontStyle.Bold);
            txtPassword.Location = new Point(723, 475);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(617, 37);
            txtPassword.TabIndex = 15;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ScrollBar;
            txtUsername.Font = new Font("Verdana", 12F, FontStyle.Bold);
            txtUsername.Location = new Point(723, 370);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(617, 37);
            txtUsername.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(723, 443);
            label3.Name = "label3";
            label3.Size = new Size(144, 29);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(723, 338);
            label2.Name = "label2";
            label2.Size = new Size(148, 29);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(921, 103);
            label1.Name = "label1";
            label1.Size = new Size(232, 59);
            label1.TabIndex = 11;
            label1.Text = "Sign Up";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ScrollBar;
            txtName.Font = new Font("Verdana", 12F, FontStyle.Bold);
            txtName.Location = new Point(723, 268);
            txtName.Name = "txtName";
            txtName.Size = new Size(617, 37);
            txtName.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(723, 236);
            label4.Name = "label4";
            label4.Size = new Size(90, 29);
            label4.TabIndex = 19;
            label4.Text = "Name";
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1408, 749);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(btnSignIn);
            Controls.Add(btnRegister);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignIn;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private Label label4;
    }
}