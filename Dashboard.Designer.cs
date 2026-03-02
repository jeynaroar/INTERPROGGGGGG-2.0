namespace WinFormsApp36
{
    partial class Dashboard
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
            btnRegis = new Button();
            btnList = new Button();
            SuspendLayout();
            // 
            // btnRegis
            // 
            btnRegis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegis.Location = new Point(34, 127);
            btnRegis.Name = "btnRegis";
            btnRegis.Size = new Size(273, 73);
            btnRegis.TabIndex = 0;
            btnRegis.Text = "REGISTER STUDENT";
            btnRegis.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            btnList.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnList.Location = new Point(346, 127);
            btnList.Name = "btnList";
            btnList.Size = new Size(273, 73);
            btnList.TabIndex = 1;
            btnList.Text = "STUDENT LIST";
            btnList.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnList);
            Controls.Add(btnRegis);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegis;
        private Button btnList;
    }
}