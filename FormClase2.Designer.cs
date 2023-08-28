namespace TallerPractico
{
    partial class FormClase2
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.btnLadoM = new System.Windows.Forms.Button();
            this.btnEquilatero = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOS LADOS DE UN TRIANGULO ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESA EL LADO 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "INGRESA EL LADO 2 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "INGRESA EL LADO 3";
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(221, 187);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(181, 20);
            this.txtLado1.TabIndex = 4;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(221, 261);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(181, 20);
            this.txtLado2.TabIndex = 5;
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(221, 338);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(181, 20);
            this.txtLado3.TabIndex = 6;
            // 
            // btnLadoM
            // 
            this.btnLadoM.Location = new System.Drawing.Point(255, 460);
            this.btnLadoM.Name = "btnLadoM";
            this.btnLadoM.Size = new System.Drawing.Size(136, 61);
            this.btnLadoM.TabIndex = 7;
            this.btnLadoM.Text = "¿CUAL ES EL LADO MAYOR?";
            this.btnLadoM.UseVisualStyleBackColor = true;
            this.btnLadoM.Click += new System.EventHandler(this.btnLadoM_Click);
            // 
            // btnEquilatero
            // 
            this.btnEquilatero.Location = new System.Drawing.Point(623, 460);
            this.btnEquilatero.Name = "btnEquilatero";
            this.btnEquilatero.Size = new System.Drawing.Size(136, 61);
            this.btnEquilatero.TabIndex = 8;
            this.btnEquilatero.Text = "¿ES EQUILATERO?";
            this.btnEquilatero.UseVisualStyleBackColor = true;
            this.btnEquilatero.Click += new System.EventHandler(this.btnEquilatero_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(458, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "EN ESTE PROGRAMA SABRÁS SI TU TRIANGULO ES EQUILATERO SEGUN SUS LADOS ";
            // 
            // FormClase2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 612);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEquilatero);
            this.Controls.Add(this.btnLadoM);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormClase2";
            this.Text = "FormClase2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Button btnLadoM;
        private System.Windows.Forms.Button btnEquilatero;
        private System.Windows.Forms.Label label5;
    }
}