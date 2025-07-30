namespace WindowsFormsApp
{
    partial class ModificarRepartidor
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
            this.cuentasDGV = new System.Windows.Forms.DataGridView();
            this.cambiarBTN = new System.Windows.Forms.Button();
            this.tipoBOX = new System.Windows.Forms.TextBox();
            this.contraBOX = new System.Windows.Forms.TextBox();
            this.usuarioBOX = new System.Windows.Forms.TextBox();
            this.tipoLBL = new System.Windows.Forms.Label();
            this.contraLBL = new System.Windows.Forms.Label();
            this.usuarioLBL = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buscarIdBTN = new System.Windows.Forms.Button();
            this.idRepartidorBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cuentasDGV
            // 
            this.cuentasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuentasDGV.Location = new System.Drawing.Point(396, 41);
            this.cuentasDGV.Name = "cuentasDGV";
            this.cuentasDGV.Size = new System.Drawing.Size(372, 332);
            this.cuentasDGV.TabIndex = 51;
            // 
            // cambiarBTN
            // 
            this.cambiarBTN.Location = new System.Drawing.Point(55, 283);
            this.cambiarBTN.Name = "cambiarBTN";
            this.cambiarBTN.Size = new System.Drawing.Size(75, 23);
            this.cambiarBTN.TabIndex = 50;
            this.cambiarBTN.Text = "cambiar";
            this.cambiarBTN.UseVisualStyleBackColor = true;
            this.cambiarBTN.Click += new System.EventHandler(this.cambiarBTN_Click);
            // 
            // tipoBOX
            // 
            this.tipoBOX.Location = new System.Drawing.Point(173, 236);
            this.tipoBOX.Name = "tipoBOX";
            this.tipoBOX.Size = new System.Drawing.Size(126, 20);
            this.tipoBOX.TabIndex = 49;
            // 
            // contraBOX
            // 
            this.contraBOX.Location = new System.Drawing.Point(173, 210);
            this.contraBOX.Name = "contraBOX";
            this.contraBOX.Size = new System.Drawing.Size(126, 20);
            this.contraBOX.TabIndex = 48;
            // 
            // usuarioBOX
            // 
            this.usuarioBOX.Location = new System.Drawing.Point(173, 184);
            this.usuarioBOX.Name = "usuarioBOX";
            this.usuarioBOX.Size = new System.Drawing.Size(126, 20);
            this.usuarioBOX.TabIndex = 47;
            // 
            // tipoLBL
            // 
            this.tipoLBL.AutoSize = true;
            this.tipoLBL.Location = new System.Drawing.Point(134, 244);
            this.tipoLBL.Name = "tipoLBL";
            this.tipoLBL.Size = new System.Drawing.Size(10, 13);
            this.tipoLBL.TabIndex = 46;
            this.tipoLBL.Text = "-";
            // 
            // contraLBL
            // 
            this.contraLBL.AutoSize = true;
            this.contraLBL.Location = new System.Drawing.Point(134, 217);
            this.contraLBL.Name = "contraLBL";
            this.contraLBL.Size = new System.Drawing.Size(10, 13);
            this.contraLBL.TabIndex = 45;
            this.contraLBL.Text = "-";
            // 
            // usuarioLBL
            // 
            this.usuarioLBL.AutoSize = true;
            this.usuarioLBL.Location = new System.Drawing.Point(134, 187);
            this.usuarioLBL.Name = "usuarioLBL";
            this.usuarioLBL.Size = new System.Drawing.Size(10, 13);
            this.usuarioLBL.TabIndex = 44;
            this.usuarioLBL.Text = "-";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(134, 153);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(10, 13);
            this.idLabel.TabIndex = 43;
            this.idLabel.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "contrasenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "ID";
            // 
            // buscarIdBTN
            // 
            this.buscarIdBTN.Location = new System.Drawing.Point(38, 77);
            this.buscarIdBTN.Name = "buscarIdBTN";
            this.buscarIdBTN.Size = new System.Drawing.Size(75, 23);
            this.buscarIdBTN.TabIndex = 35;
            this.buscarIdBTN.Text = "Buscar";
            this.buscarIdBTN.UseVisualStyleBackColor = true;
            this.buscarIdBTN.Click += new System.EventHandler(this.buscarIdBTN_Click);
            // 
            // idRepartidorBOX
            // 
            this.idRepartidorBOX.Location = new System.Drawing.Point(18, 51);
            this.idRepartidorBOX.Name = "idRepartidorBOX";
            this.idRepartidorBOX.Size = new System.Drawing.Size(126, 20);
            this.idRepartidorBOX.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Buscar Por ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "eliminar repartidor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificarRepartidor
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
            this.Controls.Add(this.idRepartidorBOX);
            this.Controls.Add(this.label1);
            this.Name = "ModificarRepartidor";
            this.Text = "ModificarRepartidor";
            this.Load += new System.EventHandler(this.ModificarRepartidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuentasDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cuentasDGV;
        private System.Windows.Forms.Button cambiarBTN;
        private System.Windows.Forms.TextBox tipoBOX;
        private System.Windows.Forms.TextBox contraBOX;
        private System.Windows.Forms.TextBox usuarioBOX;
        private System.Windows.Forms.Label tipoLBL;
        private System.Windows.Forms.Label contraLBL;
        private System.Windows.Forms.Label usuarioLBL;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buscarIdBTN;
        private System.Windows.Forms.TextBox idRepartidorBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}