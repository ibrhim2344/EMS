namespace min
{
    partial class add_nots
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_nots));
            this.top_pnl = new Guna.UI.WinForms.GunaPanel();
            this.but_mins = new Guna.UI.WinForms.GunaImageButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.but_clos = new Guna.UI.WinForms.GunaImageButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.but_save = new System.Windows.Forms.Button();
            this.but_edit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel15 = new Guna.UI.WinForms.GunaLabel();
            this.com_qasm = new Guna.UI.WinForms.GunaComboBox();
            this.tixte_note = new System.Windows.Forms.TextBox();
            this.txt_date = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.id_note = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.name_emp = new Guna.UI.WinForms.GunaTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.top_pnl.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_pnl
            // 
            this.top_pnl.Controls.Add(this.but_mins);
            this.top_pnl.Controls.Add(this.flowLayoutPanel2);
            this.top_pnl.Controls.Add(this.but_clos);
            this.top_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_pnl.Location = new System.Drawing.Point(0, 0);
            this.top_pnl.Name = "top_pnl";
            this.top_pnl.Size = new System.Drawing.Size(791, 35);
            this.top_pnl.TabIndex = 3;
            // 
            // but_mins
            // 
            this.but_mins.DialogResult = System.Windows.Forms.DialogResult.None;
            this.but_mins.Image = global::min.Properties.Resources.icons8_minus_math_24px;
            this.but_mins.ImageSize = new System.Drawing.Size(24, 24);
            this.but_mins.Location = new System.Drawing.Point(41, 1);
            this.but_mins.Name = "but_mins";
            this.but_mins.OnHoverImage = null;
            this.but_mins.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.but_mins.Size = new System.Drawing.Size(34, 31);
            this.but_mins.TabIndex = 2;
            this.but_mins.Click += new System.EventHandler(this.but_mins_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.gunaLabel7);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(417, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(374, 35);
            this.flowLayoutPanel2.TabIndex = 0;
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
            this.gunaLabel7.Text = "أضافة ملاحظة";
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
            this.but_clos.Size = new System.Drawing.Size(34, 31);
            this.but_clos.TabIndex = 1;
            this.but_clos.Click += new System.EventHandler(this.but_clos_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.but_save);
            this.flowLayoutPanel1.Controls.Add(this.but_edit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 412);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(791, 62);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // but_save
            // 
            this.but_save.BackColor = System.Drawing.Color.White;
            this.but_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_save.Font = new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_save.Image = global::min.Properties.Resources.icons8_save_close_34px;
            this.but_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_save.Location = new System.Drawing.Point(440, 4);
            this.but_save.Margin = new System.Windows.Forms.Padding(180, 4, 5, 7);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(171, 51);
            this.but_save.TabIndex = 6;
            this.but_save.Text = "حفظ";
            this.but_save.UseVisualStyleBackColor = false;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_edit
            // 
            this.but_edit.BackColor = System.Drawing.Color.White;
            this.but_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_edit.Font = new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_edit.Image = global::min.Properties.Resources.icons8_save_as_34px;
            this.but_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_edit.Location = new System.Drawing.Point(29, 4);
            this.but_edit.Margin = new System.Windows.Forms.Padding(235, 4, 25, 7);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(171, 51);
            this.but_edit.TabIndex = 5;
            this.but_edit.Text = "حفظ التعديل";
            this.but_edit.UseVisualStyleBackColor = false;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.gunaLabel14);
            this.groupBox1.Controls.Add(this.gunaLabel15);
            this.groupBox1.Controls.Add(this.com_qasm);
            this.groupBox1.Controls.Add(this.tixte_note);
            this.groupBox1.Controls.Add(this.txt_date);
            this.groupBox1.Controls.Add(this.gunaLabel3);
            this.groupBox1.Controls.Add(this.gunaLabel4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.gunaLabel8);
            this.groupBox1.Controls.Add(this.gunaLabel10);
            this.groupBox1.Controls.Add(this.id_note);
            this.groupBox1.Controls.Add(this.gunaLabel5);
            this.groupBox1.Controls.Add(this.gunaLabel6);
            this.groupBox1.Controls.Add(this.gunaLabel2);
            this.groupBox1.Controls.Add(this.gunaLabel1);
            this.groupBox1.Controls.Add(this.name_emp);
            this.groupBox1.Font = new System.Drawing.Font("Cairo Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 375);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات ";
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Almarai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel14.ForeColor = System.Drawing.Color.DarkRed;
            this.gunaLabel14.Location = new System.Drawing.Point(183, 103);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(20, 30);
            this.gunaLabel14.TabIndex = 38;
            this.gunaLabel14.Text = "*";
            // 
            // gunaLabel15
            // 
            this.gunaLabel15.AutoSize = true;
            this.gunaLabel15.Font = new System.Drawing.Font("Almarai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel15.Location = new System.Drawing.Point(200, 103);
            this.gunaLabel15.Name = "gunaLabel15";
            this.gunaLabel15.Size = new System.Drawing.Size(121, 30);
            this.gunaLabel15.TabIndex = 37;
            this.gunaLabel15.Text = "القسم/الوحدة";
            // 
            // com_qasm
            // 
            this.com_qasm.BackColor = System.Drawing.Color.Transparent;
            this.com_qasm.BaseColor = System.Drawing.Color.White;
            this.com_qasm.BorderColor = System.Drawing.Color.Black;
            this.com_qasm.BorderSize = 1;
            this.com_qasm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.com_qasm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_qasm.FocusedColor = System.Drawing.Color.Empty;
            this.com_qasm.Font = new System.Drawing.Font("Cairo", 12F);
            this.com_qasm.ForeColor = System.Drawing.Color.Black;
            this.com_qasm.FormattingEnabled = true;
            this.com_qasm.Location = new System.Drawing.Point(34, 136);
            this.com_qasm.Name = "com_qasm";
            this.com_qasm.OnHoverItemBaseColor = System.Drawing.Color.Transparent;
            this.com_qasm.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.com_qasm.Radius = 4;
            this.com_qasm.Size = new System.Drawing.Size(287, 38);
            this.com_qasm.TabIndex = 36;
            this.com_qasm.SelectedIndexChanged += new System.EventHandler(this.com_qasm_SelectedIndexChanged);
            // 
            // tixte_note
            // 
            this.tixte_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tixte_note.Location = new System.Drawing.Point(336, 153);
            this.tixte_note.MaxLength = 50;
            this.tixte_note.Multiline = true;
            this.tixte_note.Name = "tixte_note";
            this.tixte_note.Size = new System.Drawing.Size(442, 216);
            this.tixte_note.TabIndex = 31;
            // 
            // txt_date
            // 
            this.txt_date.BackColor = System.Drawing.Color.Transparent;
            this.txt_date.BaseColor = System.Drawing.Color.White;
            this.txt_date.BorderColor = System.Drawing.Color.Black;
            this.txt_date.BorderSize = 1;
            this.txt_date.CustomFormat = null;
            this.txt_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_date.FocusedColor = System.Drawing.Color.Black;
            this.txt_date.Font = new System.Drawing.Font("Almarai Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.ForeColor = System.Drawing.Color.Black;
            this.txt_date.Location = new System.Drawing.Point(41, 57);
            this.txt_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_date.Name = "txt_date";
            this.txt_date.OnHoverBaseColor = System.Drawing.Color.White;
            this.txt_date.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txt_date.OnHoverForeColor = System.Drawing.Color.Black;
            this.txt_date.OnPressedColor = System.Drawing.Color.Black;
            this.txt_date.Radius = 3;
            this.txt_date.Size = new System.Drawing.Size(287, 42);
            this.txt_date.TabIndex = 25;
            this.txt_date.Text = "Thursday, November 7, 2024";
            this.txt_date.Value = new System.DateTime(2024, 11, 7, 17, 18, 32, 396);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Almarai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.DarkRed;
            this.gunaLabel3.Location = new System.Drawing.Point(245, 18);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(20, 30);
            this.gunaLabel3.TabIndex = 24;
            this.gunaLabel3.Text = "*";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Almarai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(262, 18);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(59, 30);
            this.gunaLabel4.TabIndex = 23;
            this.gunaLabel4.Text = "التاريخ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::min.Properties.Resources.icons8_plus_math_filled_24px;
            this.button1.Location = new System.Drawing.Point(662, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 27);
            this.button1.TabIndex = 21;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Almarai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.DarkRed;
            this.gunaLabel8.Location = new System.Drawing.Point(661, 18);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(20, 30);
            this.gunaLabel8.TabIndex = 12;
            this.gunaLabel8.Text = "*";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Almarai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.Location = new System.Drawing.Point(678, 18);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(117, 30);
            this.gunaLabel10.TabIndex = 11;
            this.gunaLabel10.Text = "رقم الملاحظة";
            // 
            // id_note
            // 
            this.id_note.BackColor = System.Drawing.Color.Transparent;
            this.id_note.BaseColor = System.Drawing.Color.White;
            this.id_note.BorderColor = System.Drawing.Color.Black;
            this.id_note.BorderSize = 1;
            this.id_note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_note.FocusedBaseColor = System.Drawing.Color.White;
            this.id_note.FocusedBorderColor = System.Drawing.Color.Black;
            this.id_note.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.id_note.Font = new System.Drawing.Font("Almarai", 8.249999F);
            this.id_note.Location = new System.Drawing.Point(697, 65);
            this.id_note.Name = "id_note";
            this.id_note.PasswordChar = '\0';
            this.id_note.Radius = 4;
            this.id_note.SelectedText = "";
            this.id_note.Size = new System.Drawing.Size(81, 34);
            this.id_note.TabIndex = 10;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Almarai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.DarkRed;
            this.gunaLabel5.Location = new System.Drawing.Point(679, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(20, 30);
            this.gunaLabel5.TabIndex = 9;
            this.gunaLabel5.Text = "*";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Almarai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(695, 120);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(84, 30);
            this.gunaLabel6.TabIndex = 8;
            this.gunaLabel6.Text = "الملاحظة";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Almarai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.gunaLabel2.Location = new System.Drawing.Point(530, 18);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(20, 30);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "*";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Almarai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(547, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(104, 30);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "الاسم كامل";
            // 
            // name_emp
            // 
            this.name_emp.BackColor = System.Drawing.Color.Transparent;
            this.name_emp.BaseColor = System.Drawing.Color.White;
            this.name_emp.BorderColor = System.Drawing.Color.Black;
            this.name_emp.BorderSize = 1;
            this.name_emp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_emp.FocusedBaseColor = System.Drawing.Color.White;
            this.name_emp.FocusedBorderColor = System.Drawing.Color.Black;
            this.name_emp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.name_emp.Font = new System.Drawing.Font("Cairo", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_emp.Location = new System.Drawing.Point(359, 65);
            this.name_emp.Name = "name_emp";
            this.name_emp.PasswordChar = '\0';
            this.name_emp.Radius = 4;
            this.name_emp.SelectedText = "";
            this.name_emp.Size = new System.Drawing.Size(287, 34);
            this.name_emp.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.top_pnl;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.flowLayoutPanel2;
            this.bunifuDragControl2.Vertical = true;
            // 
            // add_nots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.top_pnl);
            this.Font = new System.Drawing.Font("Almarai Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "add_nots";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أضافة ملاحظة";
            this.Load += new System.EventHandler(this.add_nots_Load);
            this.top_pnl.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel top_pnl;
        private Guna.UI.WinForms.GunaImageButton but_mins;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        internal Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaImageButton but_clos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button button1;
        public Guna.UI.WinForms.GunaTextBox id_note;
        public Guna.UI.WinForms.GunaTextBox name_emp;
        public Guna.UI.WinForms.GunaDateTimePicker txt_date;
        public System.Windows.Forms.Button but_save;
        public System.Windows.Forms.Button but_edit;
        public System.Windows.Forms.TextBox tixte_note;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        public Guna.UI.WinForms.GunaLabel gunaLabel14;
        public Guna.UI.WinForms.GunaLabel gunaLabel15;
        public Guna.UI.WinForms.GunaComboBox com_qasm;
    }
}