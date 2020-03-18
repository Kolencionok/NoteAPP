using  NoteApp;

namespace NoteAppUI
{
    partial class NoteApp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "All",
            "Home",
            "Work",
            "Health and sport",
            "People",
            "Documents",
            "Finance",
            "Other"});
            this.CategoryComboBox.Location = new System.Drawing.Point(123, 82);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(136, 24);
            this.CategoryComboBox.TabIndex = 0;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show category:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NotesListBox
            // 
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.ItemHeight = 16;
            this.NotesListBox.Location = new System.Drawing.Point(15, 126);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(244, 388);
            this.NotesListBox.TabIndex = 2;
            // 
            // NoteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NotesListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryComboBox);
            this.Name = "NoteApp";
            this.Size = new System.Drawing.Size(1016, 611);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox NotesListBox;
    }
}
