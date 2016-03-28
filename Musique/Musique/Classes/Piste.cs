using Musique.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Musique.Classes
{
    public class Piste<T> : IEnumerable<INote> where T : IStyle, new()
    {
        public T Style;
        private List<INote> Notes { get; set; }

        public Piste(List<INote> sheet)
        {
            Style = new T();
            this.Notes = sheet;
        }

        public void addNote(INote noteToAdd)
        {
            Notes.Add(noteToAdd);
        }

        public void Play()
        {
            foreach (INote noteToPlay in this.Notes)
            {
                Style.StyleTime(noteToPlay).Play();
            }
        }

        public IEnumerator<INote> GetEnumerator()
        {
            return this.Notes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Notes.GetEnumerator();
        }
    }
}
