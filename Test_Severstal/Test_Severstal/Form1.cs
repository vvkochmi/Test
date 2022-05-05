using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Test_Severstal
{
    public partial class Notepad : Form
    {
        static int forms = 0;

        string noteName;
        StartForm startForm;

        #region Конструкторы
        public Notepad()
        {
            InitializeComponent();
        }

        public Notepad(string noteName, StartForm startForm) : this()
        {
            this.noteName = noteName;
            this.startForm = startForm;
            forms++;
        }
        #endregion

        #region Загрузка заметки
        private void Notepad_Load(object sender, EventArgs e) //Загрузка формы
        {
            //Записываем полученные файлы в комбобоксы
            foreach (NoteClass item in NoteClass.Notes)
            {
                Notes.ComboBox.Items.Add(item.Name);
                NewWinNotes.ComboBox.Items.Add(item.Name);
            }

            //Выводим нужную записку
            NoteClass noteClass = NoteClass.Notes.Find(m => m.Name == noteName);
            try
            {
                Note.Rtf = File.ReadAllText($"Notes\\{noteClass.Name}.rtf");
                NoteName.Text = noteClass.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        #endregion

        #region Сохранение заметки
        private void Save_Click(object sender, EventArgs e) //Сохранение заметки
        {
            //Проверяем на пустоту полей
            if (NoteName.Text == "" || Note.Text == "")
            {
                MessageBox.Show("Пустое название или заметка", "Не сохранено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Сохраняем, перезаписываем или делаем копию заметки
            DialogResult? result = null;
            string name = NoteName.Text;
            if (File.Exists($"Notes\\{NoteName.Text}.rtf"))
            {
                result = MessageBox.Show("Вы хотите перезаписать файл? Иначе создастся копия", "Перезапись", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    while (File.Exists($"Notes\\{name}.rtf"))
                        name += "_copy";
                }
            }
            File.WriteAllText($"Notes\\{name}.rtf", Note.Rtf);

            //Если добавляется новая записка, то обновляем список заметок
            if (result == DialogResult.No || result == null)
            {
                NoteClass.Notes.Add(new NoteClass(name));
                Notes.ComboBox.Items.Add(name);
                NewWinNotes.ComboBox.Items.Add(name);
                ListBox list = (ListBox)startForm.Controls["NoteList"];
                list.Items.Add(name);
            }
        }
        #endregion

        #region Удаление заметки
        private void Del_Click(object sender, EventArgs e) //Удаление заметки
        {
            DialogResult result;
            result = MessageBox.Show("Вы действительно хотите удалить заметку?", "Удаление заметки", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                File.Delete($"Notes\\{NoteName.Text}.rtf");
                NoteClass noteClass = NoteClass.Notes.Find(m => m.Name == NoteName.Text);
                NoteClass.Notes.Remove(noteClass);
                Notes.ComboBox.Items.Remove(NoteName.Text);
                NewWinNotes.ComboBox.Items.Remove(NoteName.Text);
                ListBox list = (ListBox)startForm.Controls["NoteList"];
                list.Items.Remove(NoteName.Text);
                NoteName.Clear();
                Note.Clear();
            }
        }
        #endregion

        #region Это окно
        private void NewNote_Click(object sender, EventArgs e) //Новая заметка, очистка полей
        {
            Save_Click(sender, e);
            NoteName.Clear();
            Note.Clear();
        }

        private void Notes_SelectedIndexChanged(object sender, EventArgs e) //Выбор других заметок
        {
            Save_Click(sender, e);
            try
            {
                Note.Rtf = File.ReadAllText($"Notes\\{Notes.SelectedItem}.rtf");
                NoteName.Text = Notes.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Новое окно
        private void NewWinNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Notepad(NewWinNotes.SelectedItem.ToString(), startForm).Show();
        }
        #endregion

        #region Форматирование текста
        private void Fat_Click(object sender, EventArgs e) //Жирный текст
        {
            if (Note.SelectionFont.Bold == true)
                Note.SelectionFont = new Font(Note.SelectionFont, FontStyle.Regular);
            else
                Note.SelectionFont = new Font(Note.SelectionFont, FontStyle.Bold);
        }

        private void Italics_Click(object sender, EventArgs e) //Курсив
        {
            if (Note.SelectionFont.Italic == true)
                Note.SelectionFont = new Font(Note.SelectionFont, FontStyle.Regular);
            else
                Note.SelectionFont = new Font(Note.SelectionFont, FontStyle.Italic);
        }

        private void TextFont_Click(object sender, EventArgs e) //Размер текста
        {
            Note.SelectionFont = new Font(Note.SelectionFont.FontFamily, (float)numeric1.Value, Note.SelectionFont.Style);
        }

        private void TextColor_Click(object sender, EventArgs e) //Цвет текста
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                Note.SelectionColor = colorDialog1.Color;
        }
        #endregion

        #region Закрытие формы
        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_Click(sender, e);
            forms--;
            if (forms == 0)
                startForm.Visible = true;
        }

        #endregion
    }
}
