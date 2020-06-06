namespace ooooop5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gal1 = new ooooop5.HoverGallery();
            this.gal2 = new ooooop5.HoverGalleryOval();
            this.SuspendLayout();
            // 
            // gal1
            // 
            this.gal1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gal1.ForeColor = System.Drawing.Color.White;
            this.gal1.Location = new System.Drawing.Point(108, 54);
            this.gal1.Name = "gal1";
            this.gal1.Size = new System.Drawing.Size(260, 256);
            this.gal1.TabIndex = 0;
            this.gal1.Text = "hoverGallery1";
            this.gal1.UseVisualStyleBackColor = true;
            // 
            // gal2
            // 
            this.gal2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gal2.ForeColor = System.Drawing.Color.White;
            this.gal2.Location = new System.Drawing.Point(502, 47);
            this.gal2.Name = "gal2";
            this.gal2.Size = new System.Drawing.Size(288, 262);
            this.gal2.TabIndex = 1;
            this.gal2.Text = "hoverGalleryOval1";
            this.gal2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 438);
            this.Controls.Add(this.gal2);
            this.Controls.Add(this.gal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HoverGallery gal1;
        private HoverGalleryOval gal2;
    }
}

