namespace TallerPractico
{
    partial class FormClase4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.btnSuperficie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "EL CUADRADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(697, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EL SIGUIENTE PROGRAMA PERMITIRÁ SABER EL PERIMETRO Y SUPERFICIE DE UN CUADRADO SO" +
    "LO CON LA MEDIDA DE SU LADO ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "INGRESE LA MEDIDA DEL LADO";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(191, 253);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(139, 20);
            this.txtLado.TabIndex = 3;
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(191, 390);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(130, 40);
            this.btnPerimetro.TabIndex = 4;
            this.btnPerimetro.Text = "PERIMETRO";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            this.btnPerimetro.Click += new System.EventHandler(this.btnPerimetro_Click);
            // 
            // btnSuperficie
            // 
            this.btnSuperficie.Location = new System.Drawing.Point(577, 390);
            this.btnSuperficie.Name = "btnSuperficie";
            this.btnSuperficie.Size = new System.Drawing.Size(130, 40);
            this.btnSuperficie.TabIndex = 5;
            this.btnSuperficie.Text = "SUPERFICIE ";
            this.btnSuperficie.UseVisualStyleBackColor = true;
            this.btnSuperficie.Click += new System.EventHandler(this.btnSuperficie_Click);
            // 
            // FormClase4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 612);
            this.Controls.Add(this.btnSuperficie);
            this.Controls.Add(this.btnPerimetro);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormClase4";
            this.Text = "FormClase4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Button btnSuperficie;
    }
}