namespace Ejercicio_21
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxHour = new System.Windows.Forms.MaskedTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxIDEmploye = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxMatricula = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxValorVenta = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // maskedTextBoxHour
            // 
            this.maskedTextBoxHour.Location = new System.Drawing.Point(161, 82);
            this.maskedTextBoxHour.Mask = "00:00";
            this.maskedTextBoxHour.Name = "maskedTextBoxHour";
            this.maskedTextBoxHour.Size = new System.Drawing.Size(200, 22);
            this.maskedTextBoxHour.TabIndex = 1;
            this.maskedTextBoxHour.ValidatingType = typeof(System.DateTime);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(29, 39);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Fecha";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(29, 87);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(37, 16);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Empleado";
            // 
            // maskedTextBoxIDEmploye
            // 
            this.maskedTextBoxIDEmploye.Location = new System.Drawing.Point(161, 139);
            this.maskedTextBoxIDEmploye.Mask = "V00000000";
            this.maskedTextBoxIDEmploye.Name = "maskedTextBoxIDEmploye";
            this.maskedTextBoxIDEmploye.Size = new System.Drawing.Size(200, 22);
            this.maskedTextBoxIDEmploye.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(29, 191);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(32, 242);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(61, 16);
            this.lblMatricula.TabIndex = 7;
            this.lblMatricula.Text = "Matricula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valor de venta";
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(161, 191);
            this.maskedTextBoxTelefone.Mask = "000 000 000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(200, 22);
            this.maskedTextBoxTelefone.TabIndex = 9;
            // 
            // maskedTextBoxMatricula
            // 
            this.maskedTextBoxMatricula.Location = new System.Drawing.Point(161, 239);
            this.maskedTextBoxMatricula.Mask = "0000LLL";
            this.maskedTextBoxMatricula.Name = "maskedTextBoxMatricula";
            this.maskedTextBoxMatricula.Size = new System.Drawing.Size(200, 22);
            this.maskedTextBoxMatricula.TabIndex = 10;
            // 
            // maskedTextBoxValorVenta
            // 
            this.maskedTextBoxValorVenta.Location = new System.Drawing.Point(161, 292);
            this.maskedTextBoxValorVenta.Mask = "00000000.00€";
            this.maskedTextBoxValorVenta.Name = "maskedTextBoxValorVenta";
            this.maskedTextBoxValorVenta.Size = new System.Drawing.Size(200, 22);
            this.maskedTextBoxValorVenta.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(547, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 276);
            this.listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBoxValorVenta);
            this.Controls.Add(this.maskedTextBoxMatricula);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.maskedTextBoxIDEmploye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.maskedTextBoxHour);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHour;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIDEmploye;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMatricula;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValorVenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

