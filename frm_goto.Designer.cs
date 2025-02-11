namespace min
{
    partial class frm_goto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_goto));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.ser_qasem = new Guna.UI.WinForms.GunaTextBox();
            this.txt_date_2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txt_date_1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.user_name = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dg_goto = new System.Windows.Forms.DataGridView();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.GunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.but_add_emplyee = new System.Windows.Forms.Button();
            this.but_delt = new System.Windows.Forms.Button();
            this.but_restert = new System.Windows.Forms.Button();
            this.but_rpt_goto = new System.Windows.Forms.Button();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_goto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Controls.Add(this.flowLayoutPanel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1174, 84);
            this.gunaPanel1.TabIndex = 1;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaCirclePictureBox2);
            this.gunaPanel2.Controls.Add(this.ser_qasem);
            this.gunaPanel2.Controls.Add(this.txt_date_2);
            this.gunaPanel2.Controls.Add(this.txt_date_1);
            this.gunaPanel2.Controls.Add(this.GunaCirclePictureBox1);
            this.gunaPanel2.Controls.Add(this.user_name);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel2.Location = new System.Drawing.Point(3, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(817, 84);
            this.gunaPanel2.TabIndex = 81;
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
            this.ser_qasem.Location = new System.Drawing.Point(577, 12);
            this.ser_qasem.Name = "ser_qasem";
            this.ser_qasem.PasswordChar = '\0';
            this.ser_qasem.Radius = 10;
            this.ser_qasem.SelectedText = "";
            this.ser_qasem.Size = new System.Drawing.Size(237, 43);
            this.ser_qasem.TabIndex = 86;
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
            this.txt_date_2.Location = new System.Drawing.Point(9, 42);
            this.txt_date_2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_date_2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_date_2.Name = "txt_date_2";
            this.txt_date_2.OnHoverBaseColor = System.Drawing.Color.White;
            this.txt_date_2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txt_date_2.OnHoverForeColor = System.Drawing.Color.Black;
            this.txt_date_2.OnPressedColor = System.Drawing.Color.Black;
            this.txt_date_2.Radius = 3;
            this.txt_date_2.Size = new System.Drawing.Size(222, 28);
            this.txt_date_2.TabIndex = 85;
            this.txt_date_2.Text = "2024 ,نوفمبر 07";
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
            this.txt_date_1.Location = new System.Drawing.Point(9, 8);
            this.txt_date_1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_date_1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_date_1.Name = "txt_date_1";
            this.txt_date_1.OnHoverBaseColor = System.Drawing.Color.White;
            this.txt_date_1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txt_date_1.OnHoverForeColor = System.Drawing.Color.Black;
            this.txt_date_1.OnPressedColor = System.Drawing.Color.Black;
            this.txt_date_1.Radius = 3;
            this.txt_date_1.Size = new System.Drawing.Size(222, 28);
            this.txt_date_1.TabIndex = 84;
            this.txt_date_1.Text = "2024 ,نوفمبر 07";
            this.txt_date_1.Value = new System.DateTime(2024, 11, 7, 17, 18, 32, 396);
            this.txt_date_1.Validated += new System.EventHandler(this.txt_date_1_Validated);
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.Color.Transparent;
            this.user_name.BaseColor = System.Drawing.Color.White;
            this.user_name.BorderColor = System.Drawing.Color.Black;
            this.user_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_name.FocusedBaseColor = System.Drawing.Color.White;
            this.user_name.FocusedBorderColor = System.Drawing.Color.Black;
            this.user_name.FocusedForeColor = System.Drawing.Color.Black;
            this.user_name.Font = new System.Drawing.Font("Cairo", 9.749999F);
            this.user_name.ForeColor = System.Drawing.Color.DarkRed;
            this.user_name.Location = new System.Drawing.Point(237, 12);
            this.user_name.Name = "user_name";
            this.user_name.PasswordChar = '\0';
            this.user_name.Radius = 10;
            this.user_name.SelectedText = "";
            this.user_name.Size = new System.Drawing.Size(332, 43);
            this.user_name.TabIndex = 80;
            this.user_name.TextChanged += new System.EventHandler(this.user_name_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.but_add_emplyee);
            this.flowLayoutPanel1.Controls.Add(this.but_delt);
            this.flowLayoutPanel1.Controls.Add(this.but_restert);
            this.flowLayoutPanel1.Controls.Add(this.but_rpt_goto);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(820, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 84);
            this.flowLayoutPanel1.TabIndex = 80;
            // 
            // dg_goto
            // 
            this.dg_goto.AllowUserToAddRows = false;
            this.dg_goto.AllowUserToDeleteRows = false;
            this.dg_goto.BackgroundColor = System.Drawing.Color.White;
            this.dg_goto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_goto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_goto.GridColor = System.Drawing.Color.White;
            this.dg_goto.Location = new System.Drawing.Point(0, 84);
            this.dg_goto.Name = "dg_goto";
            this.dg_goto.ReadOnly = true;
            this.dg_goto.Size = new System.Drawing.Size(1174, 467);
            this.dg_goto.TabIndex = 2;
            this.dg_goto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_goto_CellContentClick);
            this.dg_goto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_goto_CellDoubleClick);
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BackColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.Image = global::min.Properties.Resources.icons8_search_28px;
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(585, 20);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(28, 28);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaCirclePictureBox2.TabIndex = 87;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // GunaCirclePictureBox1
            // 
            this.GunaCirclePictureBox1.BackColor = System.Drawing.Color.White;
            this.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.GunaCirclePictureBox1.Image = global::min.Properties.Resources.icons8_search_28px;
            this.GunaCirclePictureBox1.Location = new System.Drawing.Point(245, 20);
            this.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1";
            this.GunaCirclePictureBox1.Size = new System.Drawing.Size(28, 28);
            this.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GunaCirclePictureBox1.TabIndex = 81;
            this.GunaCirclePictureBox1.TabStop = false;
            this.GunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // but_add_emplyee
            // 
            this.but_add_emplyee.BackColor = System.Drawing.Color.White;
            this.but_add_emplyee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_add_emplyee.Font = new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add_emplyee.Image = global::min.Properties.Resources.icons8_plus_math_filled_24px;
            this.but_add_emplyee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_add_emplyee.Location = new System.Drawing.Point(203, 7);
            this.but_add_emplyee.Margin = new System.Windows.Forms.Padding(7);
            this.but_add_emplyee.Name = "but_add_emplyee";
            this.but_add_emplyee.Size = new System.Drawing.Size(144, 29);
            this.but_add_emplyee.TabIndex = 1;
            this.but_add_emplyee.Text = "تسجيل ";
            this.but_add_emplyee.UseVisualStyleBackColor = false;
            this.but_add_emplyee.Click += new System.EventHandler(this.but_add_emplyee_Click);
            // 
            // but_delt
            // 
            this.but_delt.BackColor = System.Drawing.Color.White;
            this.but_delt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_delt.Font = new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_delt.Image = global::min.Properties.Resources.icons8_delete_2_28px;
            this.but_delt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_delt.Location = new System.Drawing.Point(45, 7);
            this.but_delt.Margin = new System.Windows.Forms.Padding(7);
            this.but_delt.Name = "but_delt";
            this.but_delt.Size = new System.Drawing.Size(144, 29);
            this.but_delt.TabIndex = 5;
            this.but_delt.Text = "حذف";
            this.but_delt.UseVisualStyleBackColor = false;
            this.but_delt.Click += new System.EventHandler(this.but_delt_Click);
            // 
            // but_restert
            // 
            this.but_restert.BackColor = System.Drawing.Color.White;
            this.but_restert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_restert.Font = new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_restert.Image = global::min.Properties.Resources.icons8_refresh_28px;
            this.but_restert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_restert.Location = new System.Drawing.Point(203, 50);
            this.but_restert.Margin = new System.Windows.Forms.Padding(7);
            this.but_restert.Name = "but_restert";
            this.but_restert.Size = new System.Drawing.Size(144, 29);
            this.but_restert.TabIndex = 3;
            this.but_restert.Text = "إعادة التحميل";
            this.but_restert.UseVisualStyleBackColor = false;
            this.but_restert.Click += new System.EventHandler(this.but_restert_Click);
            // 
            // but_rpt_goto
            // 
            this.but_rpt_goto.BackColor = System.Drawing.Color.White;
            this.but_rpt_goto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_rpt_goto.Font = new System.Drawing.Font("Almarai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_rpt_goto.Image = global::min.Properties.Resources.icons8_purchase_order_28px;
            this.but_rpt_goto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_rpt_goto.Location = new System.Drawing.Point(45, 50);
            this.but_rpt_goto.Margin = new System.Windows.Forms.Padding(7);
            this.but_rpt_goto.Name = "but_rpt_goto";
            this.but_rpt_goto.Size = new System.Drawing.Size(144, 29);
            this.but_rpt_goto.TabIndex = 4;
            this.but_rpt_goto.Text = "تقراير الغيابت و الاجازات";
            this.but_rpt_goto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_rpt_goto.UseVisualStyleBackColor = false;
            this.but_rpt_goto.Click += new System.EventHandler(this.but_rpt_goto_Click);
            // 
            // frm_goto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 551);
            this.Controls.Add(this.dg_goto);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Almarai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_goto";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الغيابت";
            this.Load += new System.EventHandler(this.frm_goto_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_goto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        internal Guna.UI.WinForms.GunaCirclePictureBox GunaCirclePictureBox1;
        public Guna.UI.WinForms.GunaTextBox user_name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button but_add_emplyee;
        private System.Windows.Forms.Button but_restert;
        private System.Windows.Forms.Button but_rpt_goto;
        private System.Windows.Forms.DataGridView dg_goto;
        public Guna.UI.WinForms.GunaDateTimePicker txt_date_2;
        public Guna.UI.WinForms.GunaDateTimePicker txt_date_1;
        private System.Windows.Forms.Button but_delt;
        internal Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        public Guna.UI.WinForms.GunaTextBox ser_qasem;
    }
}