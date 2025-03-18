namespace Hesap_Makinesi_Örneği
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ekranlabel = new System.Windows.Forms.Label();
            this.rakam1buton = new System.Windows.Forms.Button();
            this.rakam2buton = new System.Windows.Forms.Button();
            this.rakam3buton = new System.Windows.Forms.Button();
            this.rakam6buton = new System.Windows.Forms.Button();
            this.rakam5buton = new System.Windows.Forms.Button();
            this.rakam4buton = new System.Windows.Forms.Button();
            this.eşittirbuton = new System.Windows.Forms.Button();
            this.rakam0buton = new System.Windows.Forms.Button();
            this.silbutton = new System.Windows.Forms.Button();
            this.rakam9buton = new System.Windows.Forms.Button();
            this.rakam8buton = new System.Windows.Forms.Button();
            this.rakam7buton = new System.Windows.Forms.Button();
            this.bölbuton = new System.Windows.Forms.Button();
            this.çarpbuton = new System.Windows.Forms.Button();
            this.çıkarbuton = new System.Windows.Forms.Button();
            this.toplabuton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekranlabel
            // 
            this.ekranlabel.BackColor = System.Drawing.Color.White;
            this.ekranlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekranlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekranlabel.Location = new System.Drawing.Point(12, 9);
            this.ekranlabel.Name = "ekranlabel";
            this.ekranlabel.Size = new System.Drawing.Size(319, 73);
            this.ekranlabel.TabIndex = 0;
            this.ekranlabel.Text = "0";
            this.ekranlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rakam1buton
            // 
            this.rakam1buton.BackColor = System.Drawing.Color.Aqua;
            this.rakam1buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam1buton.Location = new System.Drawing.Point(13, 101);
            this.rakam1buton.Name = "rakam1buton";
            this.rakam1buton.Size = new System.Drawing.Size(75, 75);
            this.rakam1buton.TabIndex = 1;
            this.rakam1buton.Text = "1";
            this.rakam1buton.UseVisualStyleBackColor = false;
            this.rakam1buton.Click += new System.EventHandler(this.rakam1buton_Click);
            // 
            // rakam2buton
            // 
            this.rakam2buton.BackColor = System.Drawing.Color.Aqua;
            this.rakam2buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam2buton.Location = new System.Drawing.Point(94, 101);
            this.rakam2buton.Name = "rakam2buton";
            this.rakam2buton.Size = new System.Drawing.Size(75, 75);
            this.rakam2buton.TabIndex = 2;
            this.rakam2buton.Text = "2";
            this.rakam2buton.UseVisualStyleBackColor = false;
            this.rakam2buton.Click += new System.EventHandler(this.rakam2buton_Click);
            // 
            // rakam3buton
            // 
            this.rakam3buton.BackColor = System.Drawing.Color.Aqua;
            this.rakam3buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam3buton.Location = new System.Drawing.Point(175, 101);
            this.rakam3buton.Name = "rakam3buton";
            this.rakam3buton.Size = new System.Drawing.Size(75, 75);
            this.rakam3buton.TabIndex = 3;
            this.rakam3buton.Text = "3";
            this.rakam3buton.UseVisualStyleBackColor = false;
            this.rakam3buton.Click += new System.EventHandler(this.rakam3buton_Click);
            // 
            // rakam6buton
            // 
            this.rakam6buton.BackColor = System.Drawing.Color.Aqua;
            this.rakam6buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam6buton.Location = new System.Drawing.Point(175, 182);
            this.rakam6buton.Name = "rakam6buton";
            this.rakam6buton.Size = new System.Drawing.Size(75, 75);
            this.rakam6buton.TabIndex = 6;
            this.rakam6buton.Text = "6";
            this.rakam6buton.UseVisualStyleBackColor = false;
            this.rakam6buton.Click += new System.EventHandler(this.rakam6buton_Click);
            // 
            // rakam5buton
            // 
            this.rakam5buton.BackColor = System.Drawing.Color.Aqua;
            this.rakam5buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam5buton.Location = new System.Drawing.Point(94, 182);
            this.rakam5buton.Name = "rakam5buton";
            this.rakam5buton.Size = new System.Drawing.Size(75, 75);
            this.rakam5buton.TabIndex = 5;
            this.rakam5buton.Text = "5";
            this.rakam5buton.UseVisualStyleBackColor = false;
            this.rakam5buton.Click += new System.EventHandler(this.rakam5buton_Click);
            // 
            // rakam4buton
            // 
            this.rakam4buton.BackColor = System.Drawing.Color.Aqua;
            this.rakam4buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam4buton.Location = new System.Drawing.Point(13, 182);
            this.rakam4buton.Name = "rakam4buton";
            this.rakam4buton.Size = new System.Drawing.Size(75, 75);
            this.rakam4buton.TabIndex = 4;
            this.rakam4buton.Text = "4";
            this.rakam4buton.UseVisualStyleBackColor = false;
            this.rakam4buton.Click += new System.EventHandler(this.rakam4buton_Click);
            // 
            // eşittirbuton
            // 
            this.eşittirbuton.BackColor = System.Drawing.Color.Gold;
            this.eşittirbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eşittirbuton.Location = new System.Drawing.Point(175, 348);
            this.eşittirbuton.Name = "eşittirbuton";
            this.eşittirbuton.Size = new System.Drawing.Size(75, 75);
            this.eşittirbuton.TabIndex = 12;
            this.eşittirbuton.Text = "=";
            this.eşittirbuton.UseVisualStyleBackColor = false;
            this.eşittirbuton.Click += new System.EventHandler(this.eşittirbuton_Click);
            // 
            // rakam0buton
            // 
            this.rakam0buton.BackColor = System.Drawing.Color.Aqua;
            this.rakam0buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam0buton.Location = new System.Drawing.Point(94, 348);
            this.rakam0buton.Name = "rakam0buton";
            this.rakam0buton.Size = new System.Drawing.Size(75, 75);
            this.rakam0buton.TabIndex = 11;
            this.rakam0buton.Text = "0";
            this.rakam0buton.UseVisualStyleBackColor = false;
            this.rakam0buton.Click += new System.EventHandler(this.rakam0buton_Click);
            // 
            // silbutton
            // 
            this.silbutton.BackColor = System.Drawing.Color.Red;
            this.silbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silbutton.Location = new System.Drawing.Point(13, 348);
            this.silbutton.Name = "silbutton";
            this.silbutton.Size = new System.Drawing.Size(75, 75);
            this.silbutton.TabIndex = 10;
            this.silbutton.Text = "C";
            this.silbutton.UseVisualStyleBackColor = false;
            this.silbutton.Click += new System.EventHandler(this.silbutton_Click);
            // 
            // rakam9buton
            // 
            this.rakam9buton.BackColor = System.Drawing.Color.Aqua;
            this.rakam9buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam9buton.Location = new System.Drawing.Point(175, 267);
            this.rakam9buton.Name = "rakam9buton";
            this.rakam9buton.Size = new System.Drawing.Size(75, 75);
            this.rakam9buton.TabIndex = 9;
            this.rakam9buton.Text = "9";
            this.rakam9buton.UseVisualStyleBackColor = false;
            this.rakam9buton.Click += new System.EventHandler(this.rakam9buton_Click);
            // 
            // rakam8buton
            // 
            this.rakam8buton.BackColor = System.Drawing.Color.Aqua;
            this.rakam8buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam8buton.Location = new System.Drawing.Point(94, 267);
            this.rakam8buton.Name = "rakam8buton";
            this.rakam8buton.Size = new System.Drawing.Size(75, 75);
            this.rakam8buton.TabIndex = 8;
            this.rakam8buton.Text = "8";
            this.rakam8buton.UseVisualStyleBackColor = false;
            this.rakam8buton.Click += new System.EventHandler(this.rakam8buton_Click);
            // 
            // rakam7buton
            // 
            this.rakam7buton.BackColor = System.Drawing.Color.Aqua;
            this.rakam7buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam7buton.Location = new System.Drawing.Point(13, 267);
            this.rakam7buton.Name = "rakam7buton";
            this.rakam7buton.Size = new System.Drawing.Size(75, 75);
            this.rakam7buton.TabIndex = 7;
            this.rakam7buton.Text = "7";
            this.rakam7buton.UseVisualStyleBackColor = false;
            this.rakam7buton.Click += new System.EventHandler(this.rakam7buton_Click);
            // 
            // bölbuton
            // 
            this.bölbuton.BackColor = System.Drawing.Color.Gold;
            this.bölbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bölbuton.Location = new System.Drawing.Point(256, 348);
            this.bölbuton.Name = "bölbuton";
            this.bölbuton.Size = new System.Drawing.Size(75, 75);
            this.bölbuton.TabIndex = 16;
            this.bölbuton.Text = "/";
            this.bölbuton.UseVisualStyleBackColor = false;
            this.bölbuton.Click += new System.EventHandler(this.bölbuton_Click);
            // 
            // çarpbuton
            // 
            this.çarpbuton.BackColor = System.Drawing.Color.Gold;
            this.çarpbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çarpbuton.Location = new System.Drawing.Point(256, 267);
            this.çarpbuton.Name = "çarpbuton";
            this.çarpbuton.Size = new System.Drawing.Size(75, 75);
            this.çarpbuton.TabIndex = 15;
            this.çarpbuton.Text = "x";
            this.çarpbuton.UseVisualStyleBackColor = false;
            this.çarpbuton.Click += new System.EventHandler(this.çarpbuton_Click);
            // 
            // çıkarbuton
            // 
            this.çıkarbuton.BackColor = System.Drawing.Color.Gold;
            this.çıkarbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkarbuton.Location = new System.Drawing.Point(256, 182);
            this.çıkarbuton.Name = "çıkarbuton";
            this.çıkarbuton.Size = new System.Drawing.Size(75, 75);
            this.çıkarbuton.TabIndex = 14;
            this.çıkarbuton.Text = "-";
            this.çıkarbuton.UseVisualStyleBackColor = false;
            this.çıkarbuton.Click += new System.EventHandler(this.çıkarbuton_Click);
            // 
            // toplabuton
            // 
            this.toplabuton.BackColor = System.Drawing.Color.Gold;
            this.toplabuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplabuton.Location = new System.Drawing.Point(256, 101);
            this.toplabuton.Name = "toplabuton";
            this.toplabuton.Size = new System.Drawing.Size(75, 75);
            this.toplabuton.TabIndex = 13;
            this.toplabuton.Text = "+";
            this.toplabuton.UseVisualStyleBackColor = false;
            this.toplabuton.Click += new System.EventHandler(this.toplabuton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(341, 432);
            this.Controls.Add(this.bölbuton);
            this.Controls.Add(this.çarpbuton);
            this.Controls.Add(this.çıkarbuton);
            this.Controls.Add(this.toplabuton);
            this.Controls.Add(this.eşittirbuton);
            this.Controls.Add(this.rakam0buton);
            this.Controls.Add(this.silbutton);
            this.Controls.Add(this.rakam9buton);
            this.Controls.Add(this.rakam8buton);
            this.Controls.Add(this.rakam7buton);
            this.Controls.Add(this.rakam6buton);
            this.Controls.Add(this.rakam5buton);
            this.Controls.Add(this.rakam4buton);
            this.Controls.Add(this.rakam3buton);
            this.Controls.Add(this.rakam2buton);
            this.Controls.Add(this.rakam1buton);
            this.Controls.Add(this.ekranlabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HESAP MAKİNESİ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ekranlabel;
        private System.Windows.Forms.Button rakam1buton;
        private System.Windows.Forms.Button rakam2buton;
        private System.Windows.Forms.Button rakam3buton;
        private System.Windows.Forms.Button rakam6buton;
        private System.Windows.Forms.Button rakam5buton;
        private System.Windows.Forms.Button rakam4buton;
        private System.Windows.Forms.Button eşittirbuton;
        private System.Windows.Forms.Button rakam0buton;
        private System.Windows.Forms.Button silbutton;
        private System.Windows.Forms.Button rakam9buton;
        private System.Windows.Forms.Button rakam8buton;
        private System.Windows.Forms.Button rakam7buton;
        private System.Windows.Forms.Button bölbuton;
        private System.Windows.Forms.Button çarpbuton;
        private System.Windows.Forms.Button çıkarbuton;
        private System.Windows.Forms.Button toplabuton;
    }
}

