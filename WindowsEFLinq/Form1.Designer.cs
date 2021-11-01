
namespace WindowsEFLinq
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
            this.btnTraerTodosAutores = new System.Windows.Forms.Button();
            this.btnTraerTodosPublicadores = new System.Windows.Forms.Button();
            this.btnTraerAutoresPorCiudad = new System.Windows.Forms.Button();
            this.gridGeneral = new System.Windows.Forms.DataGridView();
            this.txtTraerAutoresPorCiudad = new System.Windows.Forms.TextBox();
            this.btnTraerAutorPorId = new System.Windows.Forms.Button();
            this.txtTraerAutorPorId = new System.Windows.Forms.TextBox();
            this.btnTraerAutorNombre = new System.Windows.Forms.Button();
            this.txtTraerAutorPorNombre = new System.Windows.Forms.TextBox();
            this.btnTraerSalesYStores = new System.Windows.Forms.Button();
            this.btnTraerEmployeesPublishers = new System.Windows.Forms.Button();
            this.btnTraerEmpPubPorPais = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodosAutores
            // 
            this.btnTraerTodosAutores.Location = new System.Drawing.Point(12, 12);
            this.btnTraerTodosAutores.Name = "btnTraerTodosAutores";
            this.btnTraerTodosAutores.Size = new System.Drawing.Size(156, 23);
            this.btnTraerTodosAutores.TabIndex = 0;
            this.btnTraerTodosAutores.Text = "Traer todos los autores";
            this.btnTraerTodosAutores.UseVisualStyleBackColor = true;
            this.btnTraerTodosAutores.Click += new System.EventHandler(this.btnTraerTodosAutores_Click);
            // 
            // btnTraerTodosPublicadores
            // 
            this.btnTraerTodosPublicadores.Location = new System.Drawing.Point(366, 12);
            this.btnTraerTodosPublicadores.Name = "btnTraerTodosPublicadores";
            this.btnTraerTodosPublicadores.Size = new System.Drawing.Size(222, 23);
            this.btnTraerTodosPublicadores.TabIndex = 1;
            this.btnTraerTodosPublicadores.Text = "Traer todos los publicadores";
            this.btnTraerTodosPublicadores.UseVisualStyleBackColor = true;
            this.btnTraerTodosPublicadores.Click += new System.EventHandler(this.btnTraerTodosPublicadores_Click);
            // 
            // btnTraerAutoresPorCiudad
            // 
            this.btnTraerAutoresPorCiudad.Location = new System.Drawing.Point(12, 55);
            this.btnTraerAutoresPorCiudad.Name = "btnTraerAutoresPorCiudad";
            this.btnTraerAutoresPorCiudad.Size = new System.Drawing.Size(156, 23);
            this.btnTraerAutoresPorCiudad.TabIndex = 2;
            this.btnTraerAutoresPorCiudad.Text = "Traer autores por ciudad";
            this.btnTraerAutoresPorCiudad.UseVisualStyleBackColor = true;
            this.btnTraerAutoresPorCiudad.Click += new System.EventHandler(this.btnTraerAutoresPorCiudad_Click);
            // 
            // gridGeneral
            // 
            this.gridGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGeneral.Location = new System.Drawing.Point(-5, 178);
            this.gridGeneral.Name = "gridGeneral";
            this.gridGeneral.Size = new System.Drawing.Size(806, 272);
            this.gridGeneral.TabIndex = 3;
            // 
            // txtTraerAutoresPorCiudad
            // 
            this.txtTraerAutoresPorCiudad.Location = new System.Drawing.Point(174, 58);
            this.txtTraerAutoresPorCiudad.Name = "txtTraerAutoresPorCiudad";
            this.txtTraerAutoresPorCiudad.Size = new System.Drawing.Size(122, 20);
            this.txtTraerAutoresPorCiudad.TabIndex = 4;
            // 
            // btnTraerAutorPorId
            // 
            this.btnTraerAutorPorId.Location = new System.Drawing.Point(12, 84);
            this.btnTraerAutorPorId.Name = "btnTraerAutorPorId";
            this.btnTraerAutorPorId.Size = new System.Drawing.Size(156, 23);
            this.btnTraerAutorPorId.TabIndex = 5;
            this.btnTraerAutorPorId.Text = "Traer autor por Id";
            this.btnTraerAutorPorId.UseVisualStyleBackColor = true;
            this.btnTraerAutorPorId.Click += new System.EventHandler(this.btnTraerAutorPorId_Click);
            // 
            // txtTraerAutorPorId
            // 
            this.txtTraerAutorPorId.Location = new System.Drawing.Point(174, 87);
            this.txtTraerAutorPorId.Name = "txtTraerAutorPorId";
            this.txtTraerAutorPorId.Size = new System.Drawing.Size(122, 20);
            this.txtTraerAutorPorId.TabIndex = 6;
            // 
            // btnTraerAutorNombre
            // 
            this.btnTraerAutorNombre.Location = new System.Drawing.Point(12, 113);
            this.btnTraerAutorNombre.Name = "btnTraerAutorNombre";
            this.btnTraerAutorNombre.Size = new System.Drawing.Size(156, 23);
            this.btnTraerAutorNombre.TabIndex = 7;
            this.btnTraerAutorNombre.Text = "Traer autor por su nombre";
            this.btnTraerAutorNombre.UseVisualStyleBackColor = true;
            this.btnTraerAutorNombre.Click += new System.EventHandler(this.btnTraerAutorNombre_Click);
            // 
            // txtTraerAutorPorNombre
            // 
            this.txtTraerAutorPorNombre.Location = new System.Drawing.Point(174, 116);
            this.txtTraerAutorPorNombre.Name = "txtTraerAutorPorNombre";
            this.txtTraerAutorPorNombre.Size = new System.Drawing.Size(122, 20);
            this.txtTraerAutorPorNombre.TabIndex = 8;
            // 
            // btnTraerSalesYStores
            // 
            this.btnTraerSalesYStores.Location = new System.Drawing.Point(366, 55);
            this.btnTraerSalesYStores.Name = "btnTraerSalesYStores";
            this.btnTraerSalesYStores.Size = new System.Drawing.Size(222, 23);
            this.btnTraerSalesYStores.TabIndex = 9;
            this.btnTraerSalesYStores.Text = "Traer sales y stores";
            this.btnTraerSalesYStores.UseVisualStyleBackColor = true;
            this.btnTraerSalesYStores.Click += new System.EventHandler(this.btnTraerSalesYStores_Click);
            // 
            // btnTraerEmployeesPublishers
            // 
            this.btnTraerEmployeesPublishers.Location = new System.Drawing.Point(366, 87);
            this.btnTraerEmployeesPublishers.Name = "btnTraerEmployeesPublishers";
            this.btnTraerEmployeesPublishers.Size = new System.Drawing.Size(222, 23);
            this.btnTraerEmployeesPublishers.TabIndex = 10;
            this.btnTraerEmployeesPublishers.Text = "Traer employees y publishers";
            this.btnTraerEmployeesPublishers.UseVisualStyleBackColor = true;
            this.btnTraerEmployeesPublishers.Click += new System.EventHandler(this.btnTraerEmployeesPublishers_Click);
            // 
            // btnTraerEmpPubPorPais
            // 
            this.btnTraerEmpPubPorPais.Location = new System.Drawing.Point(366, 116);
            this.btnTraerEmpPubPorPais.Name = "btnTraerEmpPubPorPais";
            this.btnTraerEmpPubPorPais.Size = new System.Drawing.Size(221, 23);
            this.btnTraerEmpPubPorPais.TabIndex = 11;
            this.btnTraerEmpPubPorPais.Text = "Traer employees por País";
            this.btnTraerEmpPubPorPais.UseVisualStyleBackColor = true;
            this.btnTraerEmpPubPorPais.Click += new System.EventHandler(this.btnTraerEmpPubPorPais_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTraerEmpPubPorPais);
            this.Controls.Add(this.btnTraerEmployeesPublishers);
            this.Controls.Add(this.btnTraerSalesYStores);
            this.Controls.Add(this.txtTraerAutorPorNombre);
            this.Controls.Add(this.btnTraerAutorNombre);
            this.Controls.Add(this.txtTraerAutorPorId);
            this.Controls.Add(this.btnTraerAutorPorId);
            this.Controls.Add(this.txtTraerAutoresPorCiudad);
            this.Controls.Add(this.gridGeneral);
            this.Controls.Add(this.btnTraerAutoresPorCiudad);
            this.Controls.Add(this.btnTraerTodosPublicadores);
            this.Controls.Add(this.btnTraerTodosAutores);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodosAutores;
        private System.Windows.Forms.Button btnTraerTodosPublicadores;
        private System.Windows.Forms.Button btnTraerAutoresPorCiudad;
        private System.Windows.Forms.DataGridView gridGeneral;
        private System.Windows.Forms.TextBox txtTraerAutoresPorCiudad;
        private System.Windows.Forms.Button btnTraerAutorPorId;
        private System.Windows.Forms.TextBox txtTraerAutorPorId;
        private System.Windows.Forms.Button btnTraerAutorNombre;
        private System.Windows.Forms.TextBox txtTraerAutorPorNombre;
        private System.Windows.Forms.Button btnTraerSalesYStores;
        private System.Windows.Forms.Button btnTraerEmployeesPublishers;
        private System.Windows.Forms.Button btnTraerEmpPubPorPais;
    }
}

