namespace Login
{
    partial class frmSigin
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
            this.txtPass = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtUser = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnSigin = new MaterialSkin.Controls.MaterialButton();
            this.lblHome = new MaterialSkin.Controls.MaterialLabel();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.AllowPromptAsInput = true;
            this.txtPass.AnimateReadOnly = false;
            this.txtPass.AsciiOnly = false;
            this.txtPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPass.BeepOnError = false;
            this.txtPass.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPass.Depth = 0;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPass.HidePromptOnLeave = false;
            this.txtPass.HideSelection = true;
            this.txtPass.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPass.LeadingIcon = null;
            this.txtPass.Location = new System.Drawing.Point(95, 148);
            this.txtPass.Mask = "";
            this.txtPass.MaxLength = 32767;
            this.txtPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PrefixSuffixText = null;
            this.txtPass.PromptChar = '_';
            this.txtPass.ReadOnly = false;
            this.txtPass.RejectInputOnFirstFailure = false;
            this.txtPass.ResetOnPrompt = true;
            this.txtPass.ResetOnSpace = true;
            this.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(151, 36);
            this.txtPass.SkipLiterals = true;
            this.txtPass.TabIndex = 8;
            this.txtPass.TabStop = false;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPass.TrailingIcon = null;
            this.txtPass.UseSystemPasswordChar = false;
            this.txtPass.UseTallSize = false;
            this.txtPass.ValidatingType = null;
            // 
            // txtUser
            // 
            this.txtUser.AllowPromptAsInput = true;
            this.txtUser.AnimateReadOnly = false;
            this.txtUser.AsciiOnly = false;
            this.txtUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUser.BeepOnError = false;
            this.txtUser.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUser.Depth = 0;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.HidePromptOnLeave = false;
            this.txtUser.HideSelection = true;
            this.txtUser.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtUser.LeadingIcon = null;
            this.txtUser.Location = new System.Drawing.Point(95, 106);
            this.txtUser.Mask = "";
            this.txtUser.MaxLength = 32767;
            this.txtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PrefixSuffixText = null;
            this.txtUser.PromptChar = '_';
            this.txtUser.ReadOnly = false;
            this.txtUser.RejectInputOnFirstFailure = false;
            this.txtUser.ResetOnPrompt = true;
            this.txtUser.ResetOnSpace = true;
            this.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(151, 36);
            this.txtUser.SkipLiterals = true;
            this.txtUser.TabIndex = 7;
            this.txtUser.TabStop = false;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUser.TrailingIcon = null;
            this.txtUser.UseSystemPasswordChar = false;
            this.txtUser.UseTallSize = false;
            this.txtUser.ValidatingType = null;
            // 
            // btnSigin
            // 
            this.btnSigin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSigin.Depth = 0;
            this.btnSigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSigin.HighEmphasis = true;
            this.btnSigin.Icon = null;
            this.btnSigin.Location = new System.Drawing.Point(111, 295);
            this.btnSigin.Margin = new System.Windows.Forms.Padding(0);
            this.btnSigin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSigin.Name = "btnSigin";
            this.btnSigin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSigin.Size = new System.Drawing.Size(123, 36);
            this.btnSigin.TabIndex = 6;
            this.btnSigin.Text = "Registrarse";
            this.btnSigin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSigin.UseAccentColor = false;
            this.btnSigin.UseVisualStyleBackColor = true;
            this.btnSigin.Click += new System.EventHandler(this.btnSigin_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Depth = 0;
            this.lblHome.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHome.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblHome.Location = new System.Drawing.Point(134, 66);
            this.lblHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(75, 24);
            this.lblHome.TabIndex = 5;
            this.lblHome.Text = "Registro";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(111, 340);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack.Size = new System.Drawing.Size(123, 36);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Volver";
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmSigin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 391);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnSigin);
            this.Controls.Add(this.lblHome);
            this.Name = "frmSigin";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmSigin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtPass;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtUser;
        private MaterialSkin.Controls.MaterialButton btnSigin;
        private MaterialSkin.Controls.MaterialLabel lblHome;
        private MaterialSkin.Controls.MaterialButton btnBack;
    }
}