
namespace CifradoCesar
{
    partial class Form1
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
            this.SISTEMA = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioDescifrar = new System.Windows.Forms.RadioButton();
            this.radioCifrar = new System.Windows.Forms.RadioButton();
            this.CriptogramaTxt = new System.Windows.Forms.TextBox();
            this.LlaveTxt = new System.Windows.Forms.TextBox();
            this.Mncltxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnCalcular = new FontAwesome.Sharp.IconButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnVerTabla = new FontAwesome.Sharp.IconButton();
            this.dtgvMatriz = new System.Windows.Forms.DataGridView();
            this.SISTEMA.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // SISTEMA
            // 
            this.SISTEMA.Controls.Add(this.tabPage1);
            this.SISTEMA.Controls.Add(this.tabPage2);
            this.SISTEMA.Location = new System.Drawing.Point(-4, 4);
            this.SISTEMA.Name = "SISTEMA";
            this.SISTEMA.SelectedIndex = 0;
            this.SISTEMA.Size = new System.Drawing.Size(1018, 556);
            this.SISTEMA.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioDescifrar);
            this.tabPage1.Controls.Add(this.radioCifrar);
            this.tabPage1.Controls.Add(this.CriptogramaTxt);
            this.tabPage1.Controls.Add(this.LlaveTxt);
            this.tabPage1.Controls.Add(this.Mncltxt);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BtnLimpiar);
            this.tabPage1.Controls.Add(this.BtnCalcular);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1010, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SISTEMA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioDescifrar
            // 
            this.radioDescifrar.AutoSize = true;
            this.radioDescifrar.Location = new System.Drawing.Point(611, 81);
            this.radioDescifrar.Name = "radioDescifrar";
            this.radioDescifrar.Size = new System.Drawing.Size(86, 21);
            this.radioDescifrar.TabIndex = 11;
            this.radioDescifrar.TabStop = true;
            this.radioDescifrar.Text = "Descifrar";
            this.radioDescifrar.UseVisualStyleBackColor = true;
            // 
            // radioCifrar
            // 
            this.radioCifrar.AutoSize = true;
            this.radioCifrar.Location = new System.Drawing.Point(611, 53);
            this.radioCifrar.Name = "radioCifrar";
            this.radioCifrar.Size = new System.Drawing.Size(63, 21);
            this.radioCifrar.TabIndex = 10;
            this.radioCifrar.TabStop = true;
            this.radioCifrar.Text = "Cifrar";
            this.radioCifrar.UseVisualStyleBackColor = true;
            // 
            // CriptogramaTxt
            // 
            this.CriptogramaTxt.Location = new System.Drawing.Point(198, 275);
            this.CriptogramaTxt.Name = "CriptogramaTxt";
            this.CriptogramaTxt.Size = new System.Drawing.Size(260, 22);
            this.CriptogramaTxt.TabIndex = 9;
            // 
            // LlaveTxt
            // 
            this.LlaveTxt.Location = new System.Drawing.Point(198, 105);
            this.LlaveTxt.Name = "LlaveTxt";
            this.LlaveTxt.Size = new System.Drawing.Size(260, 22);
            this.LlaveTxt.TabIndex = 8;
            // 
            // Mncltxt
            // 
            this.Mncltxt.Location = new System.Drawing.Point(198, 58);
            this.Mncltxt.Name = "Mncltxt";
            this.Mncltxt.Size = new System.Drawing.Size(260, 22);
            this.Mncltxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Criptograma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alfabeto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Llave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mensaje en clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "SALIDA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "ENTRADA";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BtnLimpiar.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnLimpiar.IconColor = System.Drawing.Color.Black;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.IconSize = 28;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(570, 312);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(193, 41);
            this.BtnLimpiar.TabIndex = 1;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BtnCalcular.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.BtnCalcular.IconColor = System.Drawing.Color.Black;
            this.BtnCalcular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCalcular.IconSize = 28;
            this.BtnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalcular.Location = new System.Drawing.Point(570, 148);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(193, 43);
            this.BtnCalcular.TabIndex = 0;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnVerTabla);
            this.tabPage2.Controls.Add(this.dtgvMatriz);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MATRIZ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnVerTabla
            // 
            this.btnVerTabla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVerTabla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnVerTabla.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVerTabla.Font = new System.Drawing.Font("Lucida Calligraphy", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTabla.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerTabla.IconColor = System.Drawing.Color.Black;
            this.btnVerTabla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerTabla.IconSize = 35;
            this.btnVerTabla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerTabla.Location = new System.Drawing.Point(314, 352);
            this.btnVerTabla.Name = "btnVerTabla";
            this.btnVerTabla.Size = new System.Drawing.Size(231, 44);
            this.btnVerTabla.TabIndex = 1;
            this.btnVerTabla.Text = "VER TABLA";
            this.btnVerTabla.UseVisualStyleBackColor = true;
            // 
            // dtgvMatriz
            // 
            this.dtgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMatriz.Location = new System.Drawing.Point(0, 3);
            this.dtgvMatriz.Name = "dtgvMatriz";
            this.dtgvMatriz.RowHeadersWidth = 51;
            this.dtgvMatriz.RowTemplate.Height = 24;
            this.dtgvMatriz.Size = new System.Drawing.Size(797, 328);
            this.dtgvMatriz.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 555);
            this.Controls.Add(this.SISTEMA);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIFRADO CESAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SISTEMA.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatriz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SISTEMA;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnCalcular;
        private System.Windows.Forms.RadioButton radioDescifrar;
        private System.Windows.Forms.RadioButton radioCifrar;
        private System.Windows.Forms.TextBox CriptogramaTxt;
        private System.Windows.Forms.TextBox LlaveTxt;
        private System.Windows.Forms.TextBox Mncltxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnVerTabla;
        private System.Windows.Forms.DataGridView dtgvMatriz;
    }
}

