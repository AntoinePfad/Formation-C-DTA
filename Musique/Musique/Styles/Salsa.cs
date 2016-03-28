using Musique.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musique.Styles
{
    class Salsa : IStyle
    {
        public int AverageBpm
        {
            get
            {
                return ((BpmMax + BpmMin) / 2);
            }
        }

        public int BpmMax
        {
            get
            {
                return 220;
            }
        }

        public int BpmMin
        {
            get
            {
                return 150;
            }
        }

        public INote StyleTime(INote note)
        {
            double beatPerMs = 6000 / AverageBpm;
            note.realSpan = (int)Math.Round(note.givenSpan * beatPerMs);
            return note;
        }
    }
}
