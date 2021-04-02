
namespace MinecraftAutoClicker.Pages
{
    partial class PageFeatures
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVisualCrosshair = new WindowsUI.Controls.WinLabel();
            this.cbVisualCrosshair = new WindowsUI.Controls.WinCheckbox();
            this.lblFakeJitter = new WindowsUI.Controls.WinLabel();
            this.cbFakeJitter = new WindowsUI.Controls.WinCheckbox();
            this.lblAutoClicker = new WindowsUI.Controls.WinLabel();
            this.cbAutoClicker = new WindowsUI.Controls.WinCheckbox();
            this.lblHumanize = new WindowsUI.Controls.WinLabel();
            this.cbHumanize = new WindowsUI.Controls.WinCheckbox();
            this.SuspendLayout();
            // 
            // lblVisualCrosshair
            // 
            this.lblVisualCrosshair.AutoSize = true;
            this.lblVisualCrosshair.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblVisualCrosshair.ForeColor = System.Drawing.Color.White;
            this.lblVisualCrosshair.Location = new System.Drawing.Point(21, 47);
            this.lblVisualCrosshair.Name = "lblVisualCrosshair";
            this.lblVisualCrosshair.Size = new System.Drawing.Size(90, 15);
            this.lblVisualCrosshair.TabIndex = 20;
            this.lblVisualCrosshair.Text = "Visual Crosshair";
            // 
            // cbVisualCrosshair
            // 
            this.cbVisualCrosshair.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbVisualCrosshair.BorderColor = System.Drawing.Color.Gray;
            this.cbVisualCrosshair.Checked = false;
            this.cbVisualCrosshair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbVisualCrosshair.Enabled = false;
            this.cbVisualCrosshair.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.cbVisualCrosshair.ForeColor = System.Drawing.Color.White;
            this.cbVisualCrosshair.Location = new System.Drawing.Point(3, 47);
            this.cbVisualCrosshair.Name = "cbVisualCrosshair";
            this.cbVisualCrosshair.Size = new System.Drawing.Size(16, 16);
            this.cbVisualCrosshair.SizeMode = WindowsUI.Enums.SizeMode.Normal;
            this.cbVisualCrosshair.TabIndex = 19;
            this.cbVisualCrosshair.CheckedChanged += new WindowsUI.Controls.WinCheckbox.checkedChanged(this.cbVisualCrosshair_CheckedChanged);
            // 
            // lblFakeJitter
            // 
            this.lblFakeJitter.AutoSize = true;
            this.lblFakeJitter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblFakeJitter.ForeColor = System.Drawing.Color.White;
            this.lblFakeJitter.Location = new System.Drawing.Point(21, 25);
            this.lblFakeJitter.Name = "lblFakeJitter";
            this.lblFakeJitter.Size = new System.Drawing.Size(60, 15);
            this.lblFakeJitter.TabIndex = 18;
            this.lblFakeJitter.Text = "Fake Jitter";
            // 
            // cbFakeJitter
            // 
            this.cbFakeJitter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbFakeJitter.BorderColor = System.Drawing.Color.Gray;
            this.cbFakeJitter.Checked = false;
            this.cbFakeJitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFakeJitter.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.cbFakeJitter.ForeColor = System.Drawing.Color.White;
            this.cbFakeJitter.Location = new System.Drawing.Point(3, 25);
            this.cbFakeJitter.Name = "cbFakeJitter";
            this.cbFakeJitter.Size = new System.Drawing.Size(16, 16);
            this.cbFakeJitter.SizeMode = WindowsUI.Enums.SizeMode.Normal;
            this.cbFakeJitter.TabIndex = 17;
            this.cbFakeJitter.CheckedChanged += new WindowsUI.Controls.WinCheckbox.checkedChanged(this.cbFakeJitter_CheckedChanged);
            // 
            // lblAutoClicker
            // 
            this.lblAutoClicker.AutoSize = true;
            this.lblAutoClicker.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblAutoClicker.ForeColor = System.Drawing.Color.White;
            this.lblAutoClicker.Location = new System.Drawing.Point(21, 3);
            this.lblAutoClicker.Name = "lblAutoClicker";
            this.lblAutoClicker.Size = new System.Drawing.Size(71, 15);
            this.lblAutoClicker.TabIndex = 16;
            this.lblAutoClicker.Text = "Auto Clicker";
            // 
            // cbAutoClicker
            // 
            this.cbAutoClicker.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbAutoClicker.BorderColor = System.Drawing.Color.Gray;
            this.cbAutoClicker.Checked = false;
            this.cbAutoClicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAutoClicker.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.cbAutoClicker.ForeColor = System.Drawing.Color.White;
            this.cbAutoClicker.Location = new System.Drawing.Point(3, 3);
            this.cbAutoClicker.Name = "cbAutoClicker";
            this.cbAutoClicker.Size = new System.Drawing.Size(16, 16);
            this.cbAutoClicker.SizeMode = WindowsUI.Enums.SizeMode.Normal;
            this.cbAutoClicker.TabIndex = 15;
            this.cbAutoClicker.CheckedChanged += new WindowsUI.Controls.WinCheckbox.checkedChanged(this.cbAutoClicker_CheckedChanged);
            // 
            // lblHumanize
            // 
            this.lblHumanize.AutoSize = true;
            this.lblHumanize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblHumanize.ForeColor = System.Drawing.Color.White;
            this.lblHumanize.Location = new System.Drawing.Point(163, 3);
            this.lblHumanize.Name = "lblHumanize";
            this.lblHumanize.Size = new System.Drawing.Size(62, 15);
            this.lblHumanize.TabIndex = 22;
            this.lblHumanize.Text = "Humanize";
            // 
            // cbHumanize
            // 
            this.cbHumanize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbHumanize.BorderColor = System.Drawing.Color.Gray;
            this.cbHumanize.Checked = false;
            this.cbHumanize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHumanize.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.cbHumanize.ForeColor = System.Drawing.Color.White;
            this.cbHumanize.Location = new System.Drawing.Point(145, 3);
            this.cbHumanize.Name = "cbHumanize";
            this.cbHumanize.Size = new System.Drawing.Size(16, 16);
            this.cbHumanize.SizeMode = WindowsUI.Enums.SizeMode.Normal;
            this.cbHumanize.TabIndex = 21;
            this.cbHumanize.CheckedChanged += new WindowsUI.Controls.WinCheckbox.checkedChanged(this.cbHumanize_CheckedChanged);
            // 
            // PageFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.lblHumanize);
            this.Controls.Add(this.cbHumanize);
            this.Controls.Add(this.lblVisualCrosshair);
            this.Controls.Add(this.cbVisualCrosshair);
            this.Controls.Add(this.lblFakeJitter);
            this.Controls.Add(this.cbFakeJitter);
            this.Controls.Add(this.lblAutoClicker);
            this.Controls.Add(this.cbAutoClicker);
            this.Name = "PageFeatures";
            this.Size = new System.Drawing.Size(430, 240);
            this.Load += new System.EventHandler(this.PageFeatures_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsUI.Controls.WinLabel lblVisualCrosshair;
        private WindowsUI.Controls.WinCheckbox cbVisualCrosshair;
        private WindowsUI.Controls.WinLabel lblFakeJitter;
        private WindowsUI.Controls.WinCheckbox cbFakeJitter;
        private WindowsUI.Controls.WinLabel lblAutoClicker;
        private WindowsUI.Controls.WinCheckbox cbAutoClicker;
        private WindowsUI.Controls.WinLabel lblHumanize;
        private WindowsUI.Controls.WinCheckbox cbHumanize;
    }
}
