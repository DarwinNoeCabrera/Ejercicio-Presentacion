namespace Presentacion
{
    partial class Cita
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
            this.components = new System.ComponentModel.Container();
            this.TXTPACIENTE = new System.Windows.Forms.TextBox();
            this.TXTMEDICO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DATACITA = new System.Windows.Forms.DateTimePicker();
            this.CBESTADO = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTCITA = new System.Windows.Forms.TextBox();
            this.DGBCITA = new System.Windows.Forms.DataGridView();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGBCITA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTPACIENTE
            // 
            this.TXTPACIENTE.Location = new System.Drawing.Point(78, 120);
            this.TXTPACIENTE.Name = "TXTPACIENTE";
            this.TXTPACIENTE.Size = new System.Drawing.Size(100, 20);
            this.TXTPACIENTE.TabIndex = 22;
            // 
            // TXTMEDICO
            // 
            this.TXTMEDICO.Location = new System.Drawing.Point(78, 81);
            this.TXTMEDICO.Name = "TXTMEDICO";
            this.TXTMEDICO.Size = new System.Drawing.Size(100, 20);
            this.TXTMEDICO.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fecha Cita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Paciente Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Medico Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cita Id";
            // 
            // DATACITA
            // 
            this.DATACITA.Location = new System.Drawing.Point(328, 59);
            this.DATACITA.Name = "DATACITA";
            this.DATACITA.Size = new System.Drawing.Size(200, 20);
            this.DATACITA.TabIndex = 16;
            // 
            // CBESTADO
            // 
            this.CBESTADO.AutoSize = true;
            this.CBESTADO.Location = new System.Drawing.Point(251, 97);
            this.CBESTADO.Name = "CBESTADO";
            this.CBESTADO.Size = new System.Drawing.Size(59, 17);
            this.CBESTADO.TabIndex = 15;
            this.CBESTADO.Text = "Estado";
            this.CBESTADO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cita";
            // 
            // TXTCITA
            // 
            this.TXTCITA.Location = new System.Drawing.Point(78, 42);
            this.TXTCITA.Name = "TXTCITA";
            this.TXTCITA.Size = new System.Drawing.Size(100, 20);
            this.TXTCITA.TabIndex = 13;
            // 
            // DGBCITA
            // 
            this.DGBCITA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBCITA.Location = new System.Drawing.Point(14, 173);
            this.DGBCITA.Name = "DGBCITA";
            this.DGBCITA.Size = new System.Drawing.Size(719, 244);
            this.DGBCITA.TabIndex = 12;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(372, 123);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 23;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(453, 123);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 24;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TXTPACIENTE);
            this.Controls.Add(this.TXTMEDICO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DATACITA);
            this.Controls.Add(this.CBESTADO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTCITA);
            this.Controls.Add(this.DGBCITA);
            this.Name = "Cita";
            this.Text = "Cita";
            ((System.ComponentModel.ISupportInitialize)(this.DGBCITA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTPACIENTE;
        private System.Windows.Forms.TextBox TXTMEDICO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DATACITA;
        private System.Windows.Forms.CheckBox CBESTADO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTCITA;
        private System.Windows.Forms.DataGridView DGBCITA;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}