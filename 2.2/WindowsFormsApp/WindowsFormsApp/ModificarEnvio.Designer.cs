namespace WindowsFormsApp
{
    partial class ModificarEnvio
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
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.idPaqueteBOX = new System.Windows.Forms.TextBox();
            this.buscarPaqueteBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idClienteLBL = new System.Windows.Forms.Label();
            this.idRepartidorLBL = new System.Windows.Forms.Label();
            this.idProveedorLBL = new System.Windows.Forms.Label();
            this.fechaEnvioLBL = new System.Windows.Forms.Label();
            this.descripcionLBL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.movilLBL = new System.Windows.Forms.Label();
            this.costoLBL = new System.Windows.Forms.Label();
            this.descripcionBOX = new System.Windows.Forms.TextBox();
            this.idRepartidorBOX = new System.Windows.Forms.TextBox();
            this.idClienteBOX = new System.Windows.Forms.TextBox();
            this.costoBOX = new System.Windows.Forms.TextBox();
            this.movilBOX = new System.Windows.Forms.TextBox();
            this.idProveedorBOX = new System.Windows.Forms.TextBox();
            this.modificarEnvioBOX = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lugarSalidaLBL = new System.Windows.Forms.Label();
            this.lugarDestinoLBL = new System.Windows.Forms.Label();
            this.lugarSalidaBOX = new System.Windows.Forms.TextBox();
            this.lugarDestinoBOX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fechaDestinoLBL = new System.Windows.Forms.Label();
            this.idProductosLBL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fechEnvioDTP = new System.Windows.Forms.DateTimePicker();
            this.Entregado = new System.Windows.Forms.Label();
            this.entregadoLBL = new System.Windows.Forms.Label();
            this.entregadoCBX = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.paquetesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // paquetesDGV
            // 
            this.paquetesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paquetesDGV.Location = new System.Drawing.Point(426, 26);
            this.paquetesDGV.Name = "paquetesDGV";
            this.paquetesDGV.Size = new System.Drawing.Size(372, 392);
            this.paquetesDGV.TabIndex = 0;
            this.paquetesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Paquete";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(33, 48);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // idPaqueteBOX
            // 
            this.idPaqueteBOX.Location = new System.Drawing.Point(57, 41);
            this.idPaqueteBOX.Name = "idPaqueteBOX";
            this.idPaqueteBOX.Size = new System.Drawing.Size(100, 20);
            this.idPaqueteBOX.TabIndex = 3;
            this.idPaqueteBOX.TextChanged += new System.EventHandler(this.idPaqueteBOX_TextChanged);
            // 
            // buscarPaqueteBTN
            // 
            this.buscarPaqueteBTN.Location = new System.Drawing.Point(42, 79);
            this.buscarPaqueteBTN.Name = "buscarPaqueteBTN";
            this.buscarPaqueteBTN.Size = new System.Drawing.Size(100, 23);
            this.buscarPaqueteBTN.TabIndex = 4;
            this.buscarPaqueteBTN.Text = "Buscar Paquete";
            this.buscarPaqueteBTN.UseVisualStyleBackColor = true;
            this.buscarPaqueteBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "id cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "id repartidor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "id proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "fecha envio";
            // 
            // idClienteLBL
            // 
            this.idClienteLBL.AutoSize = true;
            this.idClienteLBL.Location = new System.Drawing.Point(110, 141);
            this.idClienteLBL.Name = "idClienteLBL";
            this.idClienteLBL.Size = new System.Drawing.Size(10, 13);
            this.idClienteLBL.TabIndex = 11;
            this.idClienteLBL.Text = "-";
            this.idClienteLBL.Click += new System.EventHandler(this.idClienteLBL_Click);
            // 
            // idRepartidorLBL
            // 
            this.idRepartidorLBL.AutoSize = true;
            this.idRepartidorLBL.Location = new System.Drawing.Point(110, 169);
            this.idRepartidorLBL.Name = "idRepartidorLBL";
            this.idRepartidorLBL.Size = new System.Drawing.Size(10, 13);
            this.idRepartidorLBL.TabIndex = 12;
            this.idRepartidorLBL.Text = "-";
            // 
            // idProveedorLBL
            // 
            this.idProveedorLBL.AutoSize = true;
            this.idProveedorLBL.Location = new System.Drawing.Point(110, 199);
            this.idProveedorLBL.Name = "idProveedorLBL";
            this.idProveedorLBL.Size = new System.Drawing.Size(10, 13);
            this.idProveedorLBL.TabIndex = 13;
            this.idProveedorLBL.Text = "-";
            // 
            // fechaEnvioLBL
            // 
            this.fechaEnvioLBL.AutoSize = true;
            this.fechaEnvioLBL.Location = new System.Drawing.Point(79, 232);
            this.fechaEnvioLBL.Name = "fechaEnvioLBL";
            this.fechaEnvioLBL.Size = new System.Drawing.Size(10, 13);
            this.fechaEnvioLBL.TabIndex = 14;
            this.fechaEnvioLBL.Text = "-";
            // 
            // descripcionLBL
            // 
            this.descripcionLBL.AutoSize = true;
            this.descripcionLBL.Location = new System.Drawing.Point(110, 113);
            this.descripcionLBL.Name = "descripcionLBL";
            this.descripcionLBL.Size = new System.Drawing.Size(10, 13);
            this.descripcionLBL.TabIndex = 16;
            this.descripcionLBL.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "movil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "costo";
            // 
            // movilLBL
            // 
            this.movilLBL.AutoSize = true;
            this.movilLBL.Location = new System.Drawing.Point(110, 283);
            this.movilLBL.Name = "movilLBL";
            this.movilLBL.Size = new System.Drawing.Size(10, 13);
            this.movilLBL.TabIndex = 20;
            this.movilLBL.Text = "-";
            // 
            // costoLBL
            // 
            this.costoLBL.AutoSize = true;
            this.costoLBL.Location = new System.Drawing.Point(110, 309);
            this.costoLBL.Name = "costoLBL";
            this.costoLBL.Size = new System.Drawing.Size(10, 13);
            this.costoLBL.TabIndex = 21;
            this.costoLBL.Text = "-";
            // 
            // descripcionBOX
            // 
            this.descripcionBOX.Location = new System.Drawing.Point(170, 110);
            this.descripcionBOX.Name = "descripcionBOX";
            this.descripcionBOX.Size = new System.Drawing.Size(100, 20);
            this.descripcionBOX.TabIndex = 24;
            // 
            // idRepartidorBOX
            // 
            this.idRepartidorBOX.Location = new System.Drawing.Point(170, 166);
            this.idRepartidorBOX.Name = "idRepartidorBOX";
            this.idRepartidorBOX.Size = new System.Drawing.Size(100, 20);
            this.idRepartidorBOX.TabIndex = 25;
            // 
            // idClienteBOX
            // 
            this.idClienteBOX.Location = new System.Drawing.Point(170, 138);
            this.idClienteBOX.Name = "idClienteBOX";
            this.idClienteBOX.Size = new System.Drawing.Size(100, 20);
            this.idClienteBOX.TabIndex = 26;
            // 
            // costoBOX
            // 
            this.costoBOX.Location = new System.Drawing.Point(170, 306);
            this.costoBOX.Name = "costoBOX";
            this.costoBOX.Size = new System.Drawing.Size(100, 20);
            this.costoBOX.TabIndex = 28;
            // 
            // movilBOX
            // 
            this.movilBOX.Location = new System.Drawing.Point(170, 280);
            this.movilBOX.Name = "movilBOX";
            this.movilBOX.Size = new System.Drawing.Size(100, 20);
            this.movilBOX.TabIndex = 29;
            // 
            // idProveedorBOX
            // 
            this.idProveedorBOX.Location = new System.Drawing.Point(170, 192);
            this.idProveedorBOX.Name = "idProveedorBOX";
            this.idProveedorBOX.Size = new System.Drawing.Size(100, 20);
            this.idProveedorBOX.TabIndex = 32;
            // 
            // modificarEnvioBOX
            // 
            this.modificarEnvioBOX.Location = new System.Drawing.Point(18, 432);
            this.modificarEnvioBOX.Name = "modificarEnvioBOX";
            this.modificarEnvioBOX.Size = new System.Drawing.Size(124, 23);
            this.modificarEnvioBOX.TabIndex = 33;
            this.modificarEnvioBOX.Text = "modificar envio";
            this.modificarEnvioBOX.UseVisualStyleBackColor = true;
            this.modificarEnvioBOX.Click += new System.EventHandler(this.modificarEnvioBOX_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "lugar salida";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 381);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "lugar destino";
            // 
            // lugarSalidaLBL
            // 
            this.lugarSalidaLBL.AutoSize = true;
            this.lugarSalidaLBL.Location = new System.Drawing.Point(110, 357);
            this.lugarSalidaLBL.Name = "lugarSalidaLBL";
            this.lugarSalidaLBL.Size = new System.Drawing.Size(10, 13);
            this.lugarSalidaLBL.TabIndex = 37;
            this.lugarSalidaLBL.Text = "-";
            // 
            // lugarDestinoLBL
            // 
            this.lugarDestinoLBL.AutoSize = true;
            this.lugarDestinoLBL.Location = new System.Drawing.Point(110, 381);
            this.lugarDestinoLBL.Name = "lugarDestinoLBL";
            this.lugarDestinoLBL.Size = new System.Drawing.Size(10, 13);
            this.lugarDestinoLBL.TabIndex = 38;
            this.lugarDestinoLBL.Text = "-";
            // 
            // lugarSalidaBOX
            // 
            this.lugarSalidaBOX.Location = new System.Drawing.Point(170, 354);
            this.lugarSalidaBOX.Name = "lugarSalidaBOX";
            this.lugarSalidaBOX.Size = new System.Drawing.Size(100, 20);
            this.lugarSalidaBOX.TabIndex = 39;
            this.lugarSalidaBOX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lugarDestinoBOX
            // 
            this.lugarDestinoBOX.Location = new System.Drawing.Point(170, 378);
            this.lugarDestinoBOX.Name = "lugarDestinoBOX";
            this.lugarDestinoBOX.Size = new System.Drawing.Size(100, 20);
            this.lugarDestinoBOX.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "fecha envio";
            // 
            // fechaDestinoLBL
            // 
            this.fechaDestinoLBL.AutoSize = true;
            this.fechaDestinoLBL.Location = new System.Drawing.Point(110, 258);
            this.fechaDestinoLBL.Name = "fechaDestinoLBL";
            this.fechaDestinoLBL.Size = new System.Drawing.Size(10, 13);
            this.fechaDestinoLBL.TabIndex = 42;
            this.fechaDestinoLBL.Text = "-";
            // 
            // idProductosLBL
            // 
            this.idProductosLBL.AutoSize = true;
            this.idProductosLBL.Location = new System.Drawing.Point(110, 332);
            this.idProductosLBL.Name = "idProductosLBL";
            this.idProductosLBL.Size = new System.Drawing.Size(10, 13);
            this.idProductosLBL.TabIndex = 43;
            this.idProductosLBL.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "id productos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Eliminar Envio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fechEnvioDTP
            // 
            this.fechEnvioDTP.Location = new System.Drawing.Point(170, 226);
            this.fechEnvioDTP.Name = "fechEnvioDTP";
            this.fechEnvioDTP.Size = new System.Drawing.Size(200, 20);
            this.fechEnvioDTP.TabIndex = 46;
            // 
            // Entregado
            // 
            this.Entregado.AutoSize = true;
            this.Entregado.Location = new System.Drawing.Point(12, 405);
            this.Entregado.Name = "Entregado";
            this.Entregado.Size = new System.Drawing.Size(56, 13);
            this.Entregado.TabIndex = 47;
            this.Entregado.Text = "Entregado";
            // 
            // entregadoLBL
            // 
            this.entregadoLBL.AutoSize = true;
            this.entregadoLBL.Location = new System.Drawing.Point(110, 405);
            this.entregadoLBL.Name = "entregadoLBL";
            this.entregadoLBL.Size = new System.Drawing.Size(10, 13);
            this.entregadoLBL.TabIndex = 48;
            this.entregadoLBL.Text = "-";
            this.entregadoLBL.Click += new System.EventHandler(this.entregadoLBL_Click);
            // 
            // entregadoCBX
            // 
            this.entregadoCBX.AutoSize = true;
            this.entregadoCBX.Location = new System.Drawing.Point(170, 404);
            this.entregadoCBX.Name = "entregadoCBX";
            this.entregadoCBX.Size = new System.Drawing.Size(105, 17);
            this.entregadoCBX.TabIndex = 49;
            this.entregadoCBX.Text = "Envio Entregado";
            this.entregadoCBX.UseVisualStyleBackColor = true;
            // 
            // ModificarEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.entregadoCBX);
            this.Controls.Add(this.entregadoLBL);
            this.Controls.Add(this.Entregado);
            this.Controls.Add(this.fechEnvioDTP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.idProductosLBL);
            this.Controls.Add(this.fechaDestinoLBL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lugarDestinoBOX);
            this.Controls.Add(this.lugarSalidaBOX);
            this.Controls.Add(this.lugarDestinoLBL);
            this.Controls.Add(this.lugarSalidaLBL);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.modificarEnvioBOX);
            this.Controls.Add(this.idProveedorBOX);
            this.Controls.Add(this.movilBOX);
            this.Controls.Add(this.costoBOX);
            this.Controls.Add(this.idClienteBOX);
            this.Controls.Add(this.idRepartidorBOX);
            this.Controls.Add(this.descripcionBOX);
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
            this.Controls.Add(this.paquetesDGV);
            this.Name = "ModificarEnvio";
            this.Text = "ModificarEnvio";
            this.Load += new System.EventHandler(this.ModificarEnvio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paquetesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView paquetesDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox idPaqueteBOX;
        private System.Windows.Forms.Button buscarPaqueteBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label idClienteLBL;
        private System.Windows.Forms.Label idRepartidorLBL;
        private System.Windows.Forms.Label idProveedorLBL;
        private System.Windows.Forms.Label fechaEnvioLBL;
        private System.Windows.Forms.Label descripcionLBL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label movilLBL;
        private System.Windows.Forms.Label costoLBL;
        private System.Windows.Forms.TextBox descripcionBOX;
        private System.Windows.Forms.TextBox idRepartidorBOX;
        private System.Windows.Forms.TextBox idClienteBOX;
        private System.Windows.Forms.TextBox costoBOX;
        private System.Windows.Forms.TextBox movilBOX;
        private System.Windows.Forms.TextBox idProveedorBOX;
        private System.Windows.Forms.Button modificarEnvioBOX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lugarSalidaLBL;
        private System.Windows.Forms.Label lugarDestinoLBL;
        private System.Windows.Forms.TextBox lugarSalidaBOX;
        private System.Windows.Forms.TextBox lugarDestinoBOX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label fechaDestinoLBL;
        private System.Windows.Forms.Label idProductosLBL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fechEnvioDTP;
        private System.Windows.Forms.Label Entregado;
        private System.Windows.Forms.Label entregadoLBL;
        private System.Windows.Forms.CheckBox entregadoCBX;
    }
}