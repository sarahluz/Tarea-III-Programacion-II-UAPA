namespace THISONE
{
    partial class frmDashboard
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
            this.lblejercicios = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSueldos = new System.Windows.Forms.Button();
            this.btnConvertidor = new System.Windows.Forms.Button();
            this.btnCuadratica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblejercicios
            // 
            this.lblejercicios.AutoSize = true;
            this.lblejercicios.Location = new System.Drawing.Point(22, 19);
            this.lblejercicios.Name = "lblejercicios";
            this.lblejercicios.Size = new System.Drawing.Size(207, 13);
            this.lblejercicios.TabIndex = 0;
            this.lblejercicios.Text = "Seleccione el ejercicio que desea ejecutar";
            this.lblejercicios.Click += new System.EventHandler(this.lblRecibido_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(193, 113);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSueldos
            // 
            this.btnSueldos.Location = new System.Drawing.Point(12, 44);
            this.btnSueldos.Name = "btnSueldos";
            this.btnSueldos.Size = new System.Drawing.Size(75, 23);
            this.btnSueldos.TabIndex = 2;
            this.btnSueldos.Text = "Sueldos";
            this.btnSueldos.UseVisualStyleBackColor = true;
            // 
            // btnConvertidor
            // 
            this.btnConvertidor.Location = new System.Drawing.Point(103, 44);
            this.btnConvertidor.Name = "btnConvertidor";
            this.btnConvertidor.Size = new System.Drawing.Size(75, 23);
            this.btnConvertidor.TabIndex = 3;
            this.btnConvertidor.Text = "Convertidor";
            this.btnConvertidor.UseVisualStyleBackColor = true;
            // 
            // btnCuadratica
            // 
            this.btnCuadratica.Location = new System.Drawing.Point(193, 44);
            this.btnCuadratica.Name = "btnCuadratica";
            this.btnCuadratica.Size = new System.Drawing.Size(75, 23);
            this.btnCuadratica.TabIndex = 4;
            this.btnCuadratica.Text = "Cuadratica";
            this.btnCuadratica.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(280, 148);
            this.Controls.Add(this.btnCuadratica);
            this.Controls.Add(this.btnConvertidor);
            this.Controls.Add(this.btnSueldos);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblejercicios);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDashboard";
            this.ShowIcon = false;
            this.Text = "Tablero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblejercicios;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSueldos;
        private System.Windows.Forms.Button btnConvertidor;
        private System.Windows.Forms.Button btnCuadratica;
    }
}