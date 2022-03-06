namespace Menu.View
{
    partial class RelatorioMotorista
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
            this.CarregarRelatorio = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // CarregarRelatorio
            // 
            this.CarregarRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarregarRelatorio.Location = new System.Drawing.Point(713, 12);
            this.CarregarRelatorio.Name = "CarregarRelatorio";
            this.CarregarRelatorio.Size = new System.Drawing.Size(75, 23);
            this.CarregarRelatorio.TabIndex = 3;
            this.CarregarRelatorio.Text = "Carregar";
            this.CarregarRelatorio.UseVisualStyleBackColor = true;
            this.CarregarRelatorio.Click += new System.EventHandler(this.CarregarRelatorio_Click);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Menu.View.RelatorioMotorista.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 35);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(776, 403);
            this.reportViewer2.TabIndex = 2;
            // 
            // RelatorioMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CarregarRelatorio);
            this.Controls.Add(this.reportViewer2);
            this.Name = "RelatorioMotorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioMotorista";
            this.Load += new System.EventHandler(this.RelatorioMotorista_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CarregarRelatorio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}