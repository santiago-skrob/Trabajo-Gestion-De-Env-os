namespace WindowsFormsApp
{
    partial class EntregarEnvio
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
            this.buscarPaqueteBTN = new System.Windows.Forms.Button();
            this.idPaqueteBOX = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.idProductosLBL = new System.Windows.Forms.Label();
            this.fechaDestinoLBL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lugarDestinoLBL = new System.Windows.Forms.Label();
            this.lugarSalidaLBL = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.costoLBL = new System.Windows.Forms.Label();
            this.movilLBL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.descripcionLBL = new System.Windows.Forms.Label();
            this.fechaEnvioLBL = new System.Windows.Forms.Label();
            this.idProveedorLBL = new System.Windows.Forms.Label();
            this.idRepartidorLBL = new System.Windows.Forms.Label();
            this.idClienteLBL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paquetesDGV = new System.Windows.Forms.DataGridView();
            this.entregadoCBX = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.entregadoLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paquetesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarPaqueteBTN
            // 
            this.buscarPaqueteBTN.Location = new System.Drawing.Point(41, 74);
            this.buscarPaqueteBTN.Name = "buscarPaqueteBTN";
            this.buscarPaqueteBTN.Size = new System.Drawing.Size(100, 23);
            this.buscarPaqueteBTN.TabIndex = 8;
            this.buscarPaqueteBTN.Text = "Buscar Paquete";
            this.buscarPaqueteBTN.UseVisualStyleBackColor = true;
            this.buscarPaqueteBTN.Click += new System.EventHandler(this.buscarPaqueteBTN_Click);
            // 
            // idPaqueteBOX
            // 
            this.idPaqueteBOX.Location = new System.Drawing.Point(56, 36);
            this.idPaqueteBOX.Name = "idPaqueteBOX";
            this.idPaqueteBOX.Size = new System.Drawing.Size(100, 20);
            this.idPaqueteBOX.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(32, 43);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 6;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Paquete";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "id productos";
            // 
            // idProductosLBL
            // 
            this.idProductosLBL.AutoSize = true;
            this.idProductosLBL.Location = new System.Drawing.Point(112, 328);
            this.idProductosLBL.Name = "idProductosLBL";
            this.idProductosLBL.Size = new System.Drawing.Size(10, 13);
            this.idProductosLBL.TabIndex = 65;
            this.idProductosLBL.Text = "-";
            // 
            // fechaDestinoLBL
            // 
            this.fechaDestinoLBL.AutoSize = true;
            this.fechaDestinoLBL.Location = new System.Drawing.Point(112, 254);
            this.fechaDestinoLBL.Name = "fechaDestinoLBL";
            this.fechaDestinoLBL.Size = new System.Drawing.Size(10, 13);
            this.fechaDestinoLBL.TabIndex = 64;
            this.fechaDestinoLBL.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "fecha envio";
            // 
            // lugarDestinoLBL
            // 
            this.lugarDestinoLBL.AutoSize = true;
            this.lugarDestinoLBL.Location = new System.Drawing.Point(112, 377);
            this.lugarDestinoLBL.Name = "lugarDestinoLBL";
            this.lugarDestinoLBL.Size = new System.Drawing.Size(10, 13);
            this.lugarDestinoLBL.TabIndex = 62;
            this.lugarDestinoLBL.Text = "-";
            // 
            // lugarSalidaLBL
            // 
            this.lugarSalidaLBL.AutoSize = true;
            this.lugarSalidaLBL.Location = new System.Drawing.Point(112, 353);
            this.lugarSalidaLBL.Name = "lugarSalidaLBL";
            this.lugarSalidaLBL.Size = new System.Drawing.Size(10, 13);
            this.lugarSalidaLBL.TabIndex = 61;
            this.lugarSalidaLBL.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "lugar destino";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "lugar salida";
            // 
            // costoLBL
            // 
            this.costoLBL.AutoSize = true;
            this.costoLBL.Location = new System.Drawing.Point(112, 305);
            this.costoLBL.Name = "costoLBL";
            this.costoLBL.Size = new System.Drawing.Size(10, 13);
            this.costoLBL.TabIndex = 58;
            this.costoLBL.Text = "-";
            // 
            // movilLBL
            // 
            this.movilLBL.AutoSize = true;
            this.movilLBL.Location = new System.Drawing.Point(112, 279);
            this.movilLBL.Name = "movilLBL";
            this.movilLBL.Size = new System.Drawing.Size(10, 13);
            this.movilLBL.TabIndex = 57;
            this.movilLBL.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "costo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "movil";
            // 
            // descripcionLBL
            // 
            this.descripcionLBL.AutoSize = true;
            this.descripcionLBL.Location = new System.Drawing.Point(112, 109);
            this.descripcionLBL.Name = "descripcionLBL";
            this.descripcionLBL.Size = new System.Drawing.Size(10, 13);
            this.descripcionLBL.TabIndex = 54;
            this.descripcionLBL.Text = "-";
            // 
            // fechaEnvioLBL
            // 
            this.fechaEnvioLBL.AutoSize = true;
            this.fechaEnvioLBL.Location = new System.Drawing.Point(112, 234);
            this.fechaEnvioLBL.Name = "fechaEnvioLBL";
            this.fechaEnvioLBL.Size = new System.Drawing.Size(10, 13);
            this.fechaEnvioLBL.TabIndex = 53;
            this.fechaEnvioLBL.Text = "-";
            // 
            // idProveedorLBL
            // 
            this.idProveedorLBL.AutoSize = true;
            this.idProveedorLBL.Location = new System.Drawing.Point(112, 195);
            this.idProveedorLBL.Name = "idProveedorLBL";
            this.idProveedorLBL.Size = new System.Drawing.Size(10, 13);
            this.idProveedorLBL.TabIndex = 52;
            this.idProveedorLBL.Text = "-";
            // 
            // idRepartidorLBL
            // 
            this.idRepartidorLBL.AutoSize = true;
            this.idRepartidorLBL.Location = new System.Drawing.Point(112, 165);
            this.idRepartidorLBL.Name = "idRepartidorLBL";
            this.idRepartidorLBL.Size = new System.Drawing.Size(10, 13);
            this.idRepartidorLBL.TabIndex = 51;
            this.idRepartidorLBL.Text = "-";
            // 
            // idClienteLBL
            // 
            this.idClienteLBL.AutoSize = true;
            this.idClienteLBL.Location = new System.Drawing.Point(112, 137);
            this.idClienteLBL.Name = "idClienteLBL";
            this.idClienteLBL.Size = new System.Drawing.Size(10, 13);
            this.idClienteLBL.TabIndex = 50;
            this.idClienteLBL.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "fecha envio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "id proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "id repartidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "id cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Descripcion";
            // 
            // paquetesDGV
            // 
            this.paquetesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paquetesDGV.Location = new System.Drawing.Point(406, 26);
            this.paquetesDGV.Name = "paquetesDGV";
            this.paquetesDGV.Size = new System.Drawing.Size(372, 392);
            this.paquetesDGV.TabIndex = 67;
            // 
            // entregadoCBX
            // 
            this.entregadoCBX.AutoSize = true;
            this.entregadoCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entregadoCBX.Location = new System.Drawing.Point(234, 367);
            this.entregadoCBX.Name = "entregadoCBX";
            this.entregadoCBX.Size = new System.Drawing.Size(136, 22);
            this.entregadoCBX.TabIndex = 68;
            this.entregadoCBX.Text = "Envio Entregado";
            this.entregadoCBX.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 69;
            this.button1.Text = "Confirmar Entrega Del Envio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "Entregado";
            // 
            // entregadoLBL
            // 
            this.entregadoLBL.AutoSize = true;
            this.entregadoLBL.Location = new System.Drawing.Point(112, 405);
            this.entregadoLBL.Name = "entregadoLBL";
            this.entregadoLBL.Size = new System.Drawing.Size(10, 13);
            this.entregadoLBL.TabIndex = 71;
            this.entregadoLBL.Text = "-";
            // 
            // EntregarEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.entregadoLBL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.entregadoCBX);
            this.Controls.Add(this.paquetesDGV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.idProductosLBL);
            this.Controls.Add(this.fechaDestinoLBL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lugarDestinoLBL);
            this.Controls.Add(this.lugarSalidaLBL);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.costoLBL);
            this.Controls.Add(this.movilLBL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.descripcionLBL);
            this.Controls.Add(this.fechaEnvioLBL);
            this.Controls.Add(this.idProveedorLBL);
            this.Controls.Add(this.idRepartidorLBL);
            this.Controls.Add(this.idClienteLBL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscarPaqueteBTN);
            this.Controls.Add(this.idPaqueteBOX);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Name = "EntregarEnvio";
            this.Text = "EntregarEnvio";
            this.Load += new System.EventHandler(this.EntregarEnvio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paquetesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarPaqueteBTN;
        private System.Windows.Forms.TextBox idPaqueteBOX;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label idProductosLBL;
        private System.Windows.Forms.Label fechaDestinoLBL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lugarDestinoLBL;
        private System.Windows.Forms.Label lugarSalidaLBL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label costoLBL;
        private System.Windows.Forms.Label movilLBL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label descripcionLBL;
        private System.Windows.Forms.Label fechaEnvioLBL;
        private System.Windows.Forms.Label idProveedorLBL;
        private System.Windows.Forms.Label idRepartidorLBL;
        private System.Windows.Forms.Label idClienteLBL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView paquetesDGV;
        private System.Windows.Forms.CheckBox entregadoCBX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label entregadoLBL;
    }
}