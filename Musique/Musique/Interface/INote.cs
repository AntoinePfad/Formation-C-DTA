using Musique.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musique.Interface
{
    public interface INote
    {
        /// <summary>
        /// Durée du son après application du Style de musique
        /// </summary>
        int realSpan { get; set; }

        /// <summary>
        /// Durée du son avant modification du Style de musique
        /// </summary>
        int givenSpan { get; set; }

        /// <summary>
        /// Enum concernant les Hertz des notes
        /// </summary>
        Notes Frequency { get; set; }

        void Play();
    }
}
