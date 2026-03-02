namespace WinFormsApp36
{
    partial class RegisterStudent
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSaveRecord = new Button();
            cbCourse = new ComboBox();
            cbSection = new ComboBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 36);
            label1.Name = "label1";
            label1.Size = new Size(273, 25);
            label1.TabIndex = 0;
            label1.Text = "Register Student Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 98);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 1;
            label2.Text = "First name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 146);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 2;
            label3.Text = "Last name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 196);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 3;
            label4.Text = "Course:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 238);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 4;
            label5.Text = "Section:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(80, 280);
            label6.Name = "label6";
            label6.Size = new Size(52, 25);
            label6.TabIndex = 5;
            label6.Text = "Age:";
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveRecord.Location = new Point(158, 330);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(325, 43);
            btnSaveRecord.TabIndex = 6;
            btnSaveRecord.Text = "SAVE RECORD";
            btnSaveRecord.UseVisualStyleBackColor = true;
            // 
            // cbCourse
            // 
            cbCourse.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(158, 196);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(325, 33);
            cbCourse.TabIndex = 7;
            // 
            // cbSection
            // 
            cbSection.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(158, 238);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(325, 33);
            cbSection.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(158, 103);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(325, 33);
            txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(158, 146);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(325, 33);
            txtLastName.TabIndex = 10;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(158, 280);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(325, 33);
            txtAge.TabIndex = 11;
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(cbSection);
            Controls.Add(cbCourse);
            Controls.Add(btnSaveRecord);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterStudent";
            Text = "RegisterStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSaveRecord;
        private ComboBox cbCourse;
        private ComboBox cbSection;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAge;
    }
}