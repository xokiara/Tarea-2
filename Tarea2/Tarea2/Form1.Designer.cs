﻿namespace Tarea2
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
            this.components = new System.ComponentModel.Container();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Nota1TextBox = new System.Windows.Forms.TextBox();
            this.Nota2TextBox = new System.Windows.Forms.TextBox();
            this.Nota3TextBox = new System.Windows.Forms.TextBox();
            this.Nota4TextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(61, 279);
            this.CalcularButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(200, 34);
            this.CalcularButton.TabIndex = 0;
            this.CalcularButton.Text = "Calcular Promedio Final";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar Notas de los Parciales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota 4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nota 3:";
            // 
            // Nota1TextBox
            // 
            this.Nota1TextBox.Location = new System.Drawing.Point(102, 97);
            this.Nota1TextBox.Name = "Nota1TextBox";
            this.Nota1TextBox.Size = new System.Drawing.Size(100, 26);
            this.Nota1TextBox.TabIndex = 6;
            // 
            // Nota2TextBox
            // 
            this.Nota2TextBox.Location = new System.Drawing.Point(102, 137);
            this.Nota2TextBox.Name = "Nota2TextBox";
            this.Nota2TextBox.Size = new System.Drawing.Size(100, 26);
            this.Nota2TextBox.TabIndex = 7;
            // 
            // Nota3TextBox
            // 
            this.Nota3TextBox.Location = new System.Drawing.Point(102, 179);
            this.Nota3TextBox.Name = "Nota3TextBox";
            this.Nota3TextBox.Size = new System.Drawing.Size(100, 26);
            this.Nota3TextBox.TabIndex = 8;
            // 
            // Nota4TextBox
            // 
            this.Nota4TextBox.Location = new System.Drawing.Point(102, 225);
            this.Nota4TextBox.Name = "Nota4TextBox";
            this.Nota4TextBox.Size = new System.Drawing.Size(100, 26);
            this.Nota4TextBox.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 359);
            this.Controls.Add(this.Nota4TextBox);
            this.Controls.Add(this.Nota3TextBox);
            this.Controls.Add(this.Nota2TextBox);
            this.Controls.Add(this.Nota1TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcularButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nota1TextBox;
        private System.Windows.Forms.TextBox Nota2TextBox;
        private System.Windows.Forms.TextBox Nota3TextBox;
        private System.Windows.Forms.TextBox Nota4TextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

