using Musique.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musique.Classes
{



    public enum Notes
    {
        Silence = 0,
        DO = 262,
        DOs = 277,
        RE = 294,
        REs = 311,
        MI = 330,
        FA = 349,
        FAs = 370,
        SOL = 392,
        SOLs = 415,
        LA = 440,
        LAs = 466,
        SI = 494
    }

    class Note : INote
    {
        public Notes Frequency { get; set; }
        public int realSpan { get; set; }
        public int givenSpan { get; set; }

        public static readonly Dictionary<ConsoleKey, Notes> KeysNote = new Dictionary<ConsoleKey, Notes>
        {
            {ConsoleKey.Q, Notes.DO},
            {ConsoleKey.Z, Notes.DOs},
            {ConsoleKey.S, Notes.RE},
            {ConsoleKey.E, Notes.REs},
            {ConsoleKey.D, Notes.MI},
            {ConsoleKey.F, Notes.FA},
            {ConsoleKey.T, Notes.FAs},
            {ConsoleKey.G, Notes.SOL},
            {ConsoleKey.Y, Notes.SOLs},
            {ConsoleKey.H, Notes.LA},
            {ConsoleKey.U, Notes.LAs},
            {ConsoleKey.J, Notes.SI},
            {ConsoleKey.A, Notes.Silence}
        };

        public Note(Notes value, int span)
        {
            Frequency = value;
            this.givenSpan = span;
        }

        public Note()
        {

        }

        public void Play()
        {
            if ((int)this.Frequency != 0)
                Console.Beep(((int)this.Frequency), this.realSpan);
            else
                System.Threading.Thread.Sleep(givenSpan);
        }
    }
}
