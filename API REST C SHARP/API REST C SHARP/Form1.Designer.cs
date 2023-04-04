namespace API_REST_C_SHARP
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTNbuscar = new System.Windows.Forms.Button();
            this.BTNaceptar = new System.Windows.Forms.Button();
            this.TXTbuscar = new System.Windows.Forms.TextBox();
            this.DGVlista = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.body = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVlista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "API REST JSON PLACE HOLDER";
            // 
            // BTNbuscar
            // 
            this.BTNbuscar.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTNbuscar.Location = new System.Drawing.Point(595, 4);
            this.BTNbuscar.Name = "BTNbuscar";
            this.BTNbuscar.Size = new System.Drawing.Size(75, 29);
            this.BTNbuscar.TabIndex = 8;
            this.BTNbuscar.Text = "BUSCAR";
            this.BTNbuscar.UseVisualStyleBackColor = true;
            this.BTNbuscar.Click += new System.EventHandler(this.BTNbuscar_Click);
            // 
            // BTNaceptar
            // 
            this.BTNaceptar.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTNaceptar.Location = new System.Drawing.Point(596, 427);
            this.BTNaceptar.Name = "BTNaceptar";
            this.BTNaceptar.Size = new System.Drawing.Size(74, 31);
            this.BTNaceptar.TabIndex = 7;
            this.BTNaceptar.Text = "LISTAR";
            this.BTNaceptar.UseVisualStyleBackColor = true;
            this.BTNaceptar.Click += new System.EventHandler(this.BTNaceptar_Click);
            // 
            // TXTbuscar
            // 
            this.TXTbuscar.BackColor = System.Drawing.SystemColors.Window;
            this.TXTbuscar.Location = new System.Drawing.Point(317, 10);
            this.TXTbuscar.Name = "TXTbuscar";
            this.TXTbuscar.Size = new System.Drawing.Size(260, 20);
            this.TXTbuscar.TabIndex = 6;
            // 
            // DGVlista
            // 
            this.DGVlista.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.DGVlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVlista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.Id,
            this.title,
            this.body});
            this.DGVlista.Location = new System.Drawing.Point(12, 45);
            this.DGVlista.Name = "DGVlista";
            this.DGVlista.Size = new System.Drawing.Size(658, 376);
            this.DGVlista.TabIndex = 5;
            // 
            // userId
            // 
            this.userId.DataPropertyName = "userId";
            this.userId.HeaderText = "Usuario";
            this.userId.Name = "userId";
            this.userId.Width = 80;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Identificador";
            this.Id.Name = "Id";
            this.Id.Width = 80;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Titulo";
            this.title.Name = "title";
            this.title.Width = 200;
            // 
            // body
            // 
            this.body.DataPropertyName = "body";
            this.body.HeaderText = "Contenido";
            this.body.Name = "body";
            this.body.Width = 255;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(693, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNbuscar);
            this.Controls.Add(this.BTNaceptar);
            this.Controls.Add(this.TXTbuscar);
            this.Controls.Add(this.DGVlista);
            this.Name = "Form1";
            this.Text = "API REST";
            ((System.ComponentModel.ISupportInitialize)(this.DGVlista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNbuscar;
        private System.Windows.Forms.Button BTNaceptar;
        private System.Windows.Forms.TextBox TXTbuscar;
        private System.Windows.Forms.DataGridView DGVlista;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn body;
    }
}

