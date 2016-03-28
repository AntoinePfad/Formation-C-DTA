using Musique.Classes;
using Musique.Interface;
using Musique.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que souhaitez vous faire ?");
            Console.WriteLine("1 : Lire une piste");
            Console.WriteLine("2 : Composer vous même");

            ConsoleKeyInfo userChoice = Console.ReadKey();
            ConsoleKey key = userChoice.Key;

            switch (key)
            {
                case ConsoleKey.D1:
                    PlayRecordedTrack();
                    break;
                case ConsoleKey.D2:
                    Record();
                    break;
            }

            Console.ReadKey();
        }

        public static void PlayRecordedTrack()
        {
            Console.WriteLine("Vous avez décidé de lire une piste pré-enregistrée");

            List<INote> Sheet = new List<INote>();
            Sheet.Add(new Note(Notes.DO, 2));
            Sheet.Add(new Note(Notes.RE, 2));
            Sheet.Add(new Note(Notes.MI, 2));
            Sheet.Add(new Note(Notes.FA, 4));
            Sheet.Add(new Note(Notes.SOL, 1));
            Sheet.Add(new Note(Notes.LA, 6));
            Sheet.Add(new Note(Notes.SI, 15));

            var TrackTango = new Piste<Tango>(Sheet);

            TrackTango.Play();

            Console.ReadKey();

            var TrackSalsa = new Piste<Salsa>(Sheet);
            TrackSalsa.Play();
        }

        public static void Record()
        {
            Console.WriteLine("Vous avez décidé de composer vous même.");
            Console.WriteLine("Le style par défaut sera Salsa");
            Console.WriteLine("Appuyes sur échap pour arreter la composition");

            var piste = new Piste<Salsa>(new List<INote>());

            ConsoleKey key = ConsoleKey.Clear;

            do
            {
                key = Console.ReadKey().Key;

                try
                {
                    Notes freq = Classes.Note.KeysNote.FirstOrDefault(n => n.Key == key).Value;

                    INote note;
                    note = new Note(freq, 4);
                    piste.Style.StyleTime(note).Play();
                    piste.addNote(note);

                }

                catch (Exception)
                {
                    throw;
                }


            } while (key != ConsoleKey.Escape);


            Console.WriteLine("Voulez vous relire l'intégralité du morceau ?");
            Console.WriteLine("1 : Oui / 2 : Non");

            key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    piste.Play();
                    Console.WriteLine("Merci au revoir");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Merci au revoir");
                    break;
            }
        }
    }
}
