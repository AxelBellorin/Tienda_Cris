namespace TRCAplicacion.GUI.MenuOperaciones
{
    partial class SubmenuPedidoCliente
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
            this.dgvPedidoCliente = new System.Windows.Forms.DataGridView();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregarProductoLista = new System.Windows.Forms.Button();
            this.btnGuardarEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbLlenadoEdicion = new System.Windows.Forms.GroupBox();
            this.nuCantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.mtbCedula = new System.Windows.Forms.MaskedTextBox();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoPedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPuntoReunion = new System.Windows.Forms.ComboBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoCliente)).BeginInit();
            this.gbLlenadoEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidadProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidoCliente
            // 
            this.dgvPedidoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPedidoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProducto,
            this.cantidad});
            this.dgvPedidoCliente.Location = new System.Drawing.Point(451, 140);
            this.dgvPedidoCliente.MultiSelect = false;
            this.dgvPedidoCliente.Name = "dgvPedidoCliente";
            this.dgvPedidoCliente.ReadOnly = true;
            this.dgvPedidoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidoCliente.Size = new System.Drawing.Size(243, 166);
            this.dgvPedidoCliente.TabIndex = 54;
            // 
            // codigoProducto
            // 
            this.codigoProducto.HeaderText = "Codigo del producto";
            this.codigoProducto.Name = "codigoProducto";
            this.codigoProducto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(704, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 30);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.Location = new System.Drawing.Point(542, 312);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(152, 19);
            this.lblCantidad.TabIndex = 47;
            this.lblCantidad.Text = "Hay 0 Productos";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAgregarProductoLista
            // 
            this.btnAgregarProductoLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarProductoLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductoLista.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnAgregarProductoLista.Location = new System.Drawing.Point(451, 97);
            this.btnAgregarProductoLista.Name = "btnAgregarProductoLista";
            this.btnAgregarProductoLista.Size = new System.Drawing.Size(76, 30);
            this.btnAgregarProductoLista.TabIndex = 51;
            this.btnAgregarProductoLista.Text = "Agregar";
            this.btnAgregarProductoLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProductoLista.UseVisualStyleBackColor = true;
            this.btnAgregarProductoLista.Click += new System.EventHandler(this.btnAgregarProductoLista_Click);
            // 
            // btnGuardarEditar
            // 
            this.btnGuardarEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEditar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnGuardarEditar.Image = global::TRCAplicacion.Properties.Resources.save_item___1411_;
            this.btnGuardarEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarEditar.Location = new System.Drawing.Point(704, 140);
            this.btnGuardarEditar.Name = "btnGuardarEditar";
            this.btnGuardarEditar.Size = new System.Drawing.Size(118, 30);
            this.btnGuardarEditar.TabIndex = 52;
            this.btnGuardarEditar.Text = "Guardar";
            this.btnGuardarEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEditar.UseVisualStyleBackColor = true;
            this.btnGuardarEditar.Click += new System.EventHandler(this.btnGuardarEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnNuevo.Image = global::TRCAplicacion.Properties.Resources.profile_plus_round___1324_;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(91, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 60);
            this.btnNuevo.TabIndex = 53;
            this.btnNuevo.Text = "Nuevo\r\nPedido";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbLlenadoEdicion
            // 
            this.gbLlenadoEdicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbLlenadoEdicion.Controls.Add(this.dtpFechaEntrega);
            this.gbLlenadoEdicion.Controls.Add(this.nuCantidadProducto);
            this.gbLlenadoEdicion.Controls.Add(this.mtbCedula);
            this.gbLlenadoEdicion.Controls.Add(this.cbPuntoReunion);
            this.gbLlenadoEdicion.Controls.Add(this.cbTipoPago);
            this.gbLlenadoEdicion.Controls.Add(this.txtCodigoProducto);
            this.gbLlenadoEdicion.Controls.Add(this.txtCodigoPedido);
            this.gbLlenadoEdicion.Controls.Add(this.label4);
            this.gbLlenadoEdicion.Controls.Add(this.label1);
            this.gbLlenadoEdicion.Controls.Add(this.label9);
            this.gbLlenadoEdicion.Controls.Add(this.label2);
            this.gbLlenadoEdicion.Controls.Add(this.label10);
            this.gbLlenadoEdicion.Controls.Add(this.label7);
            this.gbLlenadoEdicion.Controls.Add(this.label6);
            this.gbLlenadoEdicion.Controls.Add(this.label5);
            this.gbLlenadoEdicion.Font = new System.Drawing.Font("Corbel", 10F);
            this.gbLlenadoEdicion.Location = new System.Drawing.Point(92, 97);
            this.gbLlenadoEdicion.Name = "gbLlenadoEdicion";
            this.gbLlenadoEdicion.Size = new System.Drawing.Size(353, 267);
            this.gbLlenadoEdicion.TabIndex = 49;
            this.gbLlenadoEdicion.TabStop = false;
            this.gbLlenadoEdicion.Text = "Llenado y edicion";
            // 
            // nuCantidadProducto
            // 
            this.nuCantidadProducto.Font = new System.Drawing.Font("Corbel", 10F);
            this.nuCantidadProducto.Location = new System.Drawing.Point(133, 224);
            this.nuCantidadProducto.Name = "nuCantidadProducto";
            this.nuCantidadProducto.Size = new System.Drawing.Size(64, 24);
            this.nuCantidadProducto.TabIndex = 47;
            this.nuCantidadProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbCedula
            // 
            this.mtbCedula.Font = new System.Drawing.Font("Corbel", 10F);
            this.mtbCedula.Location = new System.Drawing.Point(133, 85);
            this.mtbCedula.Mask = "000-000000-0000?";
            this.mtbCedula.Name = "mtbCedula";
            this.mtbCedula.Size = new System.Drawing.Size(200, 24);
            this.mtbCedula.TabIndex = 7;
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoPago.Font = new System.Drawing.Font("Corbel", 10F);
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Location = new System.Drawing.Point(133, 145);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(200, 23);
            this.cbTipoPago.TabIndex = 6;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Font = new System.Drawing.Font("Corbel", 10F);
            this.txtCodigoProducto.Location = new System.Drawing.Point(133, 194);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(200, 24);
            this.txtCodigoProducto.TabIndex = 3;
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Font = new System.Drawing.Font("Corbel", 10F);
            this.txtCodigoPedido.Location = new System.Drawing.Point(133, 26);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(200, 24);
            this.txtCodigoPedido.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 10F);
            this.label4.Location = new System.Drawing.Point(130, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seleccionar producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 10F);
            this.label1.Location = new System.Drawing.Point(1, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 10F);
            this.label9.Location = new System.Drawing.Point(42, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo de pago:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 10F);
            this.label10.Location = new System.Drawing.Point(63, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 10F);
            this.label7.Location = new System.Drawing.Point(9, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha entrega:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 10F);
            this.label6.Location = new System.Drawing.Point(17, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cedula del cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 10F);
            this.label5.Location = new System.Drawing.Point(8, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo del pedido:";
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(225, 10);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(593, 63);
            this.lblCliente.TabIndex = 48;
            this.lblCliente.Text = "Pedido del Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 10F);
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Punto de reunion:";
            // 
            // cbPuntoReunion
            // 
            this.cbPuntoReunion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPuntoReunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPuntoReunion.Font = new System.Drawing.Font("Corbel", 10F);
            this.cbPuntoReunion.FormattingEnabled = true;
            this.cbPuntoReunion.Location = new System.Drawing.Point(133, 121);
            this.cbPuntoReunion.Name = "cbPuntoReunion";
            this.cbPuntoReunion.Size = new System.Drawing.Size(200, 23);
            this.cbPuntoReunion.TabIndex = 6;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(133, 56);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaEntrega.TabIndex = 48;
            // 
            // SubmenuPedidoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.dgvPedidoCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnAgregarProductoLista);
            this.Controls.Add(this.btnGuardarEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbLlenadoEdicion);
            this.Controls.Add(this.lblCliente);
            this.Name = "SubmenuPedidoCliente";
            this.Text = "SubmenuPedidoCliente";
            this.Load += new System.EventHandler(this.SubmenuPedidoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoCliente)).EndInit();
            this.gbLlenadoEdicion.ResumeLayout(false);
            this.gbLlenadoEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidadProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregarProductoLista;
        private System.Windows.Forms.Button btnGuardarEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbLlenadoEdicion;
        private System.Windows.Forms.NumericUpDown nuCantidadProducto;
        private System.Windows.Forms.MaskedTextBox mtbCedula;
        private System.Windows.Forms.ComboBox cbTipoPago;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtCodigoPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.ComboBox cbPuntoReunion;
        private System.Windows.Forms.Label label2;
    }
}