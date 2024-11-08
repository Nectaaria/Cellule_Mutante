using System;
using System.Data.SqlTypes;
using System.Diagnostics;
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
            string genetik = genetic;
            foreach (var character in genetic)
            {
                int Rnd = rnd.Next(100);
                if (character == 'A' && Rnd <= 15)
                {
                    string lettre = "T";
                    genetik= genetik + lettre;
                }
                else if (character == 'T' && Rnd <= 7)
                {
                    string lettre = "AA";
                    genetik = genetik + lettre;
                }
                else if (character == 'C' && Rnd <= 21)
                {
                    string lettre = "G";
                    genetik = genetik + lettre;
                }
                else if (character == 'G' && Rnd <= 4)
                {
                    string lettre = "CG";
                    genetik = genetik + lettre;                                  
                }
                if(Rnd <=5)
                {
                    string lettreAleatoire = "ATCG";
                    int index = rnd.Next(lettreAleatoire.Length);
                    string lettre = lettreAleatoire[index].ToString();
                    //Nothing Happens
                    genetik = genetik + lettre;
                }

                
            }
            genetic = genetik;
        }
        public override string ToString()
        {
            string toString = base.ToString();
            toString += String.Format("Génétique = {0}\n", this.genetic);
            toString += String.Format("Taille = {0}\n", this.size);
            return toString; 
        }
        public string UpdateSize()
        {
            int sizeT = genetic.Count(c => c == 'T');
            size += 10 + (genetic.Length / 5) + (sizeT < size ? sizeT : size);
            

            return size.ToString();
        }
        public void UpdateColor()
        {
            int nbTGT = Regex.Matches(genetic, Regex.Escape("TGT")).Count;
            int nbATT = Regex.Matches(genetic, Regex.Escape("ATT")).Count;
            int nbCTC = Regex.Matches(genetic, Regex.Escape("CTC")).Count;
            int nbACT = Regex.Matches(genetic, Regex.Escape("ACT")).Count;
            int nbGTC = Regex.Matches(genetic, Regex.Escape("GTC")).Count;
            int nbGAA = Regex.Matches(genetic, Regex.Escape("GAA")).Count;
            if (nbTGT > nbATT && nbTGT>nbCTC && nbTGT >nbACT && nbTGT > nbGTC && nbTGT >nbGAA)
            {
                color = Color.Black;
            }
            else if (nbATT > nbTGT && nbATT > nbCTC && nbATT > nbACT && nbATT > nbGTC && nbATT > nbGAA)
            {
                color = Color.Blue;
            }
            else if(nbCTC > nbATT && nbCTC > nbTGT && nbCTC > nbACT && nbCTC > nbGTC && nbCTC > nbGAA)
            {
                color = Color.Yellow;
            }
            else if (nbACT > nbATT && nbACT > nbCTC && nbACT > nbTGT && nbACT > nbGTC && nbACT > nbGAA)
            {
                color = Color.Purple;
            }
            else if (nbGTC > nbATT && nbGTC > nbCTC && nbGTC > nbACT && nbGTC > nbTGT && nbGTC > nbGAA)
            {
                color = Color.Orange;
            }
            else if (nbGAA > nbATT && nbGAA > nbCTC && nbGAA > nbACT && nbGAA > nbGTC && nbGAA > nbTGT)
            {
                color = Color.Green;
            }
            else
            {
                color = Color.Black;
            }


        }
    }
}
