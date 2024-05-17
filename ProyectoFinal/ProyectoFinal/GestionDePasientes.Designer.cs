namespace ProyectoFinal
{
    partial class GestionDePasientes
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
            this.btn_Doctor = new System.Windows.Forms.Button();
            this.btn_Pasientes = new System.Windows.Forms.Button();
            this.tn_Historrial = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_X = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SALIR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "HISTORIAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "PACIENTES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOCTOR";
            // 
            // btn_Doctor
            // 
            this.btn_Doctor.Location = new System.Drawing.Point(407, 58);
            this.btn_Doctor.Name = "btn_Doctor";
            this.btn_Doctor.Size = new System.Drawing.Size(118, 27);
            this.btn_Doctor.TabIndex = 5;
            this.btn_Doctor.Text = "LOGIN";
            this.btn_Doctor.UseVisualStyleBackColor = true;
            // 
            // btn_Pasientes
            // 
            this.btn_Pasientes.Location = new System.Drawing.Point(407, 134);
            this.btn_Pasientes.Name = "btn_Pasientes";
            this.btn_Pasientes.Size = new System.Drawing.Size(118, 27);
            this.btn_Pasientes.TabIndex = 6;
            this.btn_Pasientes.Text = "LOGIN";
            this.btn_Pasientes.UseVisualStyleBackColor = true;
            // 
            // tn_Historrial
            // 
            this.tn_Historrial.Location = new System.Drawing.Point(407, 209);
            this.tn_Historrial.Name = "tn_Historrial";
            this.tn_Historrial.Size = new System.Drawing.Size(118, 27);
            this.tn_Historrial.TabIndex = 7;
            this.tn_Historrial.Text = "LOGIN";
            this.tn_Historrial.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(407, 291);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(118, 27);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.Text = "LOGIN";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_X
            // 
            this.btn_X.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_X.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_X.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_X.Location = new System.Drawing.Point(708, 15);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(80, 41);
            this.btn_X.TabIndex = 9;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // GestionDePasientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_X);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.tn_Historrial);
            this.Controls.Add(this.btn_Pasientes);
            this.Controls.Add(this.btn_Doctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionDePasientes";
            this.Text = "GestionDePasientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Doctor;
        private System.Windows.Forms.Button btn_Pasientes;
        private System.Windows.Forms.Button tn_Historrial;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_X;
    }
}