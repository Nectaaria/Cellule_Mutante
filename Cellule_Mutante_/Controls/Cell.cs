using System;
using System.Drawing;
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

            }
        }
        public override string ToString()
        {
            return base.ToString(); 
        }
        public string UpdateSize()
        {
            size = 30;
            return size.ToString();
        }
        public void UpdateColor()
        {
            color = Color.Red;
        }

    }
}
