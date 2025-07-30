namespace WindowsFormsApp
{
    partial class Form_Proveedor
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
            this.paquetesDGV = new System.Windows.Forms.DataGridView();
            this.cuentaLBL = new System.Windows.Forms.Label();
            this.cuenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paquetesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // paquetesDGV
            // 
            this.paquetesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paquetesDGV.Location = new System.Drawing.Point(115, 138);
            this.paquetesDGV.Name = "paquetesDGV";
            this.paquetesDGV.Size = new System.Drawing.Size(523, 223);
            this.paquetesDGV.TabIndex = 1;
            this.paquetesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paquetesDGV_CellContentClick);
            // 
            // cuentaLBL
            // 
            this.cuentaLBL.AutoSize = true;
            this.cuentaLBL.Location = new System.Drawing.Point(65, 11);
            this.cuentaLBL.Name = "cuentaLBL";
            this.cuentaLBL.Size = new System.Drawing.Size(10, 13);
            this.cuentaLBL.TabIndex = 6;
            this.cuentaLBL.Text = "-";
            // 
            // cuenta
            // 
            this.cuenta.AutoSize = true;
            this.cuenta.Location = new System.Drawing.Point(7, 11);
            this.cuenta.Name = "cuenta";
            this.cuenta.Size = new System.Drawing.Size(43, 13);
            this.cuenta.TabIndex = 5;
            this.cuenta.Text = "cuenta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paquetes asociados a su cuenta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Consultar Envios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cuentaLBL);
            this.Controls.Add(this.cuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paquetesDGV);
            this.Name = "Form_Proveedor";
            this.Text = "Form_Proveedor";
            this.Load += new System.EventHandler(this.Form_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paquetesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView paquetesDGV;
        private System.Windows.Forms.Label cuentaLBL;
        private System.Windows.Forms.Label cuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}