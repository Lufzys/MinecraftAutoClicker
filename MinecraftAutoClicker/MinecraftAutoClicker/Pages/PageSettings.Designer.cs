
namespace MinecraftAutoClicker.Pages
{
    partial class PageSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageSettings));
            this.lblVisualCrosshair = new WindowsUI.Controls.WinLabel();
            this.pbVisualCrosshair = new WindowsUI.Controls.WinCircularPicturebox();
            this.tbSleep = new WindowsUI.Controls.WinTextbox();
            this.lblSleep = new WindowsUI.Controls.WinLabel();
            this.tbJitterRandomX = new WindowsUI.Controls.WinTextbox();
            this.lblJitterRandomX = new WindowsUI.Controls.WinLabel();
            this.tbJitterRandomY = new WindowsUI.Controls.WinTextbox();
            this.lblJitterRandomY = new WindowsUI.Controls.WinLabel();
            this.cpVisualCrosshair = new WindowsUI.Controls.WinColorPicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisualCrosshair)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVisualCrosshair
            // 
            this.lblVisualCrosshair.AutoSize = true;
            this.lblVisualCrosshair.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblVisualCrosshair.ForeColor = System.Drawing.Color.White;
            this.lblVisualCrosshair.Location = new System.Drawing.Point(125, 155);
            this.lblVisualCrosshair.Name = "lblVisualCrosshair";
            this.lblVisualCrosshair.Size = new System.Drawing.Size(127, 15);
            this.lblVisualCrosshair.TabIndex = 21;
            this.lblVisualCrosshair.Text = "Visual Crosshair Color :";
            // 
            // pbVisualCrosshair
            // 
            this.pbVisualCrosshair.BackColor = System.Drawing.Color.Green;
            this.pbVisualCrosshair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVisualCrosshair.Location = new System.Drawing.Point(253, 155);
            this.pbVisualCrosshair.Name = "pbVisualCrosshair";
            this.pbVisualCrosshair.Size = new System.Drawing.Size(16, 16);
            this.pbVisualCrosshair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVisualCrosshair.TabIndex = 22;
            this.pbVisualCrosshair.TabStop = false;
            this.pbVisualCrosshair.Click += new System.EventHandler(this.pbVisualCrosshair_Click);
            // 
            // tbSleep
            // 
            this.tbSleep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tbSleep.Content = "3";
            this.tbSleep.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tbSleep.ForeColor = System.Drawing.Color.White;
            this.tbSleep.Image = ((System.Drawing.Image)(resources.GetObject("tbSleep.Image")));
            this.tbSleep.Location = new System.Drawing.Point(209, 54);
            this.tbSleep.MaxLength = 2;
            this.tbSleep.Name = "tbSleep";
            this.tbSleep.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tbSleep.OnlyNumbers = true;
            this.tbSleep.PassChar = '\0';
            this.tbSleep.ReadOnlyText = false;
            this.tbSleep.Size = new System.Drawing.Size(93, 25);
            this.tbSleep.TabIndex = 23;
            this.tbSleep.TextChanged += new WindowsUI.Controls.WinTextbox.textChanged(this.tbCPS_TextChanged);
            // 
            // lblSleep
            // 
            this.lblSleep.AutoSize = true;
            this.lblSleep.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblSleep.ForeColor = System.Drawing.Color.White;
            this.lblSleep.Location = new System.Drawing.Point(84, 58);
            this.lblSleep.Name = "lblSleep";
            this.lblSleep.Size = new System.Drawing.Size(45, 15);
            this.lblSleep.TabIndex = 24;
            this.lblSleep.Text = "Sleep : ";
            // 
            // tbJitterRandomX
            // 
            this.tbJitterRandomX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tbJitterRandomX.Content = "5";
            this.tbJitterRandomX.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tbJitterRandomX.ForeColor = System.Drawing.Color.White;
            this.tbJitterRandomX.Image = ((System.Drawing.Image)(resources.GetObject("tbJitterRandomX.Image")));
            this.tbJitterRandomX.Location = new System.Drawing.Point(209, 85);
            this.tbJitterRandomX.MaxLength = 2;
            this.tbJitterRandomX.Name = "tbJitterRandomX";
            this.tbJitterRandomX.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tbJitterRandomX.OnlyNumbers = true;
            this.tbJitterRandomX.PassChar = '\0';
            this.tbJitterRandomX.ReadOnlyText = false;
            this.tbJitterRandomX.Size = new System.Drawing.Size(93, 25);
            this.tbJitterRandomX.TabIndex = 25;
            this.tbJitterRandomX.TextChanged += new WindowsUI.Controls.WinTextbox.textChanged(this.tbJitterRandomX_TextChanged);
            // 
            // lblJitterRandomX
            // 
            this.lblJitterRandomX.AutoSize = true;
            this.lblJitterRandomX.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblJitterRandomX.ForeColor = System.Drawing.Color.White;
            this.lblJitterRandomX.Location = new System.Drawing.Point(84, 89);
            this.lblJitterRandomX.Name = "lblJitterRandomX";
            this.lblJitterRandomX.Size = new System.Drawing.Size(120, 15);
            this.lblJitterRandomX.TabIndex = 26;
            this.lblJitterRandomX.Text = "Jitter - Randomize X :";
            // 
            // tbJitterRandomY
            // 
            this.tbJitterRandomY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tbJitterRandomY.Content = "5";
            this.tbJitterRandomY.Enabled = false;
            this.tbJitterRandomY.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tbJitterRandomY.ForeColor = System.Drawing.Color.White;
            this.tbJitterRandomY.Image = ((System.Drawing.Image)(resources.GetObject("tbJitterRandomY.Image")));
            this.tbJitterRandomY.Location = new System.Drawing.Point(209, 116);
            this.tbJitterRandomY.MaxLength = 2;
            this.tbJitterRandomY.Name = "tbJitterRandomY";
            this.tbJitterRandomY.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tbJitterRandomY.OnlyNumbers = true;
            this.tbJitterRandomY.PassChar = '\0';
            this.tbJitterRandomY.ReadOnlyText = false;
            this.tbJitterRandomY.Size = new System.Drawing.Size(93, 25);
            this.tbJitterRandomY.TabIndex = 27;
            this.tbJitterRandomY.TextChanged += new WindowsUI.Controls.WinTextbox.textChanged(this.tbJitterRandomY_TextChanged);
            // 
            // lblJitterRandomY
            // 
            this.lblJitterRandomY.AutoSize = true;
            this.lblJitterRandomY.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblJitterRandomY.ForeColor = System.Drawing.Color.White;
            this.lblJitterRandomY.Location = new System.Drawing.Point(84, 120);
            this.lblJitterRandomY.Name = "lblJitterRandomY";
            this.lblJitterRandomY.Size = new System.Drawing.Size(120, 15);
            this.lblJitterRandomY.TabIndex = 28;
            this.lblJitterRandomY.Text = "Jitter - Randomize Y :";
            // 
            // cpVisualCrosshair
            // 
            this.cpVisualCrosshair.BackColor = System.Drawing.Color.Transparent;
            this.cpVisualCrosshair.Location = new System.Drawing.Point(315, 52);
            this.cpVisualCrosshair.Name = "cpVisualCrosshair";
            this.cpVisualCrosshair.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cpVisualCrosshair.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpVisualCrosshair.Size = new System.Drawing.Size(95, 95);
            this.cpVisualCrosshair.TabIndex = 29;
            this.cpVisualCrosshair.Visible = false;
            this.cpVisualCrosshair.ColorChanged += new WindowsUI.Controls.WinColorPicker.colorChanged(this.cpVisualCrosshair_ColorChanged);
            // 
            // PageSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.cpVisualCrosshair);
            this.Controls.Add(this.tbJitterRandomY);
            this.Controls.Add(this.lblJitterRandomY);
            this.Controls.Add(this.tbJitterRandomX);
            this.Controls.Add(this.lblJitterRandomX);
            this.Controls.Add(this.tbSleep);
            this.Controls.Add(this.lblSleep);
            this.Controls.Add(this.pbVisualCrosshair);
            this.Controls.Add(this.lblVisualCrosshair);
            this.Name = "PageSettings";
            this.Size = new System.Drawing.Size(430, 240);
            this.Load += new System.EventHandler(this.PageSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVisualCrosshair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsUI.Controls.WinLabel lblVisualCrosshair;
        private WindowsUI.Controls.WinCircularPicturebox pbVisualCrosshair;
        private WindowsUI.Controls.WinTextbox tbSleep;
        private WindowsUI.Controls.WinLabel lblSleep;
        private WindowsUI.Controls.WinTextbox tbJitterRandomX;
        private WindowsUI.Controls.WinLabel lblJitterRandomX;
        private WindowsUI.Controls.WinTextbox tbJitterRandomY;
        private WindowsUI.Controls.WinLabel lblJitterRandomY;
        private WindowsUI.Controls.WinColorPicker cpVisualCrosshair;
    }
}
