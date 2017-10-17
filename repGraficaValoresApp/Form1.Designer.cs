namespace repGraficaValoresApp
{
    partial class Representación
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
            this.lbValores = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbValRepresentar = new System.Windows.Forms.Label();
            this.valorReal = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.valorRelativo = new System.Windows.Forms.TextBox();
            this.errorAbsoluto = new System.Windows.Forms.TextBox();
            this.panelLinea = new System.Windows.Forms.Panel();
            this.minimo = new System.Windows.Forms.NumericUpDown();
            this.maximo = new System.Windows.Forms.NumericUpDown();
            this.cantFrecuencia = new System.Windows.Forms.NumericUpDown();
            this.valoresY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantFrecuencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lbValores
            // 
            this.lbValores.AutoSize = true;
            this.lbValores.Location = new System.Drawing.Point(13, 13);
            this.lbValores.Name = "lbValores";
            this.lbValores.Size = new System.Drawing.Size(60, 13);
            this.lbValores.TabIndex = 0;
            this.lbValores.Text = "Valores de ";
            this.lbValores.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "a";
            // 
            // lbValRepresentar
            // 
            this.lbValRepresentar.AutoSize = true;
            this.lbValRepresentar.Location = new System.Drawing.Point(13, 41);
            this.lbValRepresentar.Name = "lbValRepresentar";
            this.lbValRepresentar.Size = new System.Drawing.Size(161, 13);
            this.lbValRepresentar.TabIndex = 4;
            this.lbValRepresentar.Text = "Número de valores a representar";
            // 
            // valorReal
            // 
            this.valorReal.Location = new System.Drawing.Point(386, 42);
            this.valorReal.Multiline = true;
            this.valorReal.Name = "valorReal";
            this.valorReal.Size = new System.Drawing.Size(57, 211);
            this.valorReal.TabIndex = 6;
            this.valorReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGenerar.Location = new System.Drawing.Point(245, 36);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // valorRelativo
            // 
            this.valorRelativo.Location = new System.Drawing.Point(512, 41);
            this.valorRelativo.Multiline = true;
            this.valorRelativo.Name = "valorRelativo";
            this.valorRelativo.Size = new System.Drawing.Size(57, 212);
            this.valorRelativo.TabIndex = 8;
            this.valorRelativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorAbsoluto
            // 
            this.errorAbsoluto.Location = new System.Drawing.Point(449, 42);
            this.errorAbsoluto.Multiline = true;
            this.errorAbsoluto.Name = "errorAbsoluto";
            this.errorAbsoluto.Size = new System.Drawing.Size(57, 211);
            this.errorAbsoluto.TabIndex = 9;
            this.errorAbsoluto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelLinea
            // 
            this.panelLinea.BackColor = System.Drawing.SystemColors.Info;
            this.panelLinea.Location = new System.Drawing.Point(3, 259);
            this.panelLinea.Name = "panelLinea";
            this.panelLinea.Size = new System.Drawing.Size(685, 221);
            this.panelLinea.TabIndex = 10;
            this.panelLinea.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLinea_Paint);
            // 
            // minimo
            // 
            this.minimo.Location = new System.Drawing.Point(76, 11);
            this.minimo.Maximum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.minimo.Minimum = new decimal(new int[] {
            125,
            0,
            0,
            -2147483648});
            this.minimo.Name = "minimo";
            this.minimo.Size = new System.Drawing.Size(51, 20);
            this.minimo.TabIndex = 11;
            this.minimo.ValueChanged += new System.EventHandler(this.minimo_ValueChanged);
            // 
            // maximo
            // 
            this.maximo.Location = new System.Drawing.Point(163, 11);
            this.maximo.Maximum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.maximo.Minimum = new decimal(new int[] {
            125,
            0,
            0,
            -2147483648});
            this.maximo.Name = "maximo";
            this.maximo.Size = new System.Drawing.Size(50, 20);
            this.maximo.TabIndex = 12;
            this.maximo.ValueChanged += new System.EventHandler(this.maximo_ValueChanged);
            // 
            // cantFrecuencia
            // 
            this.cantFrecuencia.Location = new System.Drawing.Point(180, 36);
            this.cantFrecuencia.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cantFrecuencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantFrecuencia.Name = "cantFrecuencia";
            this.cantFrecuencia.Size = new System.Drawing.Size(50, 20);
            this.cantFrecuencia.TabIndex = 13;
            this.cantFrecuencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // valoresY
            // 
            this.valoresY.Location = new System.Drawing.Point(575, 41);
            this.valoresY.Multiline = true;
            this.valoresY.Name = "valoresY";
            this.valoresY.Size = new System.Drawing.Size(57, 212);
            this.valoresY.TabIndex = 14;
            this.valoresY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(382, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valor Real";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(595, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "Y";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(447, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Error Absoluto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(510, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "% Error Relativo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Representación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 487);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valoresY);
            this.Controls.Add(this.cantFrecuencia);
            this.Controls.Add(this.maximo);
            this.Controls.Add(this.minimo);
            this.Controls.Add(this.panelLinea);
            this.Controls.Add(this.errorAbsoluto);
            this.Controls.Add(this.valorRelativo);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.valorReal);
            this.Controls.Add(this.lbValRepresentar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbValores);
            this.Name = "Representación";
            this.Text = "Reprentación Gráfica";
            ((System.ComponentModel.ISupportInitialize)(this.minimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantFrecuencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbValores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbValRepresentar;
        private System.Windows.Forms.TextBox valorReal;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox valorRelativo;
        private System.Windows.Forms.TextBox errorAbsoluto;
        private System.Windows.Forms.Panel panelLinea;
        private System.Windows.Forms.NumericUpDown minimo;
        private System.Windows.Forms.NumericUpDown maximo;
        private System.Windows.Forms.NumericUpDown cantFrecuencia;
        private System.Windows.Forms.TextBox valoresY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

