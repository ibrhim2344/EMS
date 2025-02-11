namespace min
{
    partial class notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notes));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.ser_qasem = new Guna.UI.WinForms.GunaTextBox();
            this.txt_date_2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txt_date_1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.GunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.txte_sersh = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.but_delt_note = new System.Windows.Forms.Button();
            this.but_add_note = new System.Windows.Forms.Button();
            this.but_restert_note = new System.Windows.Forms.Button();
            this.but_rpt_note = new System.Windows.Forms.Button();
            this.dg_note = new System.Windows.Forms.DataGridView();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunaCirclePictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_note)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Controls.Add(this.flowLayoutPanel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1164, 84);
            this.gunaPanel1.TabIndex = 1;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaCirclePictureBox2);
            this.gunaPanel2.Controls.Add(this.ser_qasem);
            this.gunaPanel2.Controls.Add(this.txt_date_2);
            this.gunaPanel2.Controls.Add(this.txt_date_1);
            this.gunaPanel2.Controls.Add(this.GunaCirclePictureBox1);
            this.gunaPanel2.Controls.Add(this.txte_sersh);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel2.Location = new System.Drawing.Point(23, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(787, 84);
            this.gunaPanel2.TabIndex = 81;
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BackColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.Image = global::min.Properties.Resources.icons8_search_28px;
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(555, 30);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(28, 28);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaCirclePictureBox2.TabIndex = 86;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // ser_qasem
            // 
            this.ser_qasem.BackColor = System.Drawing.Color.Transparent;
            this.ser_qasem.BaseColor = System.Drawing.Color.White;
            this.ser_qasem.BorderColor = System.Drawing.Color.Black;
            this.ser_qasem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ser_qasem.FocusedBaseColor = System.Drawing.Color.White;
            this.ser_qasem.FocusedBorderColor = System.Drawing.Color.Black;
            this.ser_qasem.FocusedForeColor = System.Drawing.Color.Black;
            this.ser_qasem.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ser_qasem.Location = new System.Drawing.Point(547, 22);
            this.ser_qasem.Name = "ser_qasem";
            this.ser_qasem.PasswordChar = '\0';
            this.ser_qasem.Radius = 10;
            this.ser_qasem.SelectedText = "";
            this.ser_qasem.Size = new System.Drawing.Size(237, 43);
            this.ser_qasem.TabIndex = 85;
            this.ser_qasem.TextChanged += new System.EventHandler(this.ser_qasem_TextChanged);
            // 
            // txt_date_2
            // 
            this.txt_date_2.BackColor = System.Drawing.Color.Transparent;
            this.txt_date_2.BaseColor = System.Drawing.Color.White;
            this.txt_date_2.BorderColor = System.Drawing.Color.Black;
            this.txt_date_2.BorderSize = 1;
            this.txt_date_2.CustomFormat = null;
            this.txt_date_2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_date_2.FocusedColor = System.Drawing.Color.Transparent;
            this.txt_date_2.Font = new System.Drawing.Font("Almarai Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date_2.ForeColor = System.Drawing.Color.Black;
            this.txt_date_2.Location = new System.Drawing.Point(9, 46);
            this.txt_date_2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_date_2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_date_2.Name = "txt_date_2";
            this.txt_date_2.OnHoverBaseColor = System.Drawing.Color.White;
            this.txt_date_2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txt_date_2.OnHoverForeColor = System.Drawing.Color.Black;
            this.txt_date_2.OnPressedColor = System.Drawing.Color.Black;
            this.txt_date_2.Radius = 3;
            this.txt_date_2.Size = new System.Drawing.Size(222, 28);
            this.txt_date_2.TabIndex = 83;
            this.txt_date_2.Text = "Thursday, November 7, 2024";
            this.txt_date_2.Value = new System.DateTime(2024, 11, 7, 17, 18, 32, 396);
            this.txt_date_2.Validated += new System.EventHandler(this.txt_date_2_Validated);
            // 
            // txt_date_1
            // 
            this.txt_date_1.BackColor = System.Drawing.Color.Transparent;
            this.txt_date_1.BaseColor = System.Drawing.Color.White;
            this.txt_date_1.BorderColor = System.Drawing.Color.Black;
            this.txt_date_1.BorderSize = 1;
            this.txt_date_1.CustomFormat = null;
            this.txt_date_1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_date_1.FocusedColor = System.Drawing.Color.Transparent;
            this.txt_date_1.Font = new System.Drawing.Font("Almarai Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date_1.ForeColor = System.Drawing.Color.Black;
            this.txt_date_1.Location = new System.Drawing.Point(9, 12);
            this.txt_date_1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_date_1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_date_1.Name = "txt_date_1";
            this.txt_date_1.OnHoverBaseColor = System.Drawing.Color.White;
            this.txt_date_1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txt_date_1.OnHoverForeColor = System.Drawing.Color.Black;
            this.txt_date_1.OnPressedColor = System.Drawing.Color.Black;
            this.txt_date_1.Radius = 3;
            this.txt_date_1.Size = new System.Drawing.Size(222, 28);
            this.txt_date_1.TabIndex = 82;
            this.txt_date_1.Text = "Thursday, November 7, 2024";
            this.txt_date_1.Value = new System.DateTime(2024, 11, 7, 17, 18, 32, 396);
            this.txt_date_1.Validated += new System.EventHandler(this.txt_date_1_Validated);
            // 
            // GunaCirclePictureBox1
            // 
            this.GunaCirclePictureBox1.BackColor = System.Drawing.Color.White;
            this.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.GunaCirclePictureBox1.Image = global::min.Properties.Resources.icons8_search_28px;
            this.GunaCirclePictureBox1.Location = new System.Drawing.Point(245, 30);
            this.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1";
            this.GunaCirclePictureBox1.Size = new System.Drawing.Size(28, 28);
            this.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GunaCirclePictureBox1.TabIndex = 81;
            this.GunaCirclePictureBox1.TabStop = false;
            this.GunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // txte_sersh
            // 
            this.txte_sersh.BackColor = System.Drawing.Color.Transparent;
            this.txte_sersh.BaseColor = System.Drawing.Color.White;
            this.txte_sersh.BorderColor = System.Drawing.Color.Black;
            this.txte_sersh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txte_sersh.FocusedBaseColor = System.Drawing.Color.White;
            this.txte_sersh.FocusedBorderColor = System.Drawing.Color.Black;
            this.txte_sersh.FocusedForeColor = System.Drawing.Color.Black;
            this.txte_sersh.Font = new System.Drawing.Font("Cairo", 9.749999F);
            this.txte_sersh.ForeColor = System.Drawing.Color.DarkRed;
            this.txte_sersh.Location = new System.Drawing.Point(237, 22);
            this.txte_sersh.Name = "txte_sersh";
            this.txte_sersh.PasswordChar = '\0';
            this.txte_sersh.Radius = 10;
            this.txte_sersh.SelectedText = "";
            this.txte_sersh.Size = new System.Drawing.Size(304, 43);
            this.txte_sersh.TabIndex = 80;
            this.txte_sersh.TextChanged += new System.EventHandler(this.txte_sersh_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.but_delt_note);
            this.flowLayoutPanel1.Controls.Add(this.but_add_note);
            this.flowLayoutPanel1.Controls.Add(this.but_restert_note);
            this.flowLayoutPanel1.Controls.Add(this.but_rpt_note);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(810, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 84);
            this.flowLayoutPanel1.TabIndex = 80;
            // 
            // but_delt_note
            // 
            this.but_delt_note.BackColor = System.Drawing.Color.White;
            this.but_delt_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_delt_note.Font = new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_delt_note.Image = global::min.Properties.Resources.icons8_delete_2_28px;
            this.but_delt_note.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_delt_note.Location = new System.Drawing.Point(195, 7);
            this.but_delt_note.Margin = new System.Windows.Forms.Padding(7);
            this.but_delt_note.Name = "but_delt_note";
            this.but_delt_note.Size = new System.Drawing.Size(152, 29);
            this.but_delt_note.TabIndex = 2;
            this.but_delt_note.Text = "حذف ملاحظة";
            this.but_delt_note.UseVisualStyleBackColor = false;
            this.but_delt_note.Click += new System.EventHandler(this.but_delt_note_Click);
            // 
            // but_add_note
            // 
            this.but_add_note.BackColor = System.Drawing.Color.White;
            this.but_add_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_add_note.Font = new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add_note.Image = global::min.Properties.Resources.icons8_add_file_28px_1;
            this.but_add_note.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_add_note.Location = new System.Drawing.Point(29, 7);
            this.but_add_note.Margin = new System.Windows.Forms.Padding(7);
            this.but_add_note.Name = "but_add_note";
            this.but_add_note.Size = new System.Drawing.Size(152, 29);
            this.but_add_note.TabIndex = 1;
            this.but_add_note.Text = "أضافة ملاحظة";
            this.but_add_note.UseVisualStyleBackColor = false;
            this.but_add_note.Click += new System.EventHandler(this.but_add_note_Click);
            // 
            // but_restert_note
            // 
            this.but_restert_note.BackColor = System.Drawing.Color.White;
            this.but_restert_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_restert_note.Font = new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_restert_note.Image = global::min.Properties.Resources.icons8_refresh_28px;
            this.but_restert_note.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_restert_note.Location = new System.Drawing.Point(195, 50);
            this.but_restert_note.Margin = new System.Windows.Forms.Padding(7);
            this.but_restert_note.Name = "but_restert_note";
            this.but_restert_note.Size = new System.Drawing.Size(152, 29);
            this.but_restert_note.TabIndex = 3;
            this.but_restert_note.Text = "إعادة التحميل";
            this.but_restert_note.UseVisualStyleBackColor = false;
            this.but_restert_note.Click += new System.EventHandler(this.but_restert_note_Click);
            // 
            // but_rpt_note
            // 
            this.but_rpt_note.BackColor = System.Drawing.Color.White;
            this.but_rpt_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_rpt_note.Font = new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_rpt_note.Image = global::min.Properties.Resources.icons8_purchase_order_28px;
            this.but_rpt_note.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_rpt_note.Location = new System.Drawing.Point(29, 50);
            this.but_rpt_note.Margin = new System.Windows.Forms.Padding(7);
            this.but_rpt_note.Name = "but_rpt_note";
            this.but_rpt_note.Size = new System.Drawing.Size(152, 29);
            this.but_rpt_note.TabIndex = 4;
            this.but_rpt_note.Text = "تقرير الملاحظات";
            this.but_rpt_note.UseVisualStyleBackColor = false;
            this.but_rpt_note.Click += new System.EventHandler(this.but_rpt_note_Click);
            // 
            // dg_note
            // 
            this.dg_note.BackgroundColor = System.Drawing.Color.White;
            this.dg_note.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_note.GridColor = System.Drawing.Color.White;
            this.dg_note.Location = new System.Drawing.Point(0, 84);
            this.dg_note.Name = "dg_note";
            this.dg_note.Size = new System.Drawing.Size(1164, 552);
            this.dg_note.TabIndex = 2;
            this.dg_note.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_note_CellDoubleClick);
            // 
            // notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 636);
            this.Controls.Add(this.dg_note);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Almarai Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "notes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الملاحظات";
            this.Load += new System.EventHandler(this.notes_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunaCirclePictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_note)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        internal Guna.UI.WinForms.GunaCirclePictureBox GunaCirclePictureBox1;
        public Guna.UI.WinForms.GunaTextBox txte_sersh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button but_delt_note;
        private System.Windows.Forms.Button but_add_note;
        private System.Windows.Forms.Button but_restert_note;
        private System.Windows.Forms.Button but_rpt_note;
        private System.Windows.Forms.DataGridView dg_note;
        public Guna.UI.WinForms.GunaDateTimePicker txt_date_2;
        public Guna.UI.WinForms.GunaDateTimePicker txt_date_1;
        internal Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        public Guna.UI.WinForms.GunaTextBox ser_qasem;
    }
}