namespace Slector_de_cores
{
    partial class Fselector
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fselector));
            this.PCor = new System.Windows.Forms.Panel();
            this.Tvermelho = new System.Windows.Forms.TrackBar();
            this.Tverde = new System.Windows.Forms.TrackBar();
            this.Tazul = new System.Windows.Forms.TrackBar();
            this.LVermelho = new System.Windows.Forms.Label();
            this.Lverde = new System.Windows.Forms.Label();
            this.Lblue = new System.Windows.Forms.Label();
            this.Thexa = new System.Windows.Forms.TextBox();
            this.BCopiar = new System.Windows.Forms.Button();
            this.TRGB = new System.Windows.Forms.TextBox();
            this.BCopiarRGB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tvermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tverde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tazul)).BeginInit();
            this.SuspendLayout();
            // 
            // PCor
            // 
            this.PCor.BackColor = System.Drawing.Color.Black;
            this.PCor.Location = new System.Drawing.Point(13, 22);
            this.PCor.Name = "PCor";
            this.PCor.Size = new System.Drawing.Size(247, 227);
            this.PCor.TabIndex = 3;
            // 
            // Tvermelho
            // 
            this.Tvermelho.BackColor = System.Drawing.SystemColors.Control;
            this.Tvermelho.Location = new System.Drawing.Point(276, 35);
            this.Tvermelho.Maximum = 255;
            this.Tvermelho.Name = "Tvermelho";
            this.Tvermelho.Size = new System.Drawing.Size(362, 56);
            this.Tvermelho.TabIndex = 4;
            this.Tvermelho.Scroll += new System.EventHandler(this.Tvermelho_Scroll);
            // 
            // Tverde
            // 
            this.Tverde.Location = new System.Drawing.Point(276, 120);
            this.Tverde.Maximum = 255;
            this.Tverde.Name = "Tverde";
            this.Tverde.Size = new System.Drawing.Size(362, 56);
            this.Tverde.TabIndex = 5;
            this.Tverde.Scroll += new System.EventHandler(this.Tverde_Scroll);
            // 
            // Tazul
            // 
            this.Tazul.Location = new System.Drawing.Point(276, 205);
            this.Tazul.Maximum = 255;
            this.Tazul.Name = "Tazul";
            this.Tazul.Size = new System.Drawing.Size(362, 56);
            this.Tazul.TabIndex = 6;
            this.Tazul.Scroll += new System.EventHandler(this.Tazul_Scroll);
            // 
            // LVermelho
            // 
            this.LVermelho.AutoSize = true;
            this.LVermelho.Location = new System.Drawing.Point(285, 17);
            this.LVermelho.Name = "LVermelho";
            this.LVermelho.Size = new System.Drawing.Size(78, 16);
            this.LVermelho.TabIndex = 7;
            this.LVermelho.Text = "Vermelho 0:";
            // 
            // Lverde
            // 
            this.Lverde.AutoSize = true;
            this.Lverde.Location = new System.Drawing.Point(284, 101);
            this.Lverde.Name = "Lverde";
            this.Lverde.Size = new System.Drawing.Size(57, 16);
            this.Lverde.TabIndex = 8;
            this.Lverde.Text = "Verde 0:";
            // 
            // Lblue
            // 
            this.Lblue.AutoSize = true;
            this.Lblue.Location = new System.Drawing.Point(285, 178);
            this.Lblue.Name = "Lblue";
            this.Lblue.Size = new System.Drawing.Size(47, 16);
            this.Lblue.TabIndex = 9;
            this.Lblue.Text = "Blue 0:";
            // 
            // Thexa
            // 
            this.Thexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thexa.Location = new System.Drawing.Point(12, 271);
            this.Thexa.Multiline = true;
            this.Thexa.Name = "Thexa";
            this.Thexa.Size = new System.Drawing.Size(130, 49);
            this.Thexa.TabIndex = 10;
            // 
            // BCopiar
            // 
            this.BCopiar.Image = ((System.Drawing.Image)(resources.GetObject("BCopiar.Image")));
            this.BCopiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCopiar.Location = new System.Drawing.Point(148, 271);
            this.BCopiar.Name = "BCopiar";
            this.BCopiar.Size = new System.Drawing.Size(153, 49);
            this.BCopiar.TabIndex = 11;
            this.BCopiar.Text = "Copiar_Hexa";
            this.BCopiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCopiar.UseVisualStyleBackColor = true;
            this.BCopiar.Click += new System.EventHandler(this.BCopiar_Click);
            // 
            // TRGB
            // 
            this.TRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRGB.Location = new System.Drawing.Point(308, 271);
            this.TRGB.Multiline = true;
            this.TRGB.Name = "TRGB";
            this.TRGB.Size = new System.Drawing.Size(174, 49);
            this.TRGB.TabIndex = 12;
            // 
            // BCopiarRGB
            // 
            this.BCopiarRGB.Image = ((System.Drawing.Image)(resources.GetObject("BCopiarRGB.Image")));
            this.BCopiarRGB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCopiarRGB.Location = new System.Drawing.Point(488, 271);
            this.BCopiarRGB.Name = "BCopiarRGB";
            this.BCopiarRGB.Size = new System.Drawing.Size(150, 49);
            this.BCopiarRGB.TabIndex = 13;
            this.BCopiarRGB.Text = "Copiar_ RGB";
            this.BCopiarRGB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCopiarRGB.UseVisualStyleBackColor = true;
            this.BCopiarRGB.Click += new System.EventHandler(this.BCopiarRGB_Click);
            // 
            // Fselector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 332);
            this.Controls.Add(this.BCopiarRGB);
            this.Controls.Add(this.TRGB);
            this.Controls.Add(this.BCopiar);
            this.Controls.Add(this.Thexa);
            this.Controls.Add(this.Lblue);
            this.Controls.Add(this.Lverde);
            this.Controls.Add(this.LVermelho);
            this.Controls.Add(this.Tazul);
            this.Controls.Add(this.Tverde);
            this.Controls.Add(this.Tvermelho);
            this.Controls.Add(this.PCor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fselector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selector de Cores Dev Joel © 2023";
            ((System.ComponentModel.ISupportInitialize)(this.Tvermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tverde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tazul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PCor;
        private System.Windows.Forms.TrackBar Tvermelho;
        private System.Windows.Forms.TrackBar Tverde;
        private System.Windows.Forms.TrackBar Tazul;
        private System.Windows.Forms.Label LVermelho;
        private System.Windows.Forms.Label Lverde;
        private System.Windows.Forms.Label Lblue;
        private System.Windows.Forms.TextBox Thexa;
        private System.Windows.Forms.Button BCopiar;
        private System.Windows.Forms.TextBox TRGB;
        private System.Windows.Forms.Button BCopiarRGB;
    }
}

