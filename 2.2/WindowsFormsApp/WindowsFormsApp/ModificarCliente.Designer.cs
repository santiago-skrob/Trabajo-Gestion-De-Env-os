namespace WindowsFormsApp
{
    partial class ModificarCliente
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
            this.tipoLBL = new System.Windows.Forms.Label();
            this.contraLBL = new System.Windows.Forms.Label();
            this.usuarioLBL = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buscarIdBTN = new System.Windows.Forms.Button();
            this.idClienteBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioBOX = new System.Windows.Forms.TextBox();
            this.contraBOX = new System.Windows.Forms.TextBox();
            this.tipoBOX = new System.Windows.Forms.TextBox();
            this.cambiarBTN = new System.Windows.Forms.Button();
            this.cuentasDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoLBL
            // 
            this.tipoLBL.AutoSize = true;
            this.tipoLBL.Location = new System.Drawing.Point(140, 245);
            this.tipoLBL.Name = "tipoLBL";
            this.tipoLBL.Size = new System.Drawing.Size(10, 13);
            this.tipoLBL.TabIndex = 27;
            this.tipoLBL.Text = "-";
            // 
            // contraLBL
            // 
            this.contraLBL.AutoSize = true;
            this.contraLBL.Location = new System.Drawing.Point(140, 218);
            this.contraLBL.Name = "contraLBL";
            this.contraLBL.Size = new System.Drawing.Size(10, 13);
            this.contraLBL.TabIndex = 26;
            this.contraLBL.Text = "-";
            // 
            // usuarioLBL
            // 
            this.usuarioLBL.AutoSize = true;
            this.usuarioLBL.Location = new System.Drawing.Point(140, 188);
            this.usuarioLBL.Name = "usuarioLBL";
            this.usuarioLBL.Size = new System.Drawing.Size(10, 13);
            this.usuarioLBL.TabIndex = 25;
            this.usuarioLBL.Text = "-";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(140, 154);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(10, 13);
            this.idLabel.TabIndex = 24;
            this.idLabel.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "contrasenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ID";
            // 
            // buscarIdBTN
            // 
            this.buscarIdBTN.Location = new System.Drawing.Point(44, 78);
            this.buscarIdBTN.Name = "buscarIdBTN";
            this.buscarIdBTN.Size = new System.Drawing.Size(75, 23);
            this.buscarIdBTN.TabIndex = 16;
            this.buscarIdBTN.Text = "Buscar";
            this.buscarIdBTN.UseVisualStyleBackColor = true;
            this.buscarIdBTN.Click += new System.EventHandler(this.buscarIdBTN_Click);
            // 
            // idClienteBOX
            // 
            this.idClienteBOX.Location = new System.Drawing.Point(24, 52);
            this.idClienteBOX.Name = "idClienteBOX";
            this.idClienteBOX.Size = new System.Drawing.Size(126, 20);
            this.idClienteBOX.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar Por ID";
            // 
            // usuarioBOX
            // 
            this.usuarioBOX.Location = new System.Drawing.Point(179, 185);
            this.usuarioBOX.Name = "usuarioBOX";
            this.usuarioBOX.Size = new System.Drawing.Size(126, 20);
            this.usuarioBOX.TabIndex = 28;
            // 
            // contraBOX
            // 
            this.contraBOX.Location = new System.Drawing.Point(179, 211);
            this.contraBOX.Name = "contraBOX";
            this.contraBOX.Size = new System.Drawing.Size(126, 20);
            this.contraBOX.TabIndex = 29;
            // 
            // tipoBOX
            // 
            this.tipoBOX.Location = new System.Drawing.Point(179, 237);
            this.tipoBOX.Name = "tipoBOX";
            this.tipoBOX.Size = new System.Drawing.Size(126, 20);
            this.tipoBOX.TabIndex = 30;
            // 
            // cambiarBTN
            // 
            this.cambiarBTN.Location = new System.Drawing.Point(75, 286);
            this.cambiarBTN.Name = "cambiarBTN";
            this.cambiarBTN.Size = new System.Drawing.Size(75, 23);
            this.cambiarBTN.TabIndex = 31;
            this.cambiarBTN.Text = "cambiar";
            this.cambiarBTN.UseVisualStyleBackColor = true;
            this.cambiarBTN.Click += new System.EventHandler(this.cambiarBTN_Click);
            // 
            // cuentasDGV
            // 
            this.cuentasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuentasDGV.Location = new System.Drawing.Point(402, 42);
            this.cuentasDGV.Name = "cuentasDGV";
            this.cuentasDGV.Size = new System.Drawing.Size(372, 332);
            this.cuentasDGV.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "eliminar cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cuentasDGV);
            this.Controls.Add(this.cambiarBTN);
            this.Controls.Add(this.tipoBOX);
            this.Controls.Add(this.contraBOX);
            this.Controls.Add(this.usuarioBOX);
            this.Controls.Add(this.tipoLBL);
            this.Controls.Add(this.contraLBL);
            this.Controls.Add(this.usuarioLBL);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buscarIdBTN);
            this.Controls.Add(this.idClienteBOX);
            this.Controls.Add(this.label1);
            this.Name = "ModificarCliente";
            this.Text = "ModificarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.cuentasDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tipoLBL;
        private System.Windows.Forms.Label contraLBL;
        private System.Windows.Forms.Label usuarioLBL;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buscarIdBTN;
        private System.Windows.Forms.TextBox idClienteBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuarioBOX;
        private System.Windows.Forms.TextBox contraBOX;
        private System.Windows.Forms.TextBox tipoBOX;
        private System.Windows.Forms.Button cambiarBTN;
        private System.Windows.Forms.DataGridView cuentasDGV;
        private System.Windows.Forms.Button button1;
    }
}