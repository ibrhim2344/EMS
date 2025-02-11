namespace min
{
    partial class rpt_watik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_watik));
            this.top_pnl = new Guna.UI.WinForms.GunaPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.but_pdf = new Guna.UI.WinForms.GunaButton();
            this.but_print = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.watik = new Guna.UI.WinForms.GunaPictureBox();
            this.but_clos = new Guna.UI.WinForms.GunaImageButton();
            this.top_pnl.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watik)).BeginInit();
            this.SuspendLayout();
            // 
            // top_pnl
            // 
            this.top_pnl.BackColor = System.Drawing.Color.Azure;
            this.top_pnl.Controls.Add(this.flowLayoutPanel2);
            this.top_pnl.Controls.Add(this.but_clos);
            this.top_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_pnl.Location = new System.Drawing.Point(0, 0);
            this.top_pnl.Name = "top_pnl";
            this.top_pnl.Size = new System.Drawing.Size(580, 34);
            this.top_pnl.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.gunaLabel7);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(206, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(374, 34);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Almarai", 9.749999F);
            this.gunaLabel7.Location = new System.Drawing.Point(280, 7);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(7);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(87, 20);
            this.gunaLabel7.TabIndex = 6;
            this.gunaLabel7.Text = "وثيقة الموظف";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Azure;
            this.gunaPanel1.Controls.Add(this.but_pdf);
            this.gunaPanel1.Controls.Add(this.but_print);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 397);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(580, 75);
            this.gunaPanel1.TabIndex = 7;
            // 
            // but_pdf
            // 
            this.but_pdf.AnimationHoverSpeed = 0.07F;
            this.but_pdf.AnimationSpeed = 0.03F;
            this.but_pdf.BackColor = System.Drawing.Color.Transparent;
            this.but_pdf.BaseColor = System.Drawing.Color.White;
            this.but_pdf.BorderColor = System.Drawing.Color.Black;
            this.but_pdf.BorderSize = 1;
            this.but_pdf.DialogResult = System.Windows.Forms.DialogResult.None;
            this.but_pdf.FocusedColor = System.Drawing.Color.Empty;
            this.but_pdf.Font = new System.Drawing.Font("Almarai Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_pdf.ForeColor = System.Drawing.Color.Black;
            this.but_pdf.Image = null;
            this.but_pdf.ImageSize = new System.Drawing.Size(20, 20);
            this.but_pdf.Location = new System.Drawing.Point(354, 13);
            this.but_pdf.Name = "but_pdf";
            this.but_pdf.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.but_pdf.OnHoverBorderColor = System.Drawing.Color.Black;
            this.but_pdf.OnHoverForeColor = System.Drawing.Color.Black;
            this.but_pdf.OnHoverImage = null;
            this.but_pdf.OnPressedColor = System.Drawing.Color.Black;
            this.but_pdf.Radius = 2;
            this.but_pdf.Size = new System.Drawing.Size(172, 50);
            this.but_pdf.TabIndex = 11;
            this.but_pdf.Text = "PDF";
            this.but_pdf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.but_pdf.Click += new System.EventHandler(this.but_pdf_Click);
            // 
            // but_print
            // 
            this.but_print.AnimationHoverSpeed = 0.07F;
            this.but_print.AnimationSpeed = 0.03F;
            this.but_print.BackColor = System.Drawing.Color.Transparent;
            this.but_print.BaseColor = System.Drawing.Color.White;
            this.but_print.BorderColor = System.Drawing.Color.Black;
            this.but_print.BorderSize = 1;
            this.but_print.DialogResult = System.Windows.Forms.DialogResult.None;
            this.but_print.FocusedColor = System.Drawing.Color.Empty;
            this.but_print.Font = new System.Drawing.Font("Almarai Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_print.ForeColor = System.Drawing.Color.Black;
            this.but_print.Image = null;
            this.but_print.ImageSize = new System.Drawing.Size(20, 20);
            this.but_print.Location = new System.Drawing.Point(61, 13);
            this.but_print.Name = "but_print";
            this.but_print.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.but_print.OnHoverBorderColor = System.Drawing.Color.Black;
            this.but_print.OnHoverForeColor = System.Drawing.Color.Black;
            this.but_print.OnHoverImage = null;
            this.but_print.OnPressedColor = System.Drawing.Color.Black;
            this.but_print.Radius = 2;
            this.but_print.Size = new System.Drawing.Size(172, 50);
            this.but_print.TabIndex = 10;
            this.but_print.Text = "طابعة";
            this.but_print.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.but_print.Click += new System.EventHandler(this.but_print_Click_1);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.watik);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 34);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(580, 363);
            this.gunaPanel2.TabIndex = 8;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // watik
            // 
            this.watik.BaseColor = System.Drawing.Color.White;
            this.watik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watik.Location = new System.Drawing.Point(0, 0);
            this.watik.Name = "watik";
            this.watik.Size = new System.Drawing.Size(580, 363);
            this.watik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.watik.TabIndex = 19;
            this.watik.TabStop = false;
            // 
            // but_clos
            // 
            this.but_clos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.but_clos.Image = global::min.Properties.Resources.icons8_delete_sign_filled_24px;
            this.but_clos.ImageSize = new System.Drawing.Size(24, 24);
            this.but_clos.Location = new System.Drawing.Point(0, 1);
            this.but_clos.Name = "but_clos";
            this.but_clos.OnHoverImage = null;
            this.but_clos.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.but_clos.Size = new System.Drawing.Size(31, 31);
            this.but_clos.TabIndex = 1;
            this.but_clos.Click += new System.EventHandler(this.but_clos_Click);
            // 
            // rpt_watik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 472);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.top_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rpt_watik";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الوثيقة";
            this.Load += new System.EventHandler(this.rpt_watik_Load);
            this.top_pnl.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel top_pnl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        internal Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaImageButton but_clos;
        public Guna.UI.WinForms.GunaPanel gunaPanel1;
        public Guna.UI.WinForms.GunaButton but_pdf;
        public Guna.UI.WinForms.GunaButton but_print;
        public Guna.UI.WinForms.GunaPanel gunaPanel2;
        public Guna.UI.WinForms.GunaPictureBox watik;
        public System.Windows.Forms.PrintDialog printDialog1;
        public System.Drawing.Printing.PrintDocument printDocument1;

    }
}