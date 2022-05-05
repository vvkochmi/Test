
namespace Test_Severstal
{
    partial class Notepad
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.Note = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewNote = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Notes = new System.Windows.Forms.ToolStripComboBox();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьЗаметкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWinNotes = new System.Windows.Forms.ToolStripComboBox();
            this.NoteName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Del = new System.Windows.Forms.ToolStripMenuItem();
            this.Fat = new System.Windows.Forms.Button();
            this.Italics = new System.Windows.Forms.Button();
            this.numeric1 = new System.Windows.Forms.NumericUpDown();
            this.TextFont = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.TextColor = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).BeginInit();
            this.SuspendLayout();
            // 
            // Note
            // 
            this.Note.AcceptsTab = true;
            resources.ApplyResources(this.Note, "Note");
            this.Note.EnableAutoDragDrop = true;
            this.Note.Name = "Note";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewNote,
            this.toolStripMenuItem3,
            this.Save,
            this.Del});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // NewNote
            // 
            this.NewNote.Name = "NewNote";
            resources.ApplyResources(this.NewNote, "NewNote");
            this.NewNote.Click += new System.EventHandler(this.NewNote_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Notes});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // Notes
            // 
            this.Notes.Name = "Notes";
            resources.ApplyResources(this.Notes, "Notes");
            this.Notes.SelectedIndexChanged += new System.EventHandler(this.Notes_SelectedIndexChanged);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            resources.ApplyResources(this.Save, "Save");
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьЗаметкуToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // выбратьЗаметкуToolStripMenuItem
            // 
            this.выбратьЗаметкуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewWinNotes});
            this.выбратьЗаметкуToolStripMenuItem.Name = "выбратьЗаметкуToolStripMenuItem";
            resources.ApplyResources(this.выбратьЗаметкуToolStripMenuItem, "выбратьЗаметкуToolStripMenuItem");
            // 
            // NewWinNotes
            // 
            this.NewWinNotes.Name = "NewWinNotes";
            resources.ApplyResources(this.NewWinNotes, "NewWinNotes");
            this.NewWinNotes.SelectedIndexChanged += new System.EventHandler(this.NewWinNotes_SelectedIndexChanged);
            // 
            // NoteName
            // 
            resources.ApplyResources(this.NoteName, "NoteName");
            this.NoteName.Name = "NoteName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Del
            // 
            this.Del.Name = "Del";
            resources.ApplyResources(this.Del, "Del");
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Fat
            // 
            resources.ApplyResources(this.Fat, "Fat");
            this.Fat.Name = "Fat";
            this.Fat.UseVisualStyleBackColor = true;
            this.Fat.Click += new System.EventHandler(this.Fat_Click);
            // 
            // Italics
            // 
            resources.ApplyResources(this.Italics, "Italics");
            this.Italics.Name = "Italics";
            this.Italics.UseVisualStyleBackColor = true;
            this.Italics.Click += new System.EventHandler(this.Italics_Click);
            // 
            // numeric1
            // 
            resources.ApplyResources(this.numeric1, "numeric1");
            this.numeric1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric1.Name = "numeric1";
            this.numeric1.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // TextFont
            // 
            resources.ApplyResources(this.TextFont, "TextFont");
            this.TextFont.Name = "TextFont";
            this.TextFont.UseVisualStyleBackColor = true;
            this.TextFont.Click += new System.EventHandler(this.TextFont_Click);
            // 
            // TextColor
            // 
            resources.ApplyResources(this.TextColor, "TextColor");
            this.TextColor.Name = "TextColor";
            this.TextColor.UseVisualStyleBackColor = true;
            this.TextColor.Click += new System.EventHandler(this.TextColor_Click);
            // 
            // Notepad
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextColor);
            this.Controls.Add(this.TextFont);
            this.Controls.Add(this.numeric1);
            this.Controls.Add(this.Italics);
            this.Controls.Add(this.Fat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoteName);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notepad_FormClosing);
            this.Load += new System.EventHandler(this.Notepad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Note;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem NewNote;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripComboBox Notes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem выбратьЗаметкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox NewWinNotes;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.TextBox NoteName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem Del;
        private System.Windows.Forms.Button Fat;
        private System.Windows.Forms.Button Italics;
        private System.Windows.Forms.NumericUpDown numeric1;
        private System.Windows.Forms.Button TextFont;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button TextColor;
    }
}

