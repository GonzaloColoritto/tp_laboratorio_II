
namespace Formularios
{
    partial class FormEleccion
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
            this.cmbPersona = new System.Windows.Forms.ComboBox();
            this.cmbPremio = new System.Windows.Forms.ComboBox();
            this.cmbTipoElectrodomestico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPremios = new System.Windows.Forms.ListBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPersona
            // 
            this.cmbPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersona.DropDownWidth = 170;
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Location = new System.Drawing.Point(17, 61);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Size = new System.Drawing.Size(146, 23);
            this.cmbPersona.TabIndex = 0;
            // 
            // cmbPremio
            // 
            this.cmbPremio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPremio.DropDownWidth = 170;
            this.cmbPremio.FormattingEnabled = true;
            this.cmbPremio.Location = new System.Drawing.Point(92, 138);
            this.cmbPremio.Name = "cmbPremio";
            this.cmbPremio.Size = new System.Drawing.Size(141, 23);
            this.cmbPremio.TabIndex = 1;
            // 
            // cmbTipoElectrodomestico
            // 
            this.cmbTipoElectrodomestico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoElectrodomestico.DropDownWidth = 170;
            this.cmbTipoElectrodomestico.FormattingEnabled = true;
            this.cmbTipoElectrodomestico.Location = new System.Drawing.Point(169, 61);
            this.cmbTipoElectrodomestico.Name = "cmbTipoElectrodomestico";
            this.cmbTipoElectrodomestico.Size = new System.Drawing.Size(141, 23);
            this.cmbTipoElectrodomestico.TabIndex = 2;
            this.cmbTipoElectrodomestico.SelectedIndexChanged += new System.EventHandler(this.cmbTipoElectrodomestico_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Electrodomestico seleccionado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eliga su premio";
            // 
            // lstPremios
            // 
            this.lstPremios.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstPremios.FormattingEnabled = true;
            this.lstPremios.ItemHeight = 17;
            this.lstPremios.Location = new System.Drawing.Point(370, 12);
            this.lstPremios.Name = "lstPremios";
            this.lstPremios.Size = new System.Drawing.Size(363, 310);
            this.lstPremios.TabIndex = 6;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(105, 221);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(116, 49);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FormEleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 338);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lstPremios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoElectrodomestico);
            this.Controls.Add(this.cmbPremio);
            this.Controls.Add(this.cmbPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eleccion de premio";
            this.Load += new System.EventHandler(this.FormEleccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersona;
        private System.Windows.Forms.ComboBox cmbPremio;
        private System.Windows.Forms.ComboBox cmbTipoElectrodomestico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPremios;
        private System.Windows.Forms.Button btnFinalizar;
    }
}