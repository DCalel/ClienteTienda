namespace ClienteTienda
{
    partial class FormGameStore
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
            this.btnTienda = new System.Windows.Forms.Button();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbPrincipal = new System.Windows.Forms.TabPage();
            this.tbGameStore = new System.Windows.Forms.TabPage();
            this.lbCompra = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbProducto = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcPrincipal.SuspendLayout();
            this.tbPrincipal.SuspendLayout();
            this.tbGameStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTienda
            // 
            this.btnTienda.Location = new System.Drawing.Point(327, 296);
            this.btnTienda.Name = "btnTienda";
            this.btnTienda.Size = new System.Drawing.Size(115, 23);
            this.btnTienda.TabIndex = 0;
            this.btnTienda.Text = "Abrir Tienda";
            this.btnTienda.UseVisualStyleBackColor = true;
            this.btnTienda.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tbcPrincipal.Controls.Add(this.tbPrincipal);
            this.tbcPrincipal.Controls.Add(this.tbGameStore);
            this.tbcPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(776, 459);
            this.tbcPrincipal.TabIndex = 1;
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Controls.Add(this.btnTienda);
            this.tbPrincipal.Location = new System.Drawing.Point(4, 4);
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tbPrincipal.Size = new System.Drawing.Size(768, 397);
            this.tbPrincipal.TabIndex = 0;
            this.tbPrincipal.Text = "Principal";
            this.tbPrincipal.UseVisualStyleBackColor = true;
            // 
            // tbGameStore
            // 
            this.tbGameStore.Controls.Add(this.label1);
            this.tbGameStore.Controls.Add(this.lbCompra);
            this.tbGameStore.Controls.Add(this.lbPrecio);
            this.tbGameStore.Controls.Add(this.lbProducto);
            this.tbGameStore.Controls.Add(this.btnComprar);
            this.tbGameStore.Controls.Add(this.btnRetroceder);
            this.tbGameStore.Controls.Add(this.btnAvanzar);
            this.tbGameStore.Location = new System.Drawing.Point(4, 4);
            this.tbGameStore.Name = "tbGameStore";
            this.tbGameStore.Padding = new System.Windows.Forms.Padding(3);
            this.tbGameStore.Size = new System.Drawing.Size(768, 430);
            this.tbGameStore.TabIndex = 1;
            this.tbGameStore.Text = "GameStore";
            this.tbGameStore.UseVisualStyleBackColor = true;
            // 
            // lbCompra
            // 
            this.lbCompra.AutoSize = true;
            this.lbCompra.Location = new System.Drawing.Point(325, 3);
            this.lbCompra.Name = "lbCompra";
            this.lbCompra.Size = new System.Drawing.Size(90, 16);
            this.lbCompra.TabIndex = 5;
            this.lbCompra.Text = "No comprado";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(345, 109);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(46, 16);
            this.lbPrecio.TabIndex = 4;
            this.lbPrecio.Text = "Precio";
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Location = new System.Drawing.Point(325, 74);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(56, 16);
            this.lbProducto.TabIndex = 3;
            this.lbProducto.Text = "Nombre";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(336, 335);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(29, 335);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(93, 23);
            this.btnRetroceder.TabIndex = 1;
            this.btnRetroceder.Text = "Retroceder";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(644, 335);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(75, 23);
            this.btnAvanzar.TabIndex = 0;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.BtnAvanzar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "$";
            // 
            // FormGameStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcPrincipal);
            this.Name = "FormGameStore";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcPrincipal.ResumeLayout(false);
            this.tbPrincipal.ResumeLayout(false);
            this.tbGameStore.ResumeLayout(false);
            this.tbGameStore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTienda;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbPrincipal;
        private System.Windows.Forms.TabPage tbGameStore;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbCompra;
        private System.Windows.Forms.Label label1;
    }
}

