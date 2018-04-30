namespace Assignment10
{
   partial class FormClassLogin
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
         this.txtBoxUsername = new System.Windows.Forms.TextBox();
         this.txtBoxHost = new System.Windows.Forms.TextBox();
         this.txtBoxPassword = new System.Windows.Forms.TextBox();
         this.btnLogin = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // txtBoxUsername
         // 
         this.txtBoxUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtBoxUsername.Location = new System.Drawing.Point(337, 63);
         this.txtBoxUsername.Name = "txtBoxUsername";
         this.txtBoxUsername.Size = new System.Drawing.Size(100, 20);
         this.txtBoxUsername.TabIndex = 0;
         // 
         // txtBoxHost
         // 
         this.txtBoxHost.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtBoxHost.Location = new System.Drawing.Point(337, 200);
         this.txtBoxHost.Name = "txtBoxHost";
         this.txtBoxHost.Size = new System.Drawing.Size(100, 20);
         this.txtBoxHost.TabIndex = 1;
         // 
         // txtBoxPassword
         // 
         this.txtBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtBoxPassword.Location = new System.Drawing.Point(337, 138);
         this.txtBoxPassword.Name = "txtBoxPassword";
         this.txtBoxPassword.PasswordChar = '*';
         this.txtBoxPassword.Size = new System.Drawing.Size(100, 20);
         this.txtBoxPassword.TabIndex = 2;
         // 
         // btnLogin
         // 
         this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnLogin.Location = new System.Drawing.Point(152, 293);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(75, 23);
         this.btnLogin.TabIndex = 3;
         this.btnLogin.Text = "Login";
         this.btnLogin.UseVisualStyleBackColor = true;
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(520, 293);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 4;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         // 
         // FormClassLogin
         // 
         this.AcceptButton = this.btnLogin;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(825, 393);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnLogin);
         this.Controls.Add(this.txtBoxPassword);
         this.Controls.Add(this.txtBoxHost);
         this.Controls.Add(this.txtBoxUsername);
         this.Name = "FormClassLogin";
         this.Text = "FormClassLogin";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtBoxUsername;
      private System.Windows.Forms.TextBox txtBoxHost;
      private System.Windows.Forms.TextBox txtBoxPassword;
      private System.Windows.Forms.Button btnLogin;
      private System.Windows.Forms.Button btnCancel;
   }
}