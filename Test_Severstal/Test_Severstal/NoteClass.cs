using System.Collections.Generic;

namespace Test_Severstal
{
    public class NoteClass
    {
        string name;

        public NoteClass(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public static List<NoteClass> Notes { get; set; }
    }
}
