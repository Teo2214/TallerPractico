namespace TallerPractico
{
    partial class FormClase3
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtEjeX = new System.Windows.Forms.TextBox();
            this.txtEjeY = new System.Windows.Forms.TextBox();
            this.btnCuadrante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLANO CARTESIANO ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(541, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EN ESTE PORGRAMA SE SIMULARÁ LA REPRESENTACIÓN DE UN PUNRO EN UN PLANO CARTESIANO" +
    ",";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " E IMPRIMIRÁ EN QUE CUADRANTE SE ENCUENTRA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "INGRESA EL VALOR DEL EJE X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "INGRESA EL VALOR DEL EJE Y ";
            // 
            // txtEjeX
            // 
            this.txtEjeX.Location = new System.Drawing.Point(205, 256);
            this.txtEjeX.Name = "txtEjeX";
            this.txtEjeX.Size = new System.Drawing.Size(156, 20);
            this.txtEjeX.TabIndex = 5;
            this.txtEjeX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEjeY
            // 
            this.txtEjeY.Location = new System.Drawing.Point(502, 256);
            this.txtEjeY.Name = "txtEjeY";
            this.txtEjeY.Size = new System.Drawing.Size(156, 20);
            this.txtEjeY.TabIndex = 6;
            // 
            // btnCuadrante
            // 
            this.btnCuadrante.Location = new System.Drawing.Point(369, 393);
            this.btnCuadrante.Name = "btnCuadrante";
            this.btnCuadrante.Size = new System.Drawing.Size(167, 68);
            this.btnCuadrante.TabIndex = 7;
            this.btnCuadrante.Text = "SABER EL CUADRANTE DE MI PUNTO ";
            this.btnCuadrante.UseVisualStyleBackColor = true;
            this.btnCuadrante.Click += new System.EventHandler(this.btnCuadrante_Click);
            // 
            // FormClase3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 612);
            this.Controls.Add(this.btnCuadrante);
            this.Controls.Add(this.txtEjeY);
            this.Controls.Add(this.txtEjeX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormClase3";
            this.Text = "FormClase3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEjeX;
        private System.Windows.Forms.TextBox txtEjeY;
        private System.Windows.Forms.Button btnCuadrante;
    }
}