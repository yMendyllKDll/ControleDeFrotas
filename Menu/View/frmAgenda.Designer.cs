namespace Menu.View
{
    partial class frmAgenda
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
            this.CompromissosDoDia = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CompromissosDoDia
            // 
            this.CompromissosDoDia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompromissosDoDia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.CompromissosDoDia.FullRowSelect = true;
            this.CompromissosDoDia.GridLines = true;
            this.CompromissosDoDia.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CompromissosDoDia.HideSelection = false;
            this.CompromissosDoDia.Location = new System.Drawing.Point(254, 14);
            this.CompromissosDoDia.Name = "CompromissosDoDia";
            this.CompromissosDoDia.Size = new System.Drawing.Size(400, 400);
            this.CompromissosDoDia.TabIndex = 6;
            this.CompromissosDoDia.UseCompatibleStateImageBehavior = false;
            this.CompromissosDoDia.View = System.Windows.Forms.View.Details;
            this.CompromissosDoDia.SelectedIndexChanged += new System.EventHandler(this.CompromissosDoDia_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hora";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descrição";
            this.columnHeader3.Width = 250;
            // 
            // Calendario
            // 
            this.Calendario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendario.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.Calendario.Location = new System.Drawing.Point(15, 14);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 5;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // relogio
            // 
            this.relogio.Enabled = true;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 428);
            this.Controls.Add(this.CompromissosDoDia);
            this.Controls.Add(this.Calendario);
            this.Name = "frmAgenda";
            this.Text = "Agenda de Viagens";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CompromissosDoDia;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Timer relogio;
    }
}