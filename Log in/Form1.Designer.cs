namespace Log_in
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnLogn = new Guna.UI2.WinForms.Guna2GradientButton();
            btnExit = new Guna.UI2.WinForms.Guna2GradientButton();
            TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            password = new Label();
            userName = new Label();
            SuspendLayout();
            // 
            // btnLogn
            // 
            btnLogn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogn.CustomizableEdges = customizableEdges1;
            btnLogn.DisabledState.BorderColor = Color.DarkGray;
            btnLogn.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnLogn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogn.ForeColor = Color.White;
            btnLogn.Location = new Point(806, 382);
            btnLogn.Name = "btnLogn";
            btnLogn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogn.Size = new Size(133, 56);
            btnLogn.TabIndex = 0;
            btnLogn.Text = "log in";
            btnLogn.Click += guna2GradientButton1_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.CustomizableEdges = customizableEdges3;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(56, 382);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExit.Size = new Size(144, 56);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // TextBox1
            // 
            TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox1.CustomizableEdges = customizableEdges5;
            TextBox1.DefaultText = "";
            TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox1.Font = new Font("Segoe UI", 9F);
            TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox1.Location = new Point(242, 38);
            TextBox1.Margin = new Padding(3, 4, 3, 4);
            TextBox1.Name = "TextBox1";
            TextBox1.PasswordChar = '\0';
            TextBox1.PlaceholderText = "";
            TextBox1.SelectedText = "";
            TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TextBox1.Size = new Size(601, 60);
            TextBox1.TabIndex = 2;
            // 
            // TextBox2
            // 
            TextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox2.CustomizableEdges = customizableEdges7;
            TextBox2.DefaultText = "";
            TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox2.Font = new Font("Segoe UI", 9F);
            TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox2.Location = new Point(241, 149);
            TextBox2.Margin = new Padding(3, 4, 3, 4);
            TextBox2.Name = "TextBox2";
            TextBox2.PasswordChar = '\0';
            TextBox2.PlaceholderText = "";
            TextBox2.SelectedText = "";
            TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            TextBox2.Size = new Size(602, 60);
            TextBox2.TabIndex = 3;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(64, 167);
            password.Name = "password";
            password.Size = new Size(110, 31);
            password.TabIndex = 4;
            password.Text = "Password";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(64, 55);
            userName.Name = "userName";
            userName.Size = new Size(121, 31);
            userName.TabIndex = 5;
            userName.Text = "UserName";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 460);
            Controls.Add(userName);
            Controls.Add(password);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            Controls.Add(btnExit);
            Controls.Add(btnLogn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnLogn;
        private Guna.UI2.WinForms.Guna2GradientButton btnExit;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox2;
        private Label password;
        private Label userName;
    }
}
