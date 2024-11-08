using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Cellule_Mutante_
{
    public class Cell
    {
        public int size;
        public Color color;
        private Random rnd = new Random();
        public string genetic = "A";
        public Cell(int size, Color color, string genetic)
        {
            size = 10;
            color = Color.Black;
        }
        public void Mutation()
        {
            size += 5;
            color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            foreach (var character in genetic)
            {
                int Rnd = rnd.Next(100);
                if (character == 'A' && Rnd <= 15)
                {
                    string lettre = "T";
                    genetic = genetic + lettre;
                }
                else if (character == 'T' && Rnd <= 7)
                {
                    string lettre = "AA";
                    genetic = genetic + lettre;
                }
                else if (character == 'C' && Rnd <= 21)
                {
                    string lettre = "G";
                    genetic = genetic + lettre;
                }
                else if (character == 'G' && Rnd <= 4)
                {
                    string lettre = "CG";
                    genetic = genetic + lettre;
                }
                else
                {
                    //Nothing Happens
                }
            }
        }
        public override string ToString()
        {
            return base.ToString(); 
        }
        public string UpdateSize()
        {
            int sizeT = genetic.Count(c => c == 'T');
            size += 10 + (genetic.Length / 5) + (sizeT < size ? sizeT : size);
            

            return size.ToString();
        }
        public void UpdateColor()
        {
            int nbTGT = Regex.Matches(genetic, Regex.Escape("TGT"), RegexOptions.IgnoreCase).Count;
            int nbATT = Regex.Matches(genetic, Regex.Escape("ATT"), RegexOptions.IgnoreCase).Count;
            int nbCTC = Regex.Matches(genetic, Regex.Escape("CTC"), RegexOptions.IgnoreCase).Count;
            int nbACT = Regex.Matches(genetic, Regex.Escape("ACT"), RegexOptions.IgnoreCase).Count;
            int nbGTC = Regex.Matches(genetic, Regex.Escape("GTC"), RegexOptions.IgnoreCase).Count;
            int nbGAA = Regex.Matches(genetic, Regex.Escape("GAA"), RegexOptions.IgnoreCase).Count;


        }
    }
}
