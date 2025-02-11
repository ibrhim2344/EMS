namespace min
{
    partial class mine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mine));
            this.top_pnl = new Guna.UI.WinForms.GunaPanel();
            this.but_mins = new Guna.UI.WinForms.GunaImageButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.GunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.but_clos = new Guna.UI.WinForms.GunaImageButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.but_home = new System.Windows.Forms.Button();
            this.but_em = new System.Windows.Forms.Button();
            this.but_go_back = new System.Windows.Forms.Button();
            this.but_note = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.but_Backup = new System.Windows.Forms.Button();
            this.but_around = new System.Windows.Forms.Button();
            this.pnl_cintr = new Guna.UI.WinForms.GunaPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.top_pnl.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.top_pnl.Size = new System.Drawing.Size(1229, 35);
            this.top_pnl.TabIndex = 0;
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
            this.flowLayoutPanel2.Controls.Add(this.GunaLabel2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(855, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(374, 35);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // GunaLabel2
            // 
            this.GunaLabel2.AutoSize = true;
            this.GunaLabel2.Font = new System.Drawing.Font("Almarai", 9.749999F);
            this.GunaLabel2.Location = new System.Drawing.Point(76, 7);
            this.GunaLabel2.Margin = new System.Windows.Forms.Padding(7);
            this.GunaLabel2.Name = "GunaLabel2";
            this.GunaLabel2.Size = new System.Drawing.Size(291, 20);
            this.GunaLabel2.TabIndex = 6;
            this.GunaLabel2.Text = "مكتب الشؤون المحلية مدينة ترهونة التفتيش والمتابعة";
            this.GunaLabel2.Click += new System.EventHandler(this.GunaLabel2_Click);
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
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.but_home);
            this.flowLayoutPanel1.Controls.Add(this.but_em);
            this.flowLayoutPanel1.Controls.Add(this.but_go_back);
            this.flowLayoutPanel1.Controls.Add(this.but_note);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.but_Backup);
            this.flowLayoutPanel1.Controls.Add(this.but_around);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 491);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1229, 54);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // but_home
            // 
            this.but_home.BackColor = System.Drawing.Color.White;
            this.but_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_home.Font = new System.Drawing.Font("Almarai Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_home.Image = global::min.Properties.Resources.icons8_hangar_32px;
            this.but_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_home.Location = new System.Drawing.Point(1088, 7);
            this.but_home.Margin = new System.Windows.Forms.Padding(7);
            this.but_home.Name = "but_home";
            this.but_home.Size = new System.Drawing.Size(134, 39);
            this.but_home.TabIndex = 0;
            this.but_home.Text = "الرئيسة";
            this.but_home.UseVisualStyleBackColor = false;
            this.but_home.Click += new System.EventHandler(this.but_home_Click);
            // 
            // but_em
            // 
            this.but_em.BackColor = System.Drawing.Color.White;
            this.but_em.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_em.Font = new System.Drawing.Font("Almarai Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_em.Image = global::min.Properties.Resources.icons8_groups_filled_24px;
            this.but_em.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_em.Location = new System.Drawing.Point(940, 7);
            this.but_em.Margin = new System.Windows.Forms.Padding(7);
            this.but_em.Name = "but_em";
            this.but_em.Size = new System.Drawing.Size(134, 39);
            this.but_em.TabIndex = 1;
            this.but_em.Text = "الموظفين";
            this.but_em.UseVisualStyleBackColor = false;
            this.but_em.Click += new System.EventHandler(this.but_em_Click);
            // 
            // but_go_back
            // 
            this.but_go_back.BackColor = System.Drawing.Color.White;
            this.but_go_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_go_back.Font = new System.Drawing.Font("Almarai Light", 12F);
            this.but_go_back.Image = global::min.Properties.Resources.icons8_multiple_inputs_32px;
            this.but_go_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_go_back.Location = new System.Drawing.Point(792, 7);
            this.but_go_back.Margin = new System.Windows.Forms.Padding(7);
            this.but_go_back.Name = "but_go_back";
            this.but_go_back.Size = new System.Drawing.Size(134, 39);
            this.but_go_back.TabIndex = 2;
            this.but_go_back.Text = "الاجازة والغياب";
            this.but_go_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_go_back.UseVisualStyleBackColor = false;
            this.but_go_back.Click += new System.EventHandler(this.but_go_back_Click);
            // 
            // but_note
            // 
            this.but_note.BackColor = System.Drawing.Color.White;
            this.but_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_note.Font = new System.Drawing.Font("Almarai Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_note.Image = global::min.Properties.Resources.icons8_note_32px;
            this.but_note.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_note.Location = new System.Drawing.Point(644, 7);
            this.but_note.Margin = new System.Windows.Forms.Padding(7);
            this.but_note.Name = "but_note";
            this.but_note.Size = new System.Drawing.Size(134, 39);
            this.but_note.TabIndex = 3;
            this.but_note.Text = "الملاحظات";
            this.but_note.UseVisualStyleBackColor = false;
            this.but_note.Click += new System.EventHandler(this.but_note_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Almarai Light", 12F);
            this.button1.Image = global::min.Properties.Resources.icons8_google_forms_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(324, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "القسم /الوجدة";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_Backup
            // 
            this.but_Backup.BackColor = System.Drawing.Color.White;
            this.but_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Backup.Font = new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Backup.Image = global::min.Properties.Resources.icons8_data_backup_32px;
            this.but_Backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Backup.Location = new System.Drawing.Point(176, 7);
            this.but_Backup.Margin = new System.Windows.Forms.Padding(7);
            this.but_Backup.Name = "but_Backup";
            this.but_Backup.Size = new System.Drawing.Size(134, 39);
            this.but_Backup.TabIndex = 4;
            this.but_Backup.Text = "نسخة احتياطية";
            this.but_Backup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Backup.UseVisualStyleBackColor = false;
            this.but_Backup.Click += new System.EventHandler(this.but_Backup_Click);
            // 
            // but_around
            // 
            this.but_around.BackColor = System.Drawing.Color.White;
            this.but_around.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_around.Font = new System.Drawing.Font("Almarai Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_around.Image = global::min.Properties.Resources.icons8_info_32px;
            this.but_around.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_around.Location = new System.Drawing.Point(28, 7);
            this.but_around.Margin = new System.Windows.Forms.Padding(7);
            this.but_around.Name = "but_around";
            this.but_around.Size = new System.Drawing.Size(134, 39);
            this.but_around.TabIndex = 5;
            this.but_around.Text = "حول";
            this.but_around.UseVisualStyleBackColor = false;
            this.but_around.Click += new System.EventHandler(this.but_around_Click);
            // 
            // pnl_cintr
            // 
            this.pnl_cintr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_cintr.Location = new System.Drawing.Point(0, 35);
            this.pnl_cintr.Name = "pnl_cintr";
            this.pnl_cintr.Size = new System.Drawing.Size(1229, 456);
            this.pnl_cintr.TabIndex = 2;
            this.pnl_cintr.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_cintr_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Almarai Light", 12F);
            this.button2.Image = global::min.Properties.Resources.icons8_data_in_both_directions_32px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(472, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "الحضور والانصراف";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1229, 545);
            this.Controls.Add(this.pnl_cintr);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.top_pnl);
            this.Font = new System.Drawing.Font("Almarai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mine";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "نظام الموظفين";
            this.Load += new System.EventHandler(this.min_Load);
            this.top_pnl.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel top_pnl;
        private Guna.UI.WinForms.GunaImageButton but_mins;
        private Guna.UI.WinForms.GunaImageButton but_clos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button but_home;
        private System.Windows.Forms.Button but_em;
        private System.Windows.Forms.Button but_go_back;
        private System.Windows.Forms.Button but_note;
        private System.Windows.Forms.Button but_Backup;
        private System.Windows.Forms.Button but_around;
        private Guna.UI.WinForms.GunaPanel pnl_cintr;
        internal Guna.UI.WinForms.GunaLabel GunaLabel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

