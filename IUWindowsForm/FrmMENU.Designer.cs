
namespace IUWindowsForm
{
    partial class FrmMENU
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFrmBuscarMateria = new System.Windows.Forms.Button();
            this.btnFrmShowMaterias = new System.Windows.Forms.Button();
            this.btnFrmAddMateria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFrmInformeMaterias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(336, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFrmBuscarMateria
            // 
            this.btnFrmBuscarMateria.Location = new System.Drawing.Point(334, 263);
            this.btnFrmBuscarMateria.Name = "btnFrmBuscarMateria";
            this.btnFrmBuscarMateria.Size = new System.Drawing.Size(132, 23);
            this.btnFrmBuscarMateria.TabIndex = 8;
            this.btnFrmBuscarMateria.Text = "BuscarMateria";
            this.btnFrmBuscarMateria.UseVisualStyleBackColor = true;
            this.btnFrmBuscarMateria.Click += new System.EventHandler(this.btnFrmBuscarMateria_Click);
            // 
            // btnFrmShowMaterias
            // 
            this.btnFrmShowMaterias.Location = new System.Drawing.Point(334, 220);
            this.btnFrmShowMaterias.Name = "btnFrmShowMaterias";
            this.btnFrmShowMaterias.Size = new System.Drawing.Size(132, 23);
            this.btnFrmShowMaterias.TabIndex = 7;
            this.btnFrmShowMaterias.Text = "ShowMaterias";
            this.btnFrmShowMaterias.UseVisualStyleBackColor = true;
            this.btnFrmShowMaterias.Click += new System.EventHandler(this.btnFrmShowMaterias_Click);
            // 
            // btnFrmAddMateria
            // 
            this.btnFrmAddMateria.Location = new System.Drawing.Point(334, 164);
            this.btnFrmAddMateria.Name = "btnFrmAddMateria";
            this.btnFrmAddMateria.Size = new System.Drawing.Size(132, 23);
            this.btnFrmAddMateria.TabIndex = 6;
            this.btnFrmAddMateria.Text = "AddMateria";
            this.btnFrmAddMateria.UseVisualStyleBackColor = true;
            this.btnFrmAddMateria.Click += new System.EventHandler(this.btnFrmAddMateria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu";
            // 
            // btnFrmInformeMaterias
            // 
            this.btnFrmInformeMaterias.Location = new System.Drawing.Point(336, 135);
            this.btnFrmInformeMaterias.Name = "btnFrmInformeMaterias";
            this.btnFrmInformeMaterias.Size = new System.Drawing.Size(130, 23);
            this.btnFrmInformeMaterias.TabIndex = 10;
            this.btnFrmInformeMaterias.Text = "Informe";
            this.btnFrmInformeMaterias.UseVisualStyleBackColor = true;
            this.btnFrmInformeMaterias.Click += new System.EventHandler(this.btnFrmInformeMaterias_Click);
            // 
            // FrmMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFrmInformeMaterias);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFrmBuscarMateria);
            this.Controls.Add(this.btnFrmShowMaterias);
            this.Controls.Add(this.btnFrmAddMateria);
            this.Controls.Add(this.label1);
            this.Name = "FrmMENU";
            this.Text = "FrmMENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFrmBuscarMateria;
        private System.Windows.Forms.Button btnFrmShowMaterias;
        private System.Windows.Forms.Button btnFrmAddMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFrmInformeMaterias;
    }
}