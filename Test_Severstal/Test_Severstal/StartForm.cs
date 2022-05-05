using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Test_Severstal
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            //Считываем сохраненные файлы из папки
            if (!Directory.Exists("Notes"))
                Directory.CreateDirectory("Notes");
            List<string> notes = Directory.GetFiles("Notes", "*.rtf").ToList();
            for (int i = 0; i < notes.Count; i++)
                notes[i] = notes[i].Replace("Notes\\", "").Replace(".rtf", "");

            //Записываем заметки в коллекцию заметок
            NoteClass.Notes = new List<NoteClass>();
            foreach (string item in notes)
                NoteClass.Notes.Add(new NoteClass(item));

            //Проверяем наличие заметок
            if (NoteClass.Notes.Count == 0)
            {
                MessageBox.Show("Заметок нет!", "Нет заметок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (NoteClass item in NoteClass.Notes)
                NoteList.Items.Add(item.Name);
        }

        private void NoteList_Click(object sender, EventArgs e) //Запускаем форму для изменения заметки
        {
            if (NoteList.Items.Count != 0 && NoteList.SelectedItem != null)
            {
                new Notepad(NoteList.SelectedItem.ToString(), this).Show();
                Visible = false;
            }
        }

        private void SaveNote_Click(object sender, EventArgs e)
        {
            //Проверяем на пустоту полей
            if (NoteName.Text == "")
            {
                MessageBox.Show("Пустое название", "Не сохранено", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            File.WriteAllText($"Notes\\{name}.rtf", "");

            if (result == DialogResult.No || result == null)
            {
                NoteClass.Notes.Add(new NoteClass(name));
                NoteList.Items.Add(name);
            }
        }
    }
}
