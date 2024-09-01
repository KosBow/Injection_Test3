namespace Injection_Test2
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
            label1 = new Label();
            label2 = new Label();
            lblQuerry = new Label();
            lblStatus = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 49);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 91);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // lblQuerry
            // 
            lblQuerry.AutoSize = true;
            lblQuerry.Location = new Point(155, 158);
            lblQuerry.Name = "lblQuerry";
            lblQuerry.Size = new Size(58, 15);
            lblQuerry.TabIndex = 2;
            lblQuerry.Text = "sqlQuerry";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(155, 308);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(86, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Du är utloggad";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(247, 46);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(217, 23);
            txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(247, 88);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(217, 23);
            txtPass.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(155, 211);
            button1.Name = "button1";
            button1.Size = new Size(184, 69);
            button1.TabIndex = 6;
            button1.Text = "Logga in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblStatus);
            Controls.Add(lblQuerry);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblQuerry;
        private Label lblStatus;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button button1;
    }
}
