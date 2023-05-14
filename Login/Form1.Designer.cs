namespace Login
{
    partial class frmHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHome = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.btnSigin = new MaterialSkin.Controls.MaterialButton();
            this.txtUser = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtPass = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Depth = 0;
            this.lblHome.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHome.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblHome.Location = new System.Drawing.Point(99, 81);
            this.lblHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(119, 24);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Iniciar sesión";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(103, 253);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(123, 36);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Inciar Sesión";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSigin
            // 
            this.btnSigin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSigin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSigin.Depth = 0;
            this.btnSigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSigin.HighEmphasis = true;
            this.btnSigin.Icon = null;
            this.btnSigin.Location = new System.Drawing.Point(103, 317);
            this.btnSigin.Margin = new System.Windows.Forms.Padding(0);
            this.btnSigin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSigin.Name = "btnSigin";
            this.btnSigin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSigin.Size = new System.Drawing.Size(116, 36);
            this.btnSigin.TabIndex = 2;
            this.btnSigin.Text = "Registrarse";
            this.btnSigin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSigin.UseAccentColor = false;
            this.btnSigin.UseVisualStyleBackColor = true;
            this.btnSigin.Click += new System.EventHandler(this.btnSigin_Click);
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
            this.txtUser.Location = new System.Drawing.Point(87, 128);
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
            this.txtUser.TabIndex = 3;
            this.txtUser.TabStop = false;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUser.TrailingIcon = null;
            this.txtUser.UseSystemPasswordChar = false;
            this.txtUser.UseTallSize = false;
            this.txtUser.ValidatingType = null;
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
            this.txtPass.Location = new System.Drawing.Point(87, 170);
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
            this.txtPass.TabIndex = 4;
            this.txtPass.TabStop = false;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPass.TrailingIcon = null;
            this.txtPass.UseSystemPasswordChar = false;
            this.txtPass.UseTallSize = false;
            this.txtPass.ValidatingType = null;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 439);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnSigin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblHome);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblHome;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialButton btnSigin;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtUser;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPass;
    }
}

