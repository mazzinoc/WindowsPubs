
namespace WindowsPubs3
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
            this.btnTraerAutores = new System.Windows.Forms.Button();
            this.btnTraerPublicadores = new System.Windows.Forms.Button();
            this.btnAutoresCiudad = new System.Windows.Forms.Button();
            this.btnTraerAutorId = new System.Windows.Forms.Button();
            this.btnPublicadorNombre = new System.Windows.Forms.Button();
            this.gridMostrar = new System.Windows.Forms.DataGridView();
            this.btnLista1 = new System.Windows.Forms.Button();
            this.btnLista2 = new System.Windows.Forms.Button();
            this.btnLista3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerAutores
            // 
            this.btnTraerAutores.Location = new System.Drawing.Point(260, 68);
            this.btnTraerAutores.Name = "btnTraerAutores";
            this.btnTraerAutores.Size = new System.Drawing.Size(234, 23);
            this.btnTraerAutores.TabIndex = 0;
            this.btnTraerAutores.Text = "Traer Autores";
            this.btnTraerAutores.UseVisualStyleBackColor = true;
            this.btnTraerAutores.Click += new System.EventHandler(this.btnTraerAutores_Click);
            // 
            // btnTraerPublicadores
            // 
            this.btnTraerPublicadores.Location = new System.Drawing.Point(260, 97);
            this.btnTraerPublicadores.Name = "btnTraerPublicadores";
            this.btnTraerPublicadores.Size = new System.Drawing.Size(234, 23);
            this.btnTraerPublicadores.TabIndex = 1;
            this.btnTraerPublicadores.Text = "Traer Publicadores";
            this.btnTraerPublicadores.UseVisualStyleBackColor = true;
            this.btnTraerPublicadores.Click += new System.EventHandler(this.btnTraerPublicadores_Click);
            // 
            // btnAutoresCiudad
            // 
            this.btnAutoresCiudad.Location = new System.Drawing.Point(260, 126);
            this.btnAutoresCiudad.Name = "btnAutoresCiudad";
            this.btnAutoresCiudad.Size = new System.Drawing.Size(234, 23);
            this.btnAutoresCiudad.TabIndex = 2;
            this.btnAutoresCiudad.Text = "Traer Autores Por ciudad";
            this.btnAutoresCiudad.UseVisualStyleBackColor = true;
            this.btnAutoresCiudad.Click += new System.EventHandler(this.btnAutoresCiudad_Click);
            // 
            // btnTraerAutorId
            // 
            this.btnTraerAutorId.Location = new System.Drawing.Point(260, 155);
            this.btnTraerAutorId.Name = "btnTraerAutorId";
            this.btnTraerAutorId.Size = new System.Drawing.Size(234, 23);
            this.btnTraerAutorId.TabIndex = 3;
            this.btnTraerAutorId.Text = "Traer autores por Id";
            this.btnTraerAutorId.UseVisualStyleBackColor = true;
            this.btnTraerAutorId.Click += new System.EventHandler(this.btnTraerAutorId_Click);
            // 
            // btnPublicadorNombre
            // 
            this.btnPublicadorNombre.Location = new System.Drawing.Point(260, 184);
            this.btnPublicadorNombre.Name = "btnPublicadorNombre";
            this.btnPublicadorNombre.Size = new System.Drawing.Size(234, 23);
            this.btnPublicadorNombre.TabIndex = 4;
            this.btnPublicadorNombre.Text = "Traer Publicador por nombre";
            this.btnPublicadorNombre.UseVisualStyleBackColor = true;
            this.btnPublicadorNombre.Click += new System.EventHandler(this.btnPublicadorNombre_Click);
            // 
            // gridMostrar
            // 
            this.gridMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMostrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMostrar.Location = new System.Drawing.Point(0, 300);
            this.gridMostrar.Name = "gridMostrar";
            this.gridMostrar.Size = new System.Drawing.Size(800, 150);
            this.gridMostrar.TabIndex = 5;
            // 
            // btnLista1
            // 
            this.btnLista1.Location = new System.Drawing.Point(260, 213);
            this.btnLista1.Name = "btnLista1";
            this.btnLista1.Size = new System.Drawing.Size(234, 23);
            this.btnLista1.TabIndex = 6;
            this.btnLista1.Text = "Lista1";
            this.btnLista1.UseVisualStyleBackColor = true;
            this.btnLista1.Click += new System.EventHandler(this.btnLista1_Click);
            // 
            // btnLista2
            // 
            this.btnLista2.Location = new System.Drawing.Point(260, 242);
            this.btnLista2.Name = "btnLista2";
            this.btnLista2.Size = new System.Drawing.Size(234, 23);
            this.btnLista2.TabIndex = 7;
            this.btnLista2.Text = "Lista2";
            this.btnLista2.UseVisualStyleBackColor = true;
            this.btnLista2.Click += new System.EventHandler(this.btnLista2_Click);
            // 
            // btnLista3
            // 
            this.btnLista3.Location = new System.Drawing.Point(260, 271);
            this.btnLista3.Name = "btnLista3";
            this.btnLista3.Size = new System.Drawing.Size(234, 23);
            this.btnLista3.TabIndex = 8;
            this.btnLista3.Text = "lista 3";
            this.btnLista3.UseVisualStyleBackColor = true;
            this.btnLista3.Click += new System.EventHandler(this.btnLista3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLista3);
            this.Controls.Add(this.btnLista2);
            this.Controls.Add(this.btnLista1);
            this.Controls.Add(this.gridMostrar);
            this.Controls.Add(this.btnPublicadorNombre);
            this.Controls.Add(this.btnTraerAutorId);
            this.Controls.Add(this.btnAutoresCiudad);
            this.Controls.Add(this.btnTraerPublicadores);
            this.Controls.Add(this.btnTraerAutores);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerAutores;
        private System.Windows.Forms.Button btnTraerPublicadores;
        private System.Windows.Forms.Button btnAutoresCiudad;
        private System.Windows.Forms.Button btnTraerAutorId;
        private System.Windows.Forms.Button btnPublicadorNombre;
        private System.Windows.Forms.DataGridView gridMostrar;
        private System.Windows.Forms.Button btnLista1;
        private System.Windows.Forms.Button btnLista2;
        private System.Windows.Forms.Button btnLista3;
    }
}

