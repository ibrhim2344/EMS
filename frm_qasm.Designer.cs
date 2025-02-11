namespace min
{
    partial class frm_qasm
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
            System.Windows.Forms.Label neLabel;
            System.Windows.Forms.Label qasmLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.neTextBox = new System.Windows.Forms.TextBox();
            this.qasmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMSDataSet = new min.EMSDataSet();
            this.qasmTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.qasmTableAdapter = new min.EMSDataSetTableAdapters.qasmTableAdapter();
            this.tableAdapterManager = new min.EMSDataSetTableAdapters.TableAdapterManager();
            this.but_add_emplyee = new System.Windows.Forms.Button();
            this.but_delt = new System.Windows.Forms.Button();
            this.but_restert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            neLabel = new System.Windows.Forms.Label();
            qasmLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qasmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // neLabel
            // 
            neLabel.AutoSize = true;
            neLabel.Font = new System.Drawing.Font("Cairo SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            neLabel.Location = new System.Drawing.Point(328, 29);
            neLabel.Name = "neLabel";
            neLabel.Size = new System.Drawing.Size(35, 24);
            neLabel.TabIndex = 3;
            neLabel.Text = "رقم ";
            // 
            // qasmLabel
            // 
            qasmLabel.AutoSize = true;
            qasmLabel.Font = new System.Drawing.Font("Cairo SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            qasmLabel.Location = new System.Drawing.Point(328, 67);
            qasmLabel.Name = "qasmLabel";
            qasmLabel.Size = new System.Drawing.Size(96, 24);
            qasmLabel.TabIndex = 5;
            qasmLabel.Text = "القسم و الوحدة";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.but_add_emplyee);
            this.panel1.Controls.Add(this.but_delt);
            this.panel1.Controls.Add(this.but_restert);
            this.panel1.Controls.Add(neLabel);
            this.panel1.Controls.Add(this.neTextBox);
            this.panel1.Controls.Add(qasmLabel);
            this.panel1.Controls.Add(this.qasmTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 102);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // neTextBox
            // 
            this.neTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qasmBindingSource, "ne", true));
            this.neTextBox.Font = new System.Drawing.Font("Cairo SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neTextBox.Location = new System.Drawing.Point(140, 26);
            this.neTextBox.Name = "neTextBox";
            this.neTextBox.Size = new System.Drawing.Size(182, 32);
            this.neTextBox.TabIndex = 4;
            // 
            // qasmBindingSource
            // 
            this.qasmBindingSource.DataMember = "qasm";
            this.qasmBindingSource.DataSource = this.eMSDataSet;
            // 
            // eMSDataSet
            // 
            this.eMSDataSet.DataSetName = "EMSDataSet";
            this.eMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qasmTextBox
            // 
            this.qasmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qasmBindingSource, "qasm", true));
            this.qasmTextBox.Font = new System.Drawing.Font("Cairo SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.qasmTextBox.Location = new System.Drawing.Point(14, 64);
            this.qasmTextBox.Name = "qasmTextBox";
            this.qasmTextBox.Size = new System.Drawing.Size(308, 32);
            this.qasmTextBox.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Dgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 417);
            this.panel2.TabIndex = 1;
            // 
            // qasmTableAdapter
            // 
            this.qasmTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employees1TableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.notesTableAdapter = null;
            this.tableAdapterManager.qasmTableAdapter = this.qasmTableAdapter;
            this.tableAdapterManager.ttgotoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = min.EMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // but_add_emplyee
            // 
            this.but_add_emplyee.BackColor = System.Drawing.Color.White;
            this.but_add_emplyee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_add_emplyee.Font = new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add_emplyee.Image = global::min.Properties.Resources.icons8_plus_math_filled_24px;
            this.but_add_emplyee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_add_emplyee.Location = new System.Drawing.Point(587, 16);
            this.but_add_emplyee.Margin = new System.Windows.Forms.Padding(7);
            this.but_add_emplyee.Name = "but_add_emplyee";
            this.but_add_emplyee.Size = new System.Drawing.Size(144, 29);
            this.but_add_emplyee.TabIndex = 7;
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
            this.but_delt.Location = new System.Drawing.Point(429, 16);
            this.but_delt.Margin = new System.Windows.Forms.Padding(7);
            this.but_delt.Name = "but_delt";
            this.but_delt.Size = new System.Drawing.Size(144, 29);
            this.but_delt.TabIndex = 10;
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
            this.but_restert.Location = new System.Drawing.Point(587, 59);
            this.but_restert.Margin = new System.Windows.Forms.Padding(7);
            this.but_restert.Name = "but_restert";
            this.but_restert.Size = new System.Drawing.Size(144, 29);
            this.but_restert.TabIndex = 8;
            this.but_restert.Text = "إعادة التحميل";
            this.but_restert.UseVisualStyleBackColor = false;
            this.but_restert.Click += new System.EventHandler(this.but_restert_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::min.Properties.Resources.icons8_plus_math_filled_24px;
            this.button1.Location = new System.Drawing.Point(105, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 27);
            this.button1.TabIndex = 22;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dgv
            // 
            this.Dgv.BackgroundColor = System.Drawing.Color.White;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv.Location = new System.Drawing.Point(0, 0);
            this.Dgv.Name = "Dgv";
            this.Dgv.Size = new System.Drawing.Size(740, 417);
            this.Dgv.TabIndex = 0;
            // 
            // frm_qasm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "frm_qasm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "القسم الوحدة";
            this.Load += new System.EventHandler(this.frm_qasm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qasmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private EMSDataSet eMSDataSet;
        private System.Windows.Forms.BindingSource qasmBindingSource;
        private EMSDataSetTableAdapters.qasmTableAdapter qasmTableAdapter;
        private EMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox neTextBox;
        private System.Windows.Forms.TextBox qasmTextBox;
        private System.Windows.Forms.Button but_add_emplyee;
        private System.Windows.Forms.Button but_delt;
        private System.Windows.Forms.Button but_restert;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Dgv;

    }
}