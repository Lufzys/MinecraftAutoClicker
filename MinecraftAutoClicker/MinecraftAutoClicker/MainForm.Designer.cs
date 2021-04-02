
namespace MinecraftAutoClicker
{
    partial class MainForm
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.winButtonControl1 = new WindowsUI.Controls.WinButtonControl();
            this.btnFeatures = new WindowsUI.WinButton();
            this.btnSettings = new WindowsUI.WinButton();
            this.plPageholder = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.winButtonControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMinimaze);
            this.pnlTop.Controls.Add(this.btnMaximize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(430, 30);
            this.pnlTop.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnMaximize, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnMinimaze, 0);
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.BackColor = System.Drawing.Color.Black;
            this.btnMinimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimaze.FlatAppearance.BorderSize = 0;
            this.btnMinimaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnMinimaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaze.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.btnMinimaze.ForeColor = System.Drawing.Color.White;
            this.btnMinimaze.Location = new System.Drawing.Point(326, 0);
            this.btnMinimaze.Size = new System.Drawing.Size(52, 30);
            this.btnMinimaze.Text = "─";
            this.btnMinimaze.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Black;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(196, 0);
            this.btnMaximize.Size = new System.Drawing.Size(52, 30);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = "◻";
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(378, 0);
            this.btnClose.Size = new System.Drawing.Size(52, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // winButtonControl1
            // 
            this.winButtonControl1.BackColor = System.Drawing.Color.Black;
            this.winButtonControl1.Controls.Add(this.btnFeatures);
            this.winButtonControl1.Controls.Add(this.btnSettings);
            this.winButtonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.winButtonControl1.Location = new System.Drawing.Point(0, 30);
            this.winButtonControl1.Name = "winButtonControl1";
            this.winButtonControl1.SelectedTabIndex = 0;
            this.winButtonControl1.Size = new System.Drawing.Size(430, 26);
            this.winButtonControl1.TabBarStyle = true;
            this.winButtonControl1.TabIndex = 2;
            // 
            // btnFeatures
            // 
            this.btnFeatures.Border = System.Drawing.Color.Black;
            this.btnFeatures.BorderSize = 0F;
            this.btnFeatures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeatures.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnFeatures.ForeColor = System.Drawing.Color.White;
            this.btnFeatures.Image = null;
            this.btnFeatures.ImageAnchor = WindowsUI.Enums.ButtonImageAnchor.Left;
            this.btnFeatures.Location = new System.Drawing.Point(1, 1);
            this.btnFeatures.Margin = new System.Windows.Forms.Padding(1);
            this.btnFeatures.Name = "btnFeatures";
            this.btnFeatures.Normal = System.Drawing.Color.Black;
            this.btnFeatures.Press = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnFeatures.Selected = true;
            this.btnFeatures.SelectedBorderSize = 2;
            this.btnFeatures.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnFeatures.SelectedStyle = WindowsUI.Enums.SelectedStyle.Fill;
            this.btnFeatures.Size = new System.Drawing.Size(75, 23);
            this.btnFeatures.TabIndex = 1;
            this.btnFeatures.Text = "Features";
            this.btnFeatures.UseVisualStyleBackColor = true;
            this.btnFeatures.Click += new System.EventHandler(this.btnFeatures_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Border = System.Drawing.Color.Black;
            this.btnSettings.BorderSize = 0F;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = null;
            this.btnSettings.ImageAnchor = WindowsUI.Enums.ButtonImageAnchor.Left;
            this.btnSettings.Location = new System.Drawing.Point(78, 1);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(1);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Normal = System.Drawing.Color.Black;
            this.btnSettings.Press = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSettings.Selected = false;
            this.btnSettings.SelectedBorderSize = 2;
            this.btnSettings.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnSettings.SelectedStyle = WindowsUI.Enums.SelectedStyle.Fill;
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // plPageholder
            // 
            this.plPageholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plPageholder.Location = new System.Drawing.Point(0, 56);
            this.plPageholder.Name = "plPageholder";
            this.plPageholder.Size = new System.Drawing.Size(430, 240);
            this.plPageholder.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 296);
            this.Controls.Add(this.plPageholder);
            this.Controls.Add(this.winButtonControl1);
            this.FormAccent = WindowsUI.Enums.AccentState.ACCENT_ENABLE_ACRYLICBLURBEHIND;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeButton = false;
            this.Name = "MainForm";
            this.Resizer = false;
            this.TextAnchor = WindowsUI.Enums.TextAnchor.Center;
            this.Title = "Minecraft Auto Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.winButtonControl1, 0);
            this.Controls.SetChildIndex(this.plPageholder, 0);
            this.pnlTop.ResumeLayout(false);
            this.winButtonControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsUI.Controls.WinButtonControl winButtonControl1;
        private WindowsUI.WinButton btnFeatures;
        private WindowsUI.WinButton btnSettings;
        private System.Windows.Forms.Panel plPageholder;
    }
}

