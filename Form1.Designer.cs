namespace EJER18B
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.boxLado1 = new System.Windows.Forms.TextBox();
            this.boxLado3 = new System.Windows.Forms.TextBox();
            this.boxLado2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEquilatero = new System.Windows.Forms.Button();
            this.buttonLadoMayor = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(12, 26);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(12, 55);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 1;
            this.lblBase.Text = "Base";
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(12, 88);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(31, 13);
            this.lblLado.TabIndex = 2;
            this.lblLado.Text = "Lado";
            // 
            // boxLado1
            // 
            this.boxLado1.Location = new System.Drawing.Point(52, 23);
            this.boxLado1.Name = "boxLado1";
            this.boxLado1.Size = new System.Drawing.Size(100, 20);
            this.boxLado1.TabIndex = 3;
            // 
            // boxLado3
            // 
            this.boxLado3.Location = new System.Drawing.Point(52, 85);
            this.boxLado3.Name = "boxLado3";
            this.boxLado3.Size = new System.Drawing.Size(100, 20);
            this.boxLado3.TabIndex = 4;
            // 
            // boxLado2
            // 
            this.boxLado2.Location = new System.Drawing.Point(52, 52);
            this.boxLado2.Name = "boxLado2";
            this.boxLado2.Size = new System.Drawing.Size(100, 20);
            this.boxLado2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "CREAR TRIANGULO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEquilatero
            // 
            this.buttonEquilatero.Enabled = false;
            this.buttonEquilatero.Location = new System.Drawing.Point(12, 135);
            this.buttonEquilatero.Name = "buttonEquilatero";
            this.buttonEquilatero.Size = new System.Drawing.Size(75, 23);
            this.buttonEquilatero.TabIndex = 7;
            this.buttonEquilatero.Text = "Equilatero";
            this.buttonEquilatero.UseVisualStyleBackColor = true;
            this.buttonEquilatero.Click += new System.EventHandler(this.buttonEquilatero_Click);
            // 
            // buttonLadoMayor
            // 
            this.buttonLadoMayor.Enabled = false;
            this.buttonLadoMayor.Location = new System.Drawing.Point(93, 135);
            this.buttonLadoMayor.Name = "buttonLadoMayor";
            this.buttonLadoMayor.Size = new System.Drawing.Size(75, 23);
            this.buttonLadoMayor.TabIndex = 8;
            this.buttonLadoMayor.Text = "Lado Mayor";
            this.buttonLadoMayor.UseVisualStyleBackColor = true;
            this.buttonLadoMayor.Click += new System.EventHandler(this.buttonLadoMayor_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.Enabled = false;
            this.buttonArea.Location = new System.Drawing.Point(174, 135);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(75, 23);
            this.buttonArea.TabIndex = 9;
            this.buttonArea.Text = "Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 173);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonLadoMayor);
            this.Controls.Add(this.buttonEquilatero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxLado2);
            this.Controls.Add(this.boxLado3);
            this.Controls.Add(this.boxLado1);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblAltura);
            this.Name = "Form1";
            this.Text = "Clase Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox boxLado1;
        private System.Windows.Forms.TextBox boxLado3;
        private System.Windows.Forms.TextBox boxLado2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEquilatero;
        private System.Windows.Forms.Button buttonLadoMayor;
        private System.Windows.Forms.Button buttonArea;
    }
}

