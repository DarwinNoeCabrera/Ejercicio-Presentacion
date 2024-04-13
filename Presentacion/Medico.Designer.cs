namespace Presentacion
{
    partial class Medico
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
            this.TXTAPELLIDO = new System.Windows.Forms.TextBox();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DATAMEDICO = new System.Windows.Forms.DateTimePicker();
            this.CBESTADO = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTMEDICO = new System.Windows.Forms.TextBox();
            this.DGBMEDICOS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGBMEDICOS)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTAPELLIDO
            // 
            this.TXTAPELLIDO.Location = new System.Drawing.Point(78, 118);
            this.TXTAPELLIDO.Name = "TXTAPELLIDO";
            this.TXTAPELLIDO.Size = new System.Drawing.Size(100, 20);
            this.TXTAPELLIDO.TabIndex = 22;
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(78, 79);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(100, 20);
            this.TXTNOMBRE.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fecha Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Medico Id";
            // 
            // DATAMEDICO
            // 
            this.DATAMEDICO.Location = new System.Drawing.Point(328, 57);
            this.DATAMEDICO.Name = "DATAMEDICO";
            this.DATAMEDICO.Size = new System.Drawing.Size(200, 20);
            this.DATAMEDICO.TabIndex = 16;
            // 
            // CBESTADO
            // 
            this.CBESTADO.AutoSize = true;
            this.CBESTADO.Location = new System.Drawing.Point(251, 95);
            this.CBESTADO.Name = "CBESTADO";
            this.CBESTADO.Size = new System.Drawing.Size(59, 17);
            this.CBESTADO.TabIndex = 15;
            this.CBESTADO.Text = "Estado";
            this.CBESTADO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Medicos";
            // 
            // TXTMEDICO
            // 
            this.TXTMEDICO.Location = new System.Drawing.Point(78, 40);
            this.TXTMEDICO.Name = "TXTMEDICO";
            this.TXTMEDICO.Size = new System.Drawing.Size(100, 20);
            this.TXTMEDICO.TabIndex = 13;
            // 
            // DGBMEDICOS
            // 
            this.DGBMEDICOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBMEDICOS.Location = new System.Drawing.Point(14, 171);
            this.DGBMEDICOS.Name = "DGBMEDICOS";
            this.DGBMEDICOS.Size = new System.Drawing.Size(719, 244);
            this.DGBMEDICOS.TabIndex = 12;
            // 
            // Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTAPELLIDO);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DATAMEDICO);
            this.Controls.Add(this.CBESTADO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTMEDICO);
            this.Controls.Add(this.DGBMEDICOS);
            this.Name = "Medico";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGBMEDICOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTAPELLIDO;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DATAMEDICO;
        private System.Windows.Forms.CheckBox CBESTADO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTMEDICO;
        private System.Windows.Forms.DataGridView DGBMEDICOS;
    }
}

