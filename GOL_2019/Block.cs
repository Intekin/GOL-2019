using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL_2019
{
    class Block
    {
        public int Size = 10;
        public Bitmap bitmap;

        public Block()
        {
            bitmap = new Bitmap(Size, Size, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            for (int x = 0; x < Size; x++)
            {
                bitmap.SetPixel(x, Size, Color.Black);
            }

            for (int y = 0; y < Size; y++)
            {
                bitmap.SetPixel(Size, y, Color.Black);
            }
        }

        public Bitmap Draw(CELL_STATE state)
        {
            if (state == CELL_STATE.Alive)
            {
                for (int y = 0; y < Size - 1; y++)
                {
                    for (int x = 0; x < Size - 1; y++)
                    {
                        bitmap.SetPixel(x, y, Color.Green);
                    }
                }
            }
            if (state == CELL_STATE.Dead)
            {
                for (int y = 0; y < Size - 1; y++)
                {
                    for (int x = 0; x < Size - 1; y++)
                    {
                        bitmap.SetPixel(x, y, Color.White);
                    }
                }
            }

            return bitmap;
        }
    }
}
