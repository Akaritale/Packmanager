
namespace PackManager
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClientDirectory = new System.Windows.Forms.TextBox();
            this.txtPackDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.checkCythonize = new System.Windows.Forms.CheckBox();
            this.packfolderBrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.clientBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkAutoMove = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClientDirectory);
            this.groupBox1.Controls.Add(this.txtPackDirectory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directory Configuration";
            // 
            // txtClientDirectory
            // 
            this.txtClientDirectory.Location = new System.Drawing.Point(6, 102);
            this.txtClientDirectory.Name = "txtClientDirectory";
            this.txtClientDirectory.Size = new System.Drawing.Size(453, 23);
            this.txtClientDirectory.TabIndex = 3;
            this.txtClientDirectory.DoubleClick += new System.EventHandler(this.txtClientDirectory_DoubleClick);
            // 
            // txtPackDirectory
            // 
            this.txtPackDirectory.Location = new System.Drawing.Point(6, 46);
            this.txtPackDirectory.Name = "txtPackDirectory";
            this.txtPackDirectory.Size = new System.Drawing.Size(453, 23);
            this.txtPackDirectory.TabIndex = 2;
            this.txtPackDirectory.DoubleClick += new System.EventHandler(this.txtPackDirectory_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client Working Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pack Working Directory";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(321, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(402, 248);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Save";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // checkCythonize
            // 
            this.checkCythonize.AutoSize = true;
            this.checkCythonize.Checked = true;
            this.checkCythonize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCythonize.Location = new System.Drawing.Point(15, 22);
            this.checkCythonize.Name = "checkCythonize";
            this.checkCythonize.Size = new System.Drawing.Size(223, 19);
            this.checkCythonize.TabIndex = 4;
            this.checkCythonize.Text = "Run cythonize on root/uiscript/locale";
            this.checkCythonize.UseVisualStyleBackColor = true;
            // 
            // packfolderBrowseDialog
            // 
            this.packfolderBrowseDialog.Description = "Select folder where your pack files are located.";
            // 
            // clientBrowserDialog
            // 
            this.clientBrowserDialog.Description = "Select folder where your client is located.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkAutoMove);
            this.groupBox2.Controls.Add(this.checkCythonize);
            this.groupBox2.Location = new System.Drawing.Point(14, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 76);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extra helper tools";
            // 
            // checkAutoMove
            // 
            this.checkAutoMove.AutoSize = true;
            this.checkAutoMove.Checked = true;
            this.checkAutoMove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoMove.Location = new System.Drawing.Point(15, 47);
            this.checkAutoMove.Name = "checkAutoMove";
            this.checkAutoMove.Size = new System.Drawing.Size(251, 19);
            this.checkAutoMove.TabIndex = 6;
            this.checkAutoMove.Text = "Automatically move to client after packing";
            this.checkAutoMove.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 283);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "PackManager - Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtClientDirectory;
        private System.Windows.Forms.TextBox txtPackDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkCythonize;
        private System.Windows.Forms.FolderBrowserDialog packfolderBrowseDialog;
        private System.Windows.Forms.FolderBrowserDialog clientBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkAutoMove;
    }
}