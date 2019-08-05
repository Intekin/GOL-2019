using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GOL_2019
{
    class GameView
    {
        int Width = 320;
        int Height = 240;

        public void InitGameView(PictureBox picture, int width, int height)
        {
            Width = width;
            Height = height;
            // Create a Bitmap object from a file.
            Bitmap myBitmap = new Bitmap(Width, Height, PixelFormat.Format32bppRgb);

            // Set each pixel in myBitmap to black.
            for (int X = 0; X < myBitmap.Width; X++)
            {
                for (int Y = 0; Y < myBitmap.Height; Y++)
                {
                    myBitmap.SetPixel(X, Y, Color.White);
                }
            }
            picture.Image = myBitmap;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        public void UpdateGameView(Cell[,] currentGeneration, PictureBox picture)
        {
            // Create a Bitmap object from a file.
            Bitmap myBitmap = new Bitmap(Width, Height, PixelFormat.Format32bppRgb);
            Color color = new Color();
            // Set each pixel in myBitmap to black.
            for (int X = 0; X < myBitmap.Width; X++)
            {
                for (int Y = 0; Y < myBitmap.Height; Y++)
                {

                    if(currentGeneration[X, Y].State == CELL_STATE.Empty)
                    {
                        color = Color.White;
                    }
                    if (currentGeneration[X, Y].State == CELL_STATE.Alive)
                    {
                        color = Color.Black;
                    }
                    if (currentGeneration[X, Y].State == CELL_STATE.Dead)
                    {
                        color = Color.Gray;
                    }
                    myBitmap.SetPixel(X, Y, color);
                }
            }
            picture.Image = myBitmap;     
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }
    }
}
