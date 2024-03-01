namespace MindworxPreAssessment
{
    partial class Form1
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
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnClear = new Button();
            lstCollection = new ListBox();
            txtAdd = new TextBox();
            btnCompleteEdit = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(231, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(231, 113);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(231, 142);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(231, 171);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lstCollection
            // 
            lstCollection.FormattingEnabled = true;
            lstCollection.ItemHeight = 15;
            lstCollection.Location = new Point(324, 84);
            lstCollection.Name = "lstCollection";
            lstCollection.Size = new Size(250, 259);
            lstCollection.TabIndex = 4;
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(324, 42);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(100, 23);
            txtAdd.TabIndex = 5;
            // 
            // btnCompleteEdit
            // 
            btnCompleteEdit.Location = new Point(430, 42);
            btnCompleteEdit.Name = "btnCompleteEdit";
            btnCompleteEdit.Size = new Size(122, 23);
            btnCompleteEdit.TabIndex = 6;
            btnCompleteEdit.Text = "Edit completed";
            btnCompleteEdit.UseVisualStyleBackColor = true;
            btnCompleteEdit.Visible = false;
            btnCompleteEdit.Click += btnCompleteEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCompleteEdit);
            Controls.Add(txtAdd);
            Controls.Add(lstCollection);
            Controls.Add(btnClear);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnClear;
        private ListBox lstCollection;
        private TextBox txtAdd;
        private Button btnCompleteEdit;
    }
}