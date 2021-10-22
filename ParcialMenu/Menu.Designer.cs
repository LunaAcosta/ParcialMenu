
namespace ParcialMenu
{
    partial class FmrMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistro = new MetroFramework.Controls.MetroButton();
            this.btnUsurarios = new MetroFramework.Controls.MetroButton();
            this.btnPerfil = new MetroFramework.Controls.MetroButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido !";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistro.BackgroundImage")));
            this.btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistro.Location = new System.Drawing.Point(212, 299);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(235, 91);
            this.btnRegistro.TabIndex = 3;
            this.btnRegistro.Text = "REGISTROS";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRegistro.UseCustomBackColor = true;
            this.btnRegistro.UseCustomForeColor = true;
            this.btnRegistro.UseSelectable = true;
            this.btnRegistro.UseStyleColors = true;
            // 
            // btnUsurarios
            // 
            this.btnUsurarios.BackColor = System.Drawing.Color.White;
            this.btnUsurarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsurarios.BackgroundImage")));
            this.btnUsurarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsurarios.ForeColor = System.Drawing.Color.DarkRed;
            this.btnUsurarios.Location = new System.Drawing.Point(423, 153);
            this.btnUsurarios.Name = "btnUsurarios";
            this.btnUsurarios.Size = new System.Drawing.Size(176, 116);
            this.btnUsurarios.TabIndex = 4;
            this.btnUsurarios.Text = "USUARIOS";
            this.btnUsurarios.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnUsurarios.UseCustomBackColor = true;
            this.btnUsurarios.UseCustomForeColor = true;
            this.btnUsurarios.UseSelectable = true;
            this.btnUsurarios.UseStyleColors = true;
            this.btnUsurarios.UseWaitCursor = true;
            // 
            // btnPerfil
            // 
            this.btnPerfil.AllowDrop = true;
            this.btnPerfil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPerfil.BackgroundImage")));
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnPerfil.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPerfil.Location = new System.Drawing.Point(86, 153);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(146, 116);
            this.btnPerfil.TabIndex = 2;
            this.btnPerfil.Text = "PERFIL";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPerfil.UseCustomBackColor = true;
            this.btnPerfil.UseCustomForeColor = true;
            this.btnPerfil.UseSelectable = true;
            this.btnPerfil.UseStyleColors = true;
            this.btnPerfil.UseWaitCursor = true;
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(691, 25);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip1";
            // 
            // FmrMenu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnUsurarios);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmrMenu";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnPerfil;
        private MetroFramework.Controls.MetroButton btnRegistro;
        private MetroFramework.Controls.MetroButton btnUsurarios;
        private System.Windows.Forms.ToolStrip toolStrip;
    }
}