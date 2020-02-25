using GOL_2019.Utility;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOL_2019
{
    public class GameView
    {
        int Width = 320;
        int Height = 240;
        int Size = 10;
        DirectBitmap myBitmap;

        public void InitGameView(PictureBox picture, int width, int height)
        {
            Width = width * Size;
            Height = height * Size;
            myBitmap = new DirectBitmap(Width, Height);
            Color color = new Color();

            int xCounter = 1, yCounter = 1;
            for (int Y = 0; Y < myBitmap.Height; Y++)
            {
                for (int X = 0; X < myBitmap.Width; X++)
                {
                    color = Color.White;

                    if (GameSettings.ShowGrid)
                    {
                        if (X == xCounter * Size)
                        {
                            xCounter++;
                            color = Color.Black;
                        }
                        else if (Y == yCounter * Size)
                        {
                            color = Color.Black;
                        }
                    }

                    myBitmap.SetPixel(X, Y, color);
                }
                xCounter = 1;
                if (Y == yCounter * Size)
                {
                    yCounter++;
                }
            }

            picture.Image = myBitmap.Bitmap;
            picture.SizeMode = PictureBoxSizeMode.Normal;
        }

        public void UpdateGameView(Cell[,] currentGeneration, PictureBox picture)
        {
            // Create a Bitmap object from a file.
            Color color = new Color();
            int xCounter = 1, yCounter = 1;
            // Set each pixel in myBitmap to black.
            for (int Y = 0; Y < myBitmap.Height; Y++)
            {
                for (int X = 0; X < myBitmap.Width; X++)
                {
                    if (currentGeneration[(int)(X / 10d), (int)(Y / 10d)].State == CELL_STATE.Empty)
                    {
                        color = Color.White;
                    }
                    if (currentGeneration[(int)(X / 10d), (int)(Y / 10d)].State == CELL_STATE.Alive)
                    {
                        color = Color.Black;
                    }
                    if (currentGeneration[(int)(X / 10d), (int)(Y / 10d)].State == CELL_STATE.Dead)
                    {
                        if (!GameSettings.ShowDead)
                        {
                            color = Color.White;
                        }
                        else
                        {
                            color = Color.Gray;
                        }
                    }
                    if (GameSettings.ShowGrid)
                    {
                        if (X == xCounter * 10)
                        {
                            xCounter++;
                            color = Color.Black;
                        }
                        else if (Y == yCounter * 10)
                        {
                            color = Color.Black;
                        }
                    }

                    myBitmap.SetPixel(X, Y, color);
                }
                xCounter = 1;
                if (Y == yCounter * 10)
                {
                    yCounter++;
                }
            }

            picture.Image = myBitmap.Bitmap;
            picture.SizeMode = PictureBoxSizeMode.Normal;
        }
    }   
}
