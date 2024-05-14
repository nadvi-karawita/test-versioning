namespace Patient_BulkImport_Formatter
{
    partial class ImportFormatter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportFormatter));
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            label1 = new Label();
            recheckBtn = new Control.RoundedButton();
            pictureBox1 = new PictureBox();
            clrBtn = new Control.RoundedButton();
            writeBtn = new Control.RoundedButton();
            readBtn = new Control.RoundedButton();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            eTPPatientBindingSource = new BindingSource(components);
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eTPPatientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(242, 243, 245);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(recheckBtn);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(clrBtn);
            splitContainer1.Panel1.Controls.Add(writeBtn);
            splitContainer1.Panel1.Controls.Add(readBtn);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(1203, 710);
            splitContainer1.SplitterDistance = 258;
            splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 243, 245);
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(10, 325);
            label2.Name = "label2";
            label2.Size = new Size(160, 45);
            label2.TabIndex = 6;
            label2.Text = "© Copyright 2000-2023 \r\nStreamline Solutions Pty Ltd.\r\nALL RIGHTS RESERVED";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 243, 245);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(66, 167, 247);
            label1.Location = new Point(10, 266);
            label1.Name = "label1";
            label1.Size = new Size(184, 30);
            label1.TabIndex = 5;
            label1.Text = "Jessie McPherson";
            // 
            // recheckBtn
            // 
            recheckBtn.BackColor = SystemColors.ControlDarkDark;
            recheckBtn.BackgroundColor = SystemColors.ControlDarkDark;
            recheckBtn.BackgroundImageLayout = ImageLayout.Zoom;
            recheckBtn.BorderColor = SystemColors.ControlDarkDark;
            recheckBtn.BorderRadius = 10;
            recheckBtn.BorderSize = 2;
            recheckBtn.FlatAppearance.BorderSize = 0;
            recheckBtn.FlatStyle = FlatStyle.Flat;
            recheckBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            recheckBtn.ForeColor = Color.White;
            recheckBtn.Location = new Point(12, 658);
            recheckBtn.Name = "recheckBtn";
            recheckBtn.Size = new Size(110, 40);
            recheckBtn.TabIndex = 4;
            recheckBtn.Text = "Validate";
            recheckBtn.TextColor = Color.White;
            toolTip2.SetToolTip(recheckBtn, "Re-check Data");
            recheckBtn.UseVisualStyleBackColor = false;
            recheckBtn.Click += recheckBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1715eve_png_clear;
            pictureBox1.Location = new Point(10, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // clrBtn
            // 
            clrBtn.BackColor = Color.FromArgb(242, 243, 245);
            clrBtn.BackgroundColor = Color.FromArgb(242, 243, 245);
            clrBtn.BackgroundImage = (Image)resources.GetObject("clrBtn.BackgroundImage");
            clrBtn.BackgroundImageLayout = ImageLayout.Zoom;
            clrBtn.BorderColor = Color.Black;
            clrBtn.BorderRadius = 10;
            clrBtn.BorderSize = 2;
            clrBtn.FlatAppearance.BorderSize = 0;
            clrBtn.FlatStyle = FlatStyle.Flat;
            clrBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clrBtn.ForeColor = Color.White;
            clrBtn.Location = new Point(128, 658);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(42, 40);
            clrBtn.TabIndex = 2;
            clrBtn.TextColor = Color.White;
            toolTip2.SetToolTip(clrBtn, "Clear Existing Data");
            clrBtn.UseCompatibleTextRendering = true;
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // writeBtn
            // 
            writeBtn.BackColor = Color.FromArgb(66, 167, 247);
            writeBtn.BackgroundColor = Color.FromArgb(66, 167, 247);
            writeBtn.BorderColor = Color.FromArgb(66, 167, 247);
            writeBtn.BorderRadius = 10;
            writeBtn.BorderSize = 2;
            writeBtn.FlatAppearance.BorderSize = 0;
            writeBtn.FlatStyle = FlatStyle.Flat;
            writeBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            writeBtn.ForeColor = Color.White;
            writeBtn.Location = new Point(12, 611);
            writeBtn.Name = "writeBtn";
            writeBtn.Size = new Size(158, 41);
            writeBtn.TabIndex = 1;
            writeBtn.Text = "Save File";
            writeBtn.TextColor = Color.White;
            toolTip2.SetToolTip(writeBtn, "Write To CSV File");
            writeBtn.UseVisualStyleBackColor = false;
            writeBtn.Click += writeBtn_Click;
            // 
            // readBtn
            // 
            readBtn.BackColor = Color.FromArgb(66, 167, 247);
            readBtn.BackgroundColor = Color.FromArgb(66, 167, 247);
            readBtn.BorderColor = Color.FromArgb(66, 167, 247);
            readBtn.BorderRadius = 10;
            readBtn.BorderSize = 2;
            readBtn.FlatAppearance.BorderSize = 0;
            readBtn.FlatStyle = FlatStyle.Flat;
            readBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            readBtn.ForeColor = Color.White;
            readBtn.Location = new Point(12, 562);
            readBtn.Name = "readBtn";
            readBtn.Size = new Size(158, 43);
            readBtn.TabIndex = 0;
            readBtn.Text = "Open File";
            readBtn.TextColor = Color.White;
            toolTip1.SetToolTip(readBtn, "Patient UR,Given Name,Surname, Due Date,Email Address,Address,Phone No.");
            readBtn.UseVisualStyleBackColor = false;
            readBtn.Click += readBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(242, 243, 245);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dataGridView1.DataSource = eTPPatientBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(941, 710);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "URNumber";
            dataGridViewTextBoxColumn1.HeaderText = "URNumber";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 91;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "FamilyName";
            dataGridViewTextBoxColumn2.HeaderText = "FamilyName";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 99;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 86;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "DateOfBirth";
            dataGridViewTextBoxColumn4.HeaderText = "DateOfBirth";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 94;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "ExpectedDateOfDelivery";
            dataGridViewTextBoxColumn5.HeaderText = "ExpectedDateOfDelivery";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 159;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "EmailAddress";
            dataGridViewTextBoxColumn6.HeaderText = "EmailAddress";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 103;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "SiteID";
            dataGridViewTextBoxColumn7.HeaderText = "SiteID";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 62;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "ActivationCode";
            dataGridViewTextBoxColumn8.HeaderText = "ActivationCode";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 114;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "MobilePhone";
            dataGridViewTextBoxColumn9.HeaderText = "MobilePhone";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 103;
            // 
            // eTPPatientBindingSource
            // 
            eTPPatientBindingSource.DataSource = typeof(Models.ETPPatient);
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 0;
            toolTip1.BackColor = SystemColors.ActiveCaptionText;
            toolTip1.ForeColor = SystemColors.ActiveBorder;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 0;
            toolTip1.ShowAlways = true;
            toolTip1.StripAmpersands = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "File must be in the following format:";
            // 
            // toolTip2
            // 
            toolTip2.AutoPopDelay = 0;
            toolTip2.BackColor = SystemColors.ActiveCaptionText;
            toolTip2.ForeColor = SystemColors.ActiveBorder;
            toolTip2.InitialDelay = 500;
            toolTip2.ReshowDelay = 0;
            toolTip2.ShowAlways = true;
            toolTip2.StripAmpersands = true;
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = "Tip:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(242, 243, 245);
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(66, 167, 247);
            label3.Location = new Point(10, 296);
            label3.Name = "label3";
            label3.Size = new Size(210, 21);
            label3.TabIndex = 7;
            label3.Text = "Import File Generation Tool";
            // 
            // ImportFormatter
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(242, 243, 245);
            ClientSize = new Size(1203, 710);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ImportFormatter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Import File Generation Tool";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eTPPatientBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn uRNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn familyNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expectedDateOfDeliveryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn siteIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn activationCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobilePhoneDataGridViewTextBoxColumn;
        private Control.RoundedButton readBtn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private BindingSource eTPPatientBindingSource;
        private Control.RoundedButton clrBtn;
        private Control.RoundedButton writeBtn;
        private PictureBox pictureBox1;
        public ToolTip toolTip1;
        private Control.RoundedButton recheckBtn;
        private ToolTip toolTip2;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}