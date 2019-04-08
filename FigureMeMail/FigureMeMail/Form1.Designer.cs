namespace FigureMeMail
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totextbox = new System.Windows.Forms.TextBox();
            this.subjecttextbox = new System.Windows.Forms.TextBox();
            this.messagetextbox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passtexbox = new System.Windows.Forms.TextBox();
            this.Usernamelabel = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Message:";
            // 
            // totextbox
            // 
            this.totextbox.Location = new System.Drawing.Point(71, 6);
            this.totextbox.Name = "totextbox";
            this.totextbox.Size = new System.Drawing.Size(582, 20);
            this.totextbox.TabIndex = 6;
            // 
            // subjecttextbox
            // 
            this.subjecttextbox.Location = new System.Drawing.Point(71, 33);
            this.subjecttextbox.Name = "subjecttextbox";
            this.subjecttextbox.Size = new System.Drawing.Size(582, 20);
            this.subjecttextbox.TabIndex = 7;
            // 
            // messagetextbox
            // 
            this.messagetextbox.Location = new System.Drawing.Point(71, 65);
            this.messagetextbox.Name = "messagetextbox";
            this.messagetextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messagetextbox.Size = new System.Drawing.Size(582, 20);
            this.messagetextbox.TabIndex = 7;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(71, 122);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.usernameTextBox.Size = new System.Drawing.Size(582, 20);
            this.usernameTextBox.TabIndex = 9;
            // 
            // passtexbox
            // 
            this.passtexbox.Location = new System.Drawing.Point(71, 148);
            this.passtexbox.Name = "passtexbox";
            this.passtexbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.passtexbox.Size = new System.Drawing.Size(582, 20);
            this.passtexbox.TabIndex = 10;
            this.passtexbox.UseSystemPasswordChar = true;
            // 
            // Usernamelabel
            // 
            this.Usernamelabel.AutoSize = true;
            this.Usernamelabel.Location = new System.Drawing.Point(12, 125);
            this.Usernamelabel.Name = "Usernamelabel";
            this.Usernamelabel.Size = new System.Drawing.Size(57, 13);
            this.Usernamelabel.TabIndex = 11;
            this.Usernamelabel.Text = "UserName";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(12, 151);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(56, 13);
            this.Username.TabIndex = 12;
            this.Username.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Usernamelabel);
            this.Controls.Add(this.passtexbox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.messagetextbox);
            this.Controls.Add(this.subjecttextbox);
            this.Controls.Add(this.totextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totextbox;
        private System.Windows.Forms.TextBox subjecttextbox;
        private System.Windows.Forms.TextBox messagetextbox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passtexbox;
        private System.Windows.Forms.Label Usernamelabel;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button button1;
    }
}

