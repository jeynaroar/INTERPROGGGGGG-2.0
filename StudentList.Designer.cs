namespace WinFormsApp36
{
    partial class StudentList
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
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            txtAge = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            cbSection = new ComboBox();
            cbCourse = new ComboBox();
            btnSaveRecord = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            btnDeleteRecord = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 33);
            label1.Name = "label1";
            label1.Size = new Size(221, 25);
            label1.TabIndex = 0;
            label1.Text = "STUDENT MASTER LIST";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(35, 77);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(269, 33);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(329, 77);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 33);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(613, 77);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 33);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(468, 326);
            dataGridView1.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(770, 372);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(325, 33);
            txtAge.TabIndex = 22;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(770, 209);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(325, 33);
            txtLastName.TabIndex = 21;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(770, 147);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(325, 33);
            txtFirstName.TabIndex = 20;
            // 
            // cbSection
            // 
            cbSection.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(770, 323);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(325, 33);
            cbSection.TabIndex = 19;
            // 
            // cbCourse
            // 
            cbCourse.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(770, 270);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(325, 33);
            cbCourse.TabIndex = 18;
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveRecord.Location = new Point(770, 430);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(325, 43);
            btnSaveRecord.TabIndex = 17;
            btnSaveRecord.Text = "SAVE RECORD";
            btnSaveRecord.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(694, 375);
            label6.Name = "label6";
            label6.Size = new Size(52, 25);
            label6.TabIndex = 16;
            label6.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(667, 331);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 15;
            label5.Text = "Section:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(667, 278);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 14;
            label4.Text = "Course:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(640, 217);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 13;
            label7.Text = "Last name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(640, 155);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 12;
            label8.Text = "First name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(770, 77);
            label2.Name = "label2";
            label2.Size = new Size(314, 25);
            label2.TabIndex = 23;
            label2.Text = "UPDATE STUDENT INFORMATION";
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteRecord.Location = new Point(770, 488);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(325, 43);
            btnDeleteRecord.TabIndex = 24;
            btnDeleteRecord.Text = "DELETE RECORD";
            btnDeleteRecord.UseVisualStyleBackColor = true;
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 612);
            Controls.Add(btnDeleteRecord);
            Controls.Add(label2);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(cbSection);
            Controls.Add(cbCourse);
            Controls.Add(btnSaveRecord);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "StudentList";
            Text = "StudentList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private TextBox txtAge;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private ComboBox cbSection;
        private ComboBox cbCourse;
        private Button btnSaveRecord;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label2;
        private Button btnDeleteRecord;
    }
}