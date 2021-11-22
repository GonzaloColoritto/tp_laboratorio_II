
namespace Formularios
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elegirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.premioMasSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electrodomesticoMasElegidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hombresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mujeresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noBinariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasEnEsperaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaMasElegidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstPremios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarPersonas = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.filtrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elegirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // elegirToolStripMenuItem
            // 
            this.elegirToolStripMenuItem.Name = "elegirToolStripMenuItem";
            this.elegirToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.elegirToolStripMenuItem.Text = "Elegir Premio";
            this.elegirToolStripMenuItem.Click += new System.EventHandler(this.elegirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // personaToolStripMenuItem
            // 
            this.personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            this.personaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.personaToolStripMenuItem.Text = "Persona";
            this.personaToolStripMenuItem.Click += new System.EventHandler(this.personaToolStripMenuItem_Click);
            // 
            // filtrarToolStripMenuItem
            // 
            this.filtrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.premioMasSeleccionadoToolStripMenuItem,
            this.electrodomesticoMasElegidoToolStripMenuItem,
            this.personasEnEsperaToolStripMenuItem,
            this.marcaMasElegidaToolStripMenuItem});
            this.filtrarToolStripMenuItem.Name = "filtrarToolStripMenuItem";
            this.filtrarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.filtrarToolStripMenuItem.Text = " Filtros";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.datosToolStripMenuItem.Text = "Datos ";
            this.datosToolStripMenuItem.Click += new System.EventHandler(this.datosToolStripMenuItem_Click);
            // 
            // premioMasSeleccionadoToolStripMenuItem
            // 
            this.premioMasSeleccionadoToolStripMenuItem.Name = "premioMasSeleccionadoToolStripMenuItem";
            this.premioMasSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.premioMasSeleccionadoToolStripMenuItem.Text = "Premio mas elegido";
            this.premioMasSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.premioMasSeleccionadoToolStripMenuItem_Click);
            // 
            // electrodomesticoMasElegidoToolStripMenuItem
            // 
            this.electrodomesticoMasElegidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hombresToolStripMenuItem,
            this.mujeresToolStripMenuItem,
            this.noBinariosToolStripMenuItem});
            this.electrodomesticoMasElegidoToolStripMenuItem.Name = "electrodomesticoMasElegidoToolStripMenuItem";
            this.electrodomesticoMasElegidoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.electrodomesticoMasElegidoToolStripMenuItem.Text = "Electrodomestico mas elegido por";
            // 
            // hombresToolStripMenuItem
            // 
            this.hombresToolStripMenuItem.Name = "hombresToolStripMenuItem";
            this.hombresToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.hombresToolStripMenuItem.Text = "Hombres";
            this.hombresToolStripMenuItem.Click += new System.EventHandler(this.hombresToolStripMenuItem_Click);
            // 
            // mujeresToolStripMenuItem
            // 
            this.mujeresToolStripMenuItem.Name = "mujeresToolStripMenuItem";
            this.mujeresToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mujeresToolStripMenuItem.Text = "Mujeres";
            this.mujeresToolStripMenuItem.Click += new System.EventHandler(this.mujeresToolStripMenuItem_Click);
            // 
            // noBinariosToolStripMenuItem
            // 
            this.noBinariosToolStripMenuItem.Name = "noBinariosToolStripMenuItem";
            this.noBinariosToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.noBinariosToolStripMenuItem.Text = "No Binarios";
            this.noBinariosToolStripMenuItem.Click += new System.EventHandler(this.noBinariosToolStripMenuItem_Click);
            // 
            // personasEnEsperaToolStripMenuItem
            // 
            this.personasEnEsperaToolStripMenuItem.Name = "personasEnEsperaToolStripMenuItem";
            this.personasEnEsperaToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.personasEnEsperaToolStripMenuItem.Text = "Personas en espera";
            this.personasEnEsperaToolStripMenuItem.Click += new System.EventHandler(this.personasEnEsperaToolStripMenuItem_Click_1);
            // 
            // marcaMasElegidaToolStripMenuItem
            // 
            this.marcaMasElegidaToolStripMenuItem.Name = "marcaMasElegidaToolStripMenuItem";
            this.marcaMasElegidaToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.marcaMasElegidaToolStripMenuItem.Text = "Marca mas elegida";
            this.marcaMasElegidaToolStripMenuItem.Click += new System.EventHandler(this.marcaMasElegidaToolStripMenuItem_Click);
            // 
            // lstPremios
            // 
            this.lstPremios.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstPremios.FormattingEnabled = true;
            this.lstPremios.ItemHeight = 26;
            this.lstPremios.Location = new System.Drawing.Point(353, 50);
            this.lstPremios.Name = "lstPremios";
            this.lstPremios.Size = new System.Drawing.Size(359, 264);
            this.lstPremios.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(478, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTA DE GANADORES";
            // 
            // btnCargarPersonas
            // 
            this.btnCargarPersonas.Location = new System.Drawing.Point(10, 378);
            this.btnCargarPersonas.Name = "btnCargarPersonas";
            this.btnCargarPersonas.Size = new System.Drawing.Size(112, 29);
            this.btnCargarPersonas.TabIndex = 3;
            this.btnCargarPersonas.Text = "Cargar Personas";
            this.btnCargarPersonas.UseVisualStyleBackColor = true;
            this.btnCargarPersonas.Click += new System.EventHandler(this.btnCargarPersonas_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(571, 373);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(141, 42);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir ticket";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(128, 378);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(152, 29);
            this.btnCargarDatos.TabIndex = 7;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 419);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCargarPersonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPremios);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TpFinal Gonzalo Coloritto 2E";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInicio_FormClosing);
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elegirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
        private System.Windows.Forms.ListBox lstPremios;
        private System.Windows.Forms.ToolStripMenuItem premioMasSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem electrodomesticoMasElegidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hombresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mujeresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noBinariosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarPersonas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personasEnEsperaToolStripMenuItem;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.ToolStripMenuItem marcaMasElegidaToolStripMenuItem;
    }
}

