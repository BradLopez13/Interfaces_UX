
namespace BancoTierraMedia
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.solicitarPrestamo = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Wheat;
            this.titulo.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.Maroon;
            this.titulo.Location = new System.Drawing.Point(177, 43);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(452, 46);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "Banco de la Tierra Media";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(179, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Su nombre:";
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.BackColor = System.Drawing.Color.Red;
            this.Salir.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Salir.Location = new System.Drawing.Point(681, 392);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(111, 57);
            this.Salir.TabIndex = 3;
            this.Salir.Text = "SALIR";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // nombre
            // 
            this.nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(339, 182);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(290, 29);
            this.nombre.TabIndex = 0;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // solicitarPrestamo
            // 
            this.solicitarPrestamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.solicitarPrestamo.BackColor = System.Drawing.Color.Maroon;
            this.solicitarPrestamo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solicitarPrestamo.ForeColor = System.Drawing.Color.White;
            this.solicitarPrestamo.Location = new System.Drawing.Point(292, 291);
            this.solicitarPrestamo.Name = "solicitarPrestamo";
            this.solicitarPrestamo.Size = new System.Drawing.Size(205, 68);
            this.solicitarPrestamo.TabIndex = 2;
            this.solicitarPrestamo.Text = "Solicitar préstamo";
            this.solicitarPrestamo.UseVisualStyleBackColor = false;
            this.solicitarPrestamo.Click += new System.EventHandler(this.solicitarPrestamo_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // logo
            // 
            this.logo.Image = global::tierra_Media.Properties.Resources.book;
            this.logo.Location = new System.Drawing.Point(31, 30);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(111, 70);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.solicitarPrestamo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco ";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button solicitarPrestamo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}