namespace WformLab
{
    partial class mainhome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispayStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDepartementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDepartementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.departmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentToolStripMenuItem,
            this.dispayStudentToolStripMenuItem,
            this.editStudentToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newStudentToolStripMenuItem.Text = "new Student";
            this.newStudentToolStripMenuItem.Click += new System.EventHandler(this.newStudentToolStripMenuItem_Click);
            // 
            // dispayStudentToolStripMenuItem
            // 
            this.dispayStudentToolStripMenuItem.Name = "dispayStudentToolStripMenuItem";
            this.dispayStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dispayStudentToolStripMenuItem.Text = "Dispay Student";
            this.dispayStudentToolStripMenuItem.Click += new System.EventHandler(this.dispayStudentToolStripMenuItem_Click);
            // 
            // editStudentToolStripMenuItem
            // 
            this.editStudentToolStripMenuItem.Name = "editStudentToolStripMenuItem";
            this.editStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editStudentToolStripMenuItem.Text = "Edit Student";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDepartmentToolStripMenuItem,
            this.showDepartementToolStripMenuItem,
            this.editDepartementToolStripMenuItem});
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.departmentToolStripMenuItem.Text = "Department";
            // 
            // newDepartmentToolStripMenuItem
            // 
            this.newDepartmentToolStripMenuItem.Name = "newDepartmentToolStripMenuItem";
            this.newDepartmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newDepartmentToolStripMenuItem.Text = "New Department";
            // 
            // showDepartementToolStripMenuItem
            // 
            this.showDepartementToolStripMenuItem.Name = "showDepartementToolStripMenuItem";
            this.showDepartementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showDepartementToolStripMenuItem.Text = "Show Departement";
            // 
            // editDepartementToolStripMenuItem
            // 
            this.editDepartementToolStripMenuItem.Name = "editDepartementToolStripMenuItem";
            this.editDepartementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editDepartementToolStripMenuItem.Text = "Edit Departement";
            // 
            // mainhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainhome";
            this.Text = "mainhome";
            this.Load += new System.EventHandler(this.mainhome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispayStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDepartementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDepartementToolStripMenuItem;
    }
}