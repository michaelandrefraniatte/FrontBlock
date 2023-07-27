using Microsoft.Xna.Framework;
using MonoGame.Forms.Controls;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
namespace MonoGame.Forms.DX.Controls
{
    public class SampleControl : MonoGameControl
    {
        private static int width, height;
        private static Bitmap block_white = Image.FromFile("block-white.png") as Bitmap;
        private static Bitmap block_purple = Image.FromFile("block-purple.png") as Bitmap;
        private static Bitmap block_green = Image.FromFile("block-green.png") as Bitmap;
        private static System.Drawing.Point[] block1 = new System.Drawing.Point[10];
        private static Texture2D[] texture1 = new Texture2D[10];
        private static System.Drawing.Point[] block2 = new System.Drawing.Point[10];
        private static Texture2D[] texture2 = new Texture2D[10];
        private static System.Drawing.Point[] block3 = new System.Drawing.Point[10];
        private static Texture2D[] texture3 = new Texture2D[10];
        private static System.Drawing.Point[] block4 = new System.Drawing.Point[10];
        private static Texture2D[] texture4 = new Texture2D[10];
        private static System.Drawing.Point[] block5 = new System.Drawing.Point[10];
        private static Texture2D[] texture5 = new Texture2D[10];
        private static System.Drawing.Point[] block6 = new System.Drawing.Point[10];
        private static Texture2D[] texture6 = new Texture2D[10];
        private static System.Drawing.Point[] block7 = new System.Drawing.Point[10];
        private static Texture2D[] texture7 = new Texture2D[10];
        private static System.Drawing.Point[] block8 = new System.Drawing.Point[10];
        private static Texture2D[] texture8 = new Texture2D[10];
        private static System.Drawing.Point[] block9 = new System.Drawing.Point[10];
        private static Texture2D[] texture9 = new Texture2D[10];
        private static System.Drawing.Point[] block10 = new System.Drawing.Point[10];
        private static Texture2D[] texture10 = new Texture2D[10];
        private static string[] color1 = new string[10];
        private static string[] color2 = new string[10];
        private static string[] color3 = new string[10];
        private static string[] color4 = new string[10];
        private static string[] color5 = new string[10];
        private static string[] color6 = new string[10];
        private static string[] color7 = new string[10];
        private static string[] color8 = new string[10];
        private static string[] color9 = new string[10];
        private static string[] color10 = new string[10];
        private static MouseState mouseState;
        private static KeyboardState keyState;
        private static int mouseX, mouseY, turncount, pointcountp1, pointcountp2, extraturncountp1, extraturncountp2;
        private static bool mousepressed = false;
        private static int[] wd = { 2, 2, 2, 2, 2 };
        private static int[] wu = { 2, 2, 2, 2, 2 };
        private static void valchanged(int n, bool val)
        {
            if (val)
            {
                if (wd[n] <= 1)
                {
                    wd[n] = wd[n] + 1;
                }
                wu[n] = 0;
            }
            else
            {
                if (wu[n] <= 1)
                {
                    wu[n] = wu[n] + 1;
                }
                wd[n] = 0;
            }
        }
        protected void SetPosition()
        {
            block1[0] = new System.Drawing.Point(width + 10 + 0 * 50, height + 10 + 0 * 50);
            block1[1] = new System.Drawing.Point(width + 10 + 1 * 50, height + 10 + 0 * 50);
            block1[2] = new System.Drawing.Point(width + 10 + 2 * 50, height + 10 + 0 * 50);
            block1[3] = new System.Drawing.Point(width + 10 + 3 * 50, height + 10 + 0 * 50);
            block1[4] = new System.Drawing.Point(width + 10 + 4 * 50, height + 10 + 0 * 50);
            block1[5] = new System.Drawing.Point(width + 10 + 5 * 50, height + 10 + 0 * 50);
            block1[6] = new System.Drawing.Point(width + 10 + 6 * 50, height + 10 + 0 * 50);
            block1[7] = new System.Drawing.Point(width + 10 + 7 * 50, height + 10 + 0 * 50);
            block1[8] = new System.Drawing.Point(width + 10 + 8 * 50, height + 10 + 0 * 50);
            block1[9] = new System.Drawing.Point(width + 10 + 9 * 50, height + 10 + 0 * 50);
            block2[0] = new System.Drawing.Point(width + 10 + 0 * 50, height + 10 + 1 * 50);
            block2[1] = new System.Drawing.Point(width + 10 + 1 * 50, height + 10 + 1 * 50);
            block2[2] = new System.Drawing.Point(width + 10 + 2 * 50, height + 10 + 1 * 50);
            block2[3] = new System.Drawing.Point(width + 10 + 3 * 50, height + 10 + 1 * 50);
            block2[4] = new System.Drawing.Point(width + 10 + 4 * 50, height + 10 + 1 * 50);
            block2[5] = new System.Drawing.Point(width + 10 + 5 * 50, height + 10 + 1 * 50);
            block2[6] = new System.Drawing.Point(width + 10 + 6 * 50, height + 10 + 1 * 50);
            block2[7] = new System.Drawing.Point(width + 10 + 7 * 50, height + 10 + 1 * 50);
            block2[8] = new System.Drawing.Point(width + 10 + 8 * 50, height + 10 + 1 * 50);
            block2[9] = new System.Drawing.Point(width + 10 + 9 * 50, height + 10 + 1 * 50);
            block3[0] = new System.Drawing.Point(width + 10 + 0 * 50, height + 10 + 2 * 50);
            block3[1] = new System.Drawing.Point(width + 10 + 1 * 50, height + 10 + 2 * 50);
            block3[2] = new System.Drawing.Point(width + 10 + 2 * 50, height + 10 + 2 * 50);
            block3[3] = new System.Drawing.Point(width + 10 + 3 * 50, height + 10 + 2 * 50);
            block3[4] = new System.Drawing.Point(width + 10 + 4 * 50, height + 10 + 2 * 50);
            block3[5] = new System.Drawing.Point(width + 10 + 5 * 50, height + 10 + 2 * 50);
            block3[6] = new System.Drawing.Point(width + 10 + 6 * 50, height + 10 + 2 * 50);
            block3[7] = new System.Drawing.Point(width + 10 + 7 * 50, height + 10 + 2 * 50);
            block3[8] = new System.Drawing.Point(width + 10 + 8 * 50, height + 10 + 2 * 50);
            block3[9] = new System.Drawing.Point(width + 10 + 9 * 50, height + 10 + 2 * 50);
            block4[0] = new System.Drawing.Point(width + 10 + 0 * 50, height + 10 + 3 * 50);
            block4[1] = new System.Drawing.Point(width + 10 + 1 * 50, height + 10 + 3 * 50);
            block4[2] = new System.Drawing.Point(width + 10 + 2 * 50, height + 10 + 3 * 50);
            block4[3] = new System.Drawing.Point(width + 10 + 3 * 50, height + 10 + 3 * 50);
            block4[4] = new System.Drawing.Point(width + 10 + 4 * 50, height + 10 + 3 * 50);
            block4[5] = new System.Drawing.Point(width + 10 + 5 * 50, height + 10 + 3 * 50);
            block4[6] = new System.Drawing.Point(width + 10 + 6 * 50, height + 10 + 3 * 50);
            block4[7] = new System.Drawing.Point(width + 10 + 7 * 50, height + 10 + 3 * 50);
            block4[8] = new System.Drawing.Point(width + 10 + 8 * 50, height + 10 + 3 * 50);
            block4[9] = new System.Drawing.Point(width + 10 + 9 * 50, height + 10 + 3 * 50);
            block5[0] = new System.Drawing.Point(width + 10 + 0 * 50, height + 10 + 4 * 50);
            block5[1] = new System.Drawing.Point(width + 10 + 1 * 50, height + 10 + 4 * 50);
            block5[2] = new System.Drawing.Point(width + 10 + 2 * 50, height + 10 + 4 * 50);
            block5[3] = new System.Drawing.Point(width + 10 + 3 * 50, height + 10 + 4 * 50);
            block5[4] = new System.Drawing.Point(width + 10 + 4 * 50, height + 10 + 4 * 50);
            block5[5] = new System.Drawing.Point(width + 10 + 5 * 50, height + 10 + 4 * 50);
            block5[6] = new System.Drawing.Point(width + 10 + 6 * 50, height + 10 + 4 * 50);
            block5[7] = new System.Drawing.Point(width + 10 + 7 * 50, height + 10 + 4 * 50);
            block5[8] = new System.Drawing.Point(width + 10 + 8 * 50, height + 10 + 4 * 50);
            block5[9] = new System.Drawing.Point(width + 10 + 9 * 50, height + 10 + 4 * 50);
            block6[0] = new System.Drawing.Point(width + 10 + 0 * 50, height + 10 + 5 * 50);
            block6[1] = new System.Drawing.Point(width + 10 + 1 * 50, height + 10 + 5 * 50);
            block6[2] = new System.Drawing.Point(width + 10 + 2 * 50, height + 10 + 5 * 50);
            block6[3] = new System.Drawing.Point(width + 10 + 3 * 50, height + 10 + 5 * 50);
            block6[4] = new System.Drawing.Point(width + 10 + 4 * 50, height + 10 + 5 * 50);
            block6[5] = new System.Drawing.Point(width + 10 + 5 * 50, height + 10 + 5 * 50);
            block6[6] = new System.Drawing.Point(width + 10 + 6 * 50, height + 10 + 5 * 50);
            block6[7] = new System.Drawing.Point(width + 10 + 7 * 50, height + 10 + 5 * 50);
            block6[8] = new System.Drawing.Point(width + 10 + 8 * 50, height + 10 + 5 * 50);
            block6[9] = new System.Drawing.Point(width + 10 + 9 * 50, height + 10 + 5 * 50);
            block7[0] = new System.Drawing.Point(width + 10 + 0 * 50, height + 10 + 6 * 50);
            block7[1] = new System.Drawing.Point(width + 10 + 1 * 50, height + 10 + 6 * 50);
            block7[2] = new System.Drawing.Point(width + 10 + 2 * 50, height + 10 + 6 * 50);
            block7[3] = new System.Drawing.Point(width + 10 + 3 * 50, height + 10 + 6 * 50);
            block7[4] = new System.Drawing.Point(width + 10 + 4 * 50, height + 10 + 6 * 50);
            block7[5] = new System.Drawing.Point(width + 10 + 5 * 50, height + 10 + 6 * 50);
            block7[6] = new System.Drawing.Point(width + 10 + 6 * 50, height + 10 + 6 * 50);
            block7[7] = new System.Drawing.Point(width + 10 + 7 * 50, height + 10 + 6 * 50);
            block7[8] = new System.Drawing.Point(width + 10 + 8 * 50, height + 10 + 6 * 50);
            block7[9] = new System.Drawing.Point(width + 10 + 9 * 50, height + 10 + 6 * 50);
            block8[0] = new System.Drawing.Point(width + 10 + 0 * 50, height + 10 + 7 * 50);
            block8[1] = new System.Drawing.Point(width + 10 + 1 * 50, height + 10 + 7 * 50);
            block8[2] = new System.Drawing.Point(width + 10 + 2 * 50, height + 10 + 7 * 50);
            block8[3] = new System.Drawing.Point(width + 10 + 3 * 50, height + 10 + 7 * 50);
            block8[4] = new System.Drawing.Point(width + 10 + 4 * 50, height + 10 + 7 * 50);
            block8[5] = new System.Drawing.Point(width + 10 + 5 * 50, height + 10 + 7 * 50);
            block8[6] = new System.Drawing.Point(width + 10 + 6 * 50, height + 10 + 7 * 50);
            block8[7] = new System.Drawing.Point(width + 10 + 7 * 50, height + 10 + 7 * 50);
            block8[8] = new System.Drawing.Point(width + 10 + 8 * 50, height + 10 + 7 * 50);
            block8[9] = new System.Drawing.Point(width + 10 + 9 * 50, height + 10 + 7 * 50);
            block9[0] = new System.Drawing.Point(width + 10 + 0 * 50, height + 10 + 8 * 50);
            block9[1] = new System.Drawing.Point(width + 10 + 1 * 50, height + 10 + 8 * 50);
            block9[2] = new System.Drawing.Point(width + 10 + 2 * 50, height + 10 + 8 * 50);
            block9[3] = new System.Drawing.Point(width + 10 + 3 * 50, height + 10 + 8 * 50);
            block9[4] = new System.Drawing.Point(width + 10 + 4 * 50, height + 10 + 8 * 50);
            block9[5] = new System.Drawing.Point(width + 10 + 5 * 50, height + 10 + 8 * 50);
            block9[6] = new System.Drawing.Point(width + 10 + 6 * 50, height + 10 + 8 * 50);
            block9[7] = new System.Drawing.Point(width + 10 + 7 * 50, height + 10 + 8 * 50);
            block9[8] = new System.Drawing.Point(width + 10 + 8 * 50, height + 10 + 8 * 50);
            block9[9] = new System.Drawing.Point(width + 10 + 9 * 50, height + 10 + 8 * 50);
            block10[0] = new System.Drawing.Point(width + 10 + 0 * 50, height + 10 + 9 * 50);
            block10[1] = new System.Drawing.Point(width + 10 + 1 * 50, height + 10 + 9 * 50);
            block10[2] = new System.Drawing.Point(width + 10 + 2 * 50, height + 10 + 9 * 50);
            block10[3] = new System.Drawing.Point(width + 10 + 3 * 50, height + 10 + 9 * 50);
            block10[4] = new System.Drawing.Point(width + 10 + 4 * 50, height + 10 + 9 * 50);
            block10[5] = new System.Drawing.Point(width + 10 + 5 * 50, height + 10 + 9 * 50);
            block10[6] = new System.Drawing.Point(width + 10 + 6 * 50, height + 10 + 9 * 50);
            block10[7] = new System.Drawing.Point(width + 10 + 7 * 50, height + 10 + 9 * 50);
            block10[8] = new System.Drawing.Point(width + 10 + 8 * 50, height + 10 + 9 * 50);
            block10[9] = new System.Drawing.Point(width + 10 + 9 * 50, height + 10 + 9 * 50);
        }
        private void InitPlate()
        {
            extraturncountp1 = 0;
            extraturncountp2 = 0;
            pointcountp1 = 0;
            pointcountp2 = 0;
            turncount = 0;
            for (int n = 0; n < 10; n++)
            {
                texture1[n] = GetTexture2DFromBitmap(block_white);
                texture2[n] = GetTexture2DFromBitmap(block_white);
                texture3[n] = GetTexture2DFromBitmap(block_white);
                texture4[n] = GetTexture2DFromBitmap(block_white);
                texture5[n] = GetTexture2DFromBitmap(block_white);
                texture6[n] = GetTexture2DFromBitmap(block_white);
                texture7[n] = GetTexture2DFromBitmap(block_white);
                texture8[n] = GetTexture2DFromBitmap(block_white);
                texture9[n] = GetTexture2DFromBitmap(block_white);
                texture10[n] = GetTexture2DFromBitmap(block_white);
                color1[n] = "white";
                color2[n] = "white";
                color3[n] = "white";
                color4[n] = "white";
                color5[n] = "white";
                color6[n] = "white";
                color7[n] = "white";
                color8[n] = "white";
                color9[n] = "white";
                color10[n] = "white";
            }
        }
        protected override void Initialize()
        {
            base.Initialize();
            base.BackColor = System.Drawing.Color.Black;
            base.ForeColor = System.Drawing.Color.Black;
            width = 440;
            height = 120;
            SetPosition();
            InitPlate();
        }
        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        protected override void Draw()
        {
            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Escape))
            {
                Application.Exit();
            }
            if (keyState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Space))
            {
                InitPlate();
            }
            mouseState = Mouse.GetState();
            mouseX = mouseState.X;
            mouseY = mouseState.Y;
            if (mouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                mousepressed = true;
            }
            else
            {
                mousepressed = false;
            }
            valchanged(0, mousepressed);
            if (wd[0] == 1)
            {
                for (int n = 0; n < 10; n++)
                {
                    if (mouseX >= block1[n].X + 2 & mouseX <= block1[n].X + block_white.Width - 2 & mouseY >= block1[n].Y + 2 & mouseY <= block1[n].Y + block_white.Height - 2)
                    {
                        if (color1[n] == "white")
                        {
                            if (turncount < 2)
                            {
                                if (n == 0)
                                {
                                    texture1[n] = GetTexture2DFromBitmap(block_purple);
                                    color1[n] = "purple";
                                    turncount++;
                                    pointcountp1++;
                                    if (color1[n + 1] == "green")
                                    {
                                        extraturncountp1++;
                                        extraturncountp1++;
                                    }
                                    if (extraturncountp1 > 0)
                                    {
                                        extraturncountp1--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color1[n - 1] == "purple")
                                    {
                                        texture1[n] = GetTexture2DFromBitmap(block_purple);
                                        color1[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                        if (color1[n + 1] == "green")
                                        {
                                            extraturncountp1++;
                                            extraturncountp1++;
                                        }
                                        if (extraturncountp1 > 0)
                                        {
                                            extraturncountp1--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 9)
                                {
                                    if (color1[n - 1] == "purple")
                                    {
                                        texture1[n] = GetTexture2DFromBitmap(block_purple);
                                        color1[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                    }
                                }
                            }
                            else if (turncount > 1)
                            {
                                if (n == 9)
                                {
                                    texture1[n] = GetTexture2DFromBitmap(block_green);
                                    color1[n] = "green";
                                    turncount++;
                                    pointcountp2++;
                                    if (color1[n - 1] == "purple")
                                    {
                                        extraturncountp2++;
                                        extraturncountp2++;
                                    }
                                    if (extraturncountp2 > 0)
                                    {
                                        extraturncountp2--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color1[n + 1] == "green")
                                    {
                                        texture1[n] = GetTexture2DFromBitmap(block_green);
                                        color1[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                        if (color1[n - 1] == "purple")
                                        {
                                            extraturncountp2++;
                                            extraturncountp2++;
                                        }
                                        if (extraturncountp2 > 0)
                                        {
                                            extraturncountp2--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 0)
                                {
                                    if (color1[n + 1] == "green")
                                    {
                                        texture1[n] = GetTexture2DFromBitmap(block_green);
                                        color1[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                    }
                                }
                            }
                        }
                    }
                    if (mouseX >= block2[n].X + 2 & mouseX <= block2[n].X + block_white.Width - 2 & mouseY >= block2[n].Y + 2 & mouseY <= block2[n].Y + block_white.Height - 2)
                    {
                        if (color2[n] == "white")
                        {
                            if (turncount < 2)
                            {
                                if (n == 0)
                                {
                                    texture2[n] = GetTexture2DFromBitmap(block_purple);
                                    color2[n] = "purple";
                                    turncount++;
                                    pointcountp1++;
                                    if (color2[n + 1] == "green")
                                    {
                                        extraturncountp1++;
                                        extraturncountp1++;
                                    }
                                    if (extraturncountp1 > 0)
                                    {
                                        extraturncountp1--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color2[n - 1] == "purple")
                                    {
                                        texture2[n] = GetTexture2DFromBitmap(block_purple);
                                        color2[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                        if (color2[n + 1] == "green")
                                        {
                                            extraturncountp1++;
                                            extraturncountp1++;
                                        }
                                        if (extraturncountp1 > 0)
                                        {
                                            extraturncountp1--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 9)
                                {
                                    if (color2[n - 1] == "purple")
                                    {
                                        texture2[n] = GetTexture2DFromBitmap(block_purple);
                                        color2[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                    }
                                }
                            }
                            else if (turncount > 1)
                            {
                                if (n == 9)
                                {
                                    texture2[n] = GetTexture2DFromBitmap(block_green);
                                    color2[n] = "green";
                                    turncount++;
                                    pointcountp2++;
                                    if (color2[n - 1] == "purple")
                                    {
                                        extraturncountp2++;
                                        extraturncountp2++;
                                    }
                                    if (extraturncountp2 > 0)
                                    {
                                        extraturncountp2--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color2[n + 1] == "green")
                                    {
                                        texture2[n] = GetTexture2DFromBitmap(block_green);
                                        color2[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                        if (color2[n - 1] == "purple")
                                        {
                                            extraturncountp2++;
                                            extraturncountp2++;
                                        }
                                        if (extraturncountp2 > 0)
                                        {
                                            extraturncountp2--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 0)
                                {
                                    if (color2[n + 1] == "green")
                                    {
                                        texture2[n] = GetTexture2DFromBitmap(block_green);
                                        color2[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                    }
                                }
                            }
                        }
                    }
                    if (mouseX >= block3[n].X + 2 & mouseX <= block3[n].X + block_white.Width - 2 & mouseY >= block3[n].Y + 2 & mouseY <= block3[n].Y + block_white.Height - 2)
                    {
                        if (color3[n] == "white")
                        {
                            if (turncount < 2)
                            {
                                if (n == 0)
                                {
                                    texture3[n] = GetTexture2DFromBitmap(block_purple);
                                    color3[n] = "purple";
                                    turncount++;
                                    pointcountp1++;
                                    if (color3[n + 1] == "green")
                                    {
                                        extraturncountp1++;
                                        extraturncountp1++;
                                    }
                                    if (extraturncountp1 > 0)
                                    {
                                        extraturncountp1--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color3[n - 1] == "purple")
                                    {
                                        texture3[n] = GetTexture2DFromBitmap(block_purple);
                                        color3[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                        if (color3[n + 1] == "green")
                                        {
                                            extraturncountp1++;
                                            extraturncountp1++;
                                        }
                                        if (extraturncountp1 > 0)
                                        {
                                            extraturncountp1--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 9)
                                {
                                    if (color3[n - 1] == "purple")
                                    {
                                        texture3[n] = GetTexture2DFromBitmap(block_purple);
                                        color3[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                    }
                                }
                            }
                            else if (turncount > 1)
                            {
                                if (n == 9)
                                {
                                    texture3[n] = GetTexture2DFromBitmap(block_green);
                                    color3[n] = "green";
                                    turncount++;
                                    pointcountp2++;
                                    if (color3[n - 1] == "purple")
                                    {
                                        extraturncountp2++;
                                        extraturncountp2++;
                                    }
                                    if (extraturncountp2 > 0)
                                    {
                                        extraturncountp2--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color3[n + 1] == "green")
                                    {
                                        texture3[n] = GetTexture2DFromBitmap(block_green);
                                        color3[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                        if (color3[n - 1] == "purple")
                                        {
                                            extraturncountp2++;
                                            extraturncountp2++;
                                        }
                                        if (extraturncountp2 > 0)
                                        {
                                            extraturncountp2--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 0)
                                {
                                    if (color3[n + 1] == "green")
                                    {
                                        texture3[n] = GetTexture2DFromBitmap(block_green);
                                        color3[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                    }
                                }
                            }
                        }
                    }
                    if (mouseX >= block4[n].X + 2 & mouseX <= block4[n].X + block_white.Width - 2 & mouseY >= block4[n].Y + 2 & mouseY <= block4[n].Y + block_white.Height - 2)
                    {
                        if (color4[n] == "white")
                        {
                            if (turncount < 2)
                            {
                                if (n == 0)
                                {
                                    texture4[n] = GetTexture2DFromBitmap(block_purple);
                                    color4[n] = "purple";
                                    turncount++;
                                    pointcountp1++;
                                    if (color4[n + 1] == "green")
                                    {
                                        extraturncountp1++;
                                        extraturncountp1++;
                                    }
                                    if (extraturncountp1 > 0)
                                    {
                                        extraturncountp1--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color4[n - 1] == "purple")
                                    {
                                        texture4[n] = GetTexture2DFromBitmap(block_purple);
                                        color4[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                        if (color4[n + 1] == "green")
                                        {
                                            extraturncountp1++;
                                            extraturncountp1++;
                                        }
                                        if (extraturncountp1 > 0)
                                        {
                                            extraturncountp1--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 9)
                                {
                                    if (color4[n - 1] == "purple")
                                    {
                                        texture4[n] = GetTexture2DFromBitmap(block_purple);
                                        color4[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                    }
                                }
                            }
                            else if (turncount > 1)
                            {
                                if (n == 9)
                                {
                                    texture4[n] = GetTexture2DFromBitmap(block_green);
                                    color4[n] = "green";
                                    turncount++;
                                    pointcountp2++;
                                    if (color4[n - 1] == "purple")
                                    {
                                        extraturncountp2++;
                                        extraturncountp2++;
                                    }
                                    if (extraturncountp2 > 0)
                                    {
                                        extraturncountp2--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color4[n + 1] == "green")
                                    {
                                        texture4[n] = GetTexture2DFromBitmap(block_green);
                                        color4[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                        if (color4[n - 1] == "purple")
                                        {
                                            extraturncountp2++;
                                            extraturncountp2++;
                                        }
                                        if (extraturncountp2 > 0)
                                        {
                                            extraturncountp2--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 0)
                                {
                                    if (color4[n + 1] == "green")
                                    {
                                        texture4[n] = GetTexture2DFromBitmap(block_green);
                                        color4[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                    }
                                }
                            }
                        }
                    }
                    if (mouseX >= block5[n].X + 2 & mouseX <= block5[n].X + block_white.Width - 2 & mouseY >= block5[n].Y + 2 & mouseY <= block5[n].Y + block_white.Height - 2)
                    {
                        if (color5[n] == "white")
                        {
                            if (turncount < 2)
                            {
                                if (n == 0)
                                {
                                    texture5[n] = GetTexture2DFromBitmap(block_purple);
                                    color5[n] = "purple";
                                    turncount++;
                                    pointcountp1++;
                                    if (color5[n + 1] == "green")
                                    {
                                        extraturncountp1++;
                                        extraturncountp1++;
                                    }
                                    if (extraturncountp1 > 0)
                                    {
                                        extraturncountp1--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color5[n - 1] == "purple")
                                    {
                                        texture5[n] = GetTexture2DFromBitmap(block_purple);
                                        color5[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                        if (color5[n + 1] == "green")
                                        {
                                            extraturncountp1++;
                                            extraturncountp1++;
                                        }
                                        if (extraturncountp1 > 0)
                                        {
                                            extraturncountp1--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 9)
                                {
                                    if (color5[n - 1] == "purple")
                                    {
                                        texture5[n] = GetTexture2DFromBitmap(block_purple);
                                        color5[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                    }
                                }
                            }
                            else if (turncount > 1)
                            {
                                if (n == 9)
                                {
                                    texture5[n] = GetTexture2DFromBitmap(block_green);
                                    color5[n] = "green";
                                    turncount++;
                                    pointcountp2++;
                                    if (color5[n - 1] == "purple")
                                    {
                                        extraturncountp2++;
                                        extraturncountp2++;
                                    }
                                    if (extraturncountp2 > 0)
                                    {
                                        extraturncountp2--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color5[n + 1] == "green")
                                    {
                                        texture5[n] = GetTexture2DFromBitmap(block_green);
                                        color5[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                        if (color5[n - 1] == "purple")
                                        {
                                            extraturncountp2++;
                                            extraturncountp2++;
                                        }
                                        if (extraturncountp2 > 0)
                                        {
                                            extraturncountp2--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 0)
                                {
                                    if (color5[n + 1] == "green")
                                    {
                                        texture5[n] = GetTexture2DFromBitmap(block_green);
                                        color5[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                    }
                                }
                            }
                        }
                    }
                    if (mouseX >= block6[n].X + 2 & mouseX <= block6[n].X + block_white.Width - 2 & mouseY >= block6[n].Y + 2 & mouseY <= block6[n].Y + block_white.Height - 2)
                    {
                        if (color6[n] == "white")
                        {
                            if (turncount < 2)
                            {
                                if (n == 0)
                                {
                                    texture6[n] = GetTexture2DFromBitmap(block_purple);
                                    color6[n] = "purple";
                                    turncount++;
                                    pointcountp1++;
                                    if (color6[n + 1] == "green")
                                    {
                                        extraturncountp1++;
                                        extraturncountp1++;
                                    }
                                    if (extraturncountp1 > 0)
                                    {
                                        extraturncountp1--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color6[n - 1] == "purple")
                                    {
                                        texture6[n] = GetTexture2DFromBitmap(block_purple);
                                        color6[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                        if (color6[n + 1] == "green")
                                        {
                                            extraturncountp1++;
                                            extraturncountp1++;
                                        }
                                        if (extraturncountp1 > 0)
                                        {
                                            extraturncountp1--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 9)
                                {
                                    if (color6[n - 1] == "purple")
                                    {
                                        texture6[n] = GetTexture2DFromBitmap(block_purple);
                                        color6[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                    }
                                }
                            }
                            else if (turncount > 1)
                            {
                                if (n == 9)
                                {
                                    texture6[n] = GetTexture2DFromBitmap(block_green);
                                    color6[n] = "green";
                                    turncount++;
                                    pointcountp2++;
                                    if (color6[n - 1] == "purple")
                                    {
                                        extraturncountp2++;
                                        extraturncountp2++;
                                    }
                                    if (extraturncountp2 > 0)
                                    {
                                        extraturncountp2--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color6[n + 1] == "green")
                                    {
                                        texture6[n] = GetTexture2DFromBitmap(block_green);
                                        color6[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                        if (color6[n - 1] == "purple")
                                        {
                                            extraturncountp2++;
                                            extraturncountp2++;
                                        }
                                        if (extraturncountp2 > 0)
                                        {
                                            extraturncountp2--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 0)
                                {
                                    if (color6[n + 1] == "green")
                                    {
                                        texture6[n] = GetTexture2DFromBitmap(block_green);
                                        color6[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                    }
                                }
                            }
                        }
                    }
                    if (mouseX >= block7[n].X + 2 & mouseX <= block7[n].X + block_white.Width - 2 & mouseY >= block7[n].Y + 2 & mouseY <= block7[n].Y + block_white.Height - 2)
                    {
                        if (color7[n] == "white")
                        {
                            if (turncount < 2)
                            {
                                if (n == 0)
                                {
                                    texture7[n] = GetTexture2DFromBitmap(block_purple);
                                    color7[n] = "purple";
                                    turncount++;
                                    pointcountp1++;
                                    if (color7[n + 1] == "green")
                                    {
                                        extraturncountp1++;
                                        extraturncountp1++;
                                    }
                                    if (extraturncountp1 > 0)
                                    {
                                        extraturncountp1--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color7[n - 1] == "purple")
                                    {
                                        texture7[n] = GetTexture2DFromBitmap(block_purple);
                                        color7[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                        if (color7[n + 1] == "green")
                                        {
                                            extraturncountp1++;
                                            extraturncountp1++;
                                        }
                                        if (extraturncountp1 > 0)
                                        {
                                            extraturncountp1--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 9)
                                {
                                    if (color7[n - 1] == "purple")
                                    {
                                        texture7[n] = GetTexture2DFromBitmap(block_purple);
                                        color7[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                    }
                                }
                            }
                            else if (turncount > 1)
                            {
                                if (n == 9)
                                {
                                    texture7[n] = GetTexture2DFromBitmap(block_green);
                                    color7[n] = "green";
                                    turncount++;
                                    pointcountp2++;
                                    if (color7[n - 1] == "purple")
                                    {
                                        extraturncountp2++;
                                        extraturncountp2++;
                                    }
                                    if (extraturncountp2 > 0)
                                    {
                                        extraturncountp2--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color7[n + 1] == "green")
                                    {
                                        texture7[n] = GetTexture2DFromBitmap(block_green);
                                        color7[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                        if (color7[n - 1] == "purple")
                                        {
                                            extraturncountp2++;
                                            extraturncountp2++;
                                        }
                                        if (extraturncountp2 > 0)
                                        {
                                            extraturncountp2--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 0)
                                {
                                    if (color7[n + 1] == "green")
                                    {
                                        texture7[n] = GetTexture2DFromBitmap(block_green);
                                        color7[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                    }
                                }
                            }
                        }
                    }
                    if (mouseX >= block8[n].X + 2 & mouseX <= block8[n].X + block_white.Width - 2 & mouseY >= block8[n].Y + 2 & mouseY <= block8[n].Y + block_white.Height - 2)
                    {
                        if (color8[n] == "white")
                        {
                            if (turncount < 2)
                            {
                                if (n == 0)
                                {
                                    texture8[n] = GetTexture2DFromBitmap(block_purple);
                                    color8[n] = "purple";
                                    turncount++;
                                    pointcountp1++;
                                    if (color8[n + 1] == "green")
                                    {
                                        extraturncountp1++;
                                        extraturncountp1++;
                                    }
                                    if (extraturncountp1 > 0)
                                    {
                                        extraturncountp1--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color8[n - 1] == "purple")
                                    {
                                        texture8[n] = GetTexture2DFromBitmap(block_purple);
                                        color8[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                        if (color8[n + 1] == "green")
                                        {
                                            extraturncountp1++;
                                            extraturncountp1++;
                                        }
                                        if (extraturncountp1 > 0)
                                        {
                                            extraturncountp1--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 9)
                                {
                                    if (color8[n - 1] == "purple")
                                    {
                                        texture8[n] = GetTexture2DFromBitmap(block_purple);
                                        color8[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                    }
                                }
                            }
                            else if (turncount > 1)
                            {
                                if (n == 9)
                                {
                                    texture8[n] = GetTexture2DFromBitmap(block_green);
                                    color8[n] = "green";
                                    turncount++;
                                    pointcountp2++;
                                    if (color8[n - 1] == "purple")
                                    {
                                        extraturncountp2++;
                                        extraturncountp2++;
                                    }
                                    if (extraturncountp2 > 0)
                                    {
                                        extraturncountp2--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color8[n + 1] == "green")
                                    {
                                        texture8[n] = GetTexture2DFromBitmap(block_green);
                                        color8[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                        if (color8[n - 1] == "purple")
                                        {
                                            extraturncountp2++;
                                            extraturncountp2++;
                                        }
                                        if (extraturncountp2 > 0)
                                        {
                                            extraturncountp2--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 0)
                                {
                                    if (color8[n + 1] == "green")
                                    {
                                        texture8[n] = GetTexture2DFromBitmap(block_green);
                                        color8[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                    }
                                }
                            }
                        }
                    }
                    if (mouseX >= block9[n].X + 2 & mouseX <= block9[n].X + block_white.Width - 2 & mouseY >= block9[n].Y + 2 & mouseY <= block9[n].Y + block_white.Height - 2)
                    {
                        if (color9[n] == "white")
                        {
                            if (turncount < 2)
                            {
                                if (n == 0)
                                {
                                    texture9[n] = GetTexture2DFromBitmap(block_purple);
                                    color9[n] = "purple";
                                    turncount++;
                                    pointcountp1++;
                                    if (color9[n + 1] == "green")
                                    {
                                        extraturncountp1++;
                                        extraturncountp1++;
                                    }
                                    if (extraturncountp1 > 0)
                                    {
                                        extraturncountp1--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color9[n - 1] == "purple")
                                    {
                                        texture9[n] = GetTexture2DFromBitmap(block_purple);
                                        color9[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                        if (color9[n + 1] == "green")
                                        {
                                            extraturncountp1++;
                                            extraturncountp1++;
                                        }
                                        if (extraturncountp1 > 0)
                                        {
                                            extraturncountp1--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 9)
                                {
                                    if (color9[n - 1] == "purple")
                                    {
                                        texture9[n] = GetTexture2DFromBitmap(block_purple);
                                        color9[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                    }
                                }
                            }
                            else if (turncount > 1)
                            {
                                if (n == 9)
                                {
                                    texture9[n] = GetTexture2DFromBitmap(block_green);
                                    color9[n] = "green";
                                    turncount++;
                                    pointcountp2++;
                                    if (color9[n - 1] == "purple")
                                    {
                                        extraturncountp2++;
                                        extraturncountp2++;
                                    }
                                    if (extraturncountp2 > 0)
                                    {
                                        extraturncountp2--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color9[n + 1] == "green")
                                    {
                                        texture9[n] = GetTexture2DFromBitmap(block_green);
                                        color9[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                        if (color9[n - 1] == "purple")
                                        {
                                            extraturncountp2++;
                                            extraturncountp2++;
                                        }
                                        if (extraturncountp2 > 0)
                                        {
                                            extraturncountp2--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 0)
                                {
                                    if (color9[n + 1] == "green")
                                    {
                                        texture9[n] = GetTexture2DFromBitmap(block_green);
                                        color9[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                    }
                                }
                            }
                        }
                    }
                    if (mouseX >= block10[n].X + 2 & mouseX <= block10[n].X + block_white.Width - 2 & mouseY >= block10[n].Y + 2 & mouseY <= block10[n].Y + block_white.Height - 2)
                    {
                        if (color10[n] == "white")
                        {
                            if (turncount < 2)
                            {
                                if (n == 0)
                                {
                                    texture10[n] = GetTexture2DFromBitmap(block_purple);
                                    color10[n] = "purple";
                                    turncount++;
                                    pointcountp1++;
                                    if (color10[n + 1] == "green")
                                    {
                                        extraturncountp1++;
                                        extraturncountp1++;
                                    }
                                    if (extraturncountp1 > 0)
                                    {
                                        extraturncountp1--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color10[n - 1] == "purple")
                                    {
                                        texture10[n] = GetTexture2DFromBitmap(block_purple);
                                        color10[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                        if (color10[n + 1] == "green")
                                        {
                                            extraturncountp1++;
                                            extraturncountp1++;
                                        }
                                        if (extraturncountp1 > 0)
                                        {
                                            extraturncountp1--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 9)
                                {
                                    if (color10[n - 1] == "purple")
                                    {
                                        texture10[n] = GetTexture2DFromBitmap(block_purple);
                                        color10[n] = "purple";
                                        turncount++;
                                        pointcountp1++;
                                    }
                                }
                            }
                            else if (turncount > 1)
                            {
                                if (n == 9)
                                {
                                    texture10[n] = GetTexture2DFromBitmap(block_green);
                                    color10[n] = "green";
                                    turncount++;
                                    pointcountp2++;
                                    if (color10[n - 1] == "purple")
                                    {
                                        extraturncountp2++;
                                        extraturncountp2++;
                                    }
                                    if (extraturncountp2 > 0)
                                    {
                                        extraturncountp2--;
                                        turncount--;
                                    }
                                }
                                else if (n > 0 & n < 9)
                                {
                                    if (color10[n + 1] == "green")
                                    {
                                        texture10[n] = GetTexture2DFromBitmap(block_green);
                                        color10[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                        if (color10[n - 1] == "purple")
                                        {
                                            extraturncountp2++;
                                            extraturncountp2++;
                                        }
                                        if (extraturncountp2 > 0)
                                        {
                                            extraturncountp2--;
                                            turncount--;
                                        }
                                    }
                                }
                                else if (n == 0)
                                {
                                    if (color10[n + 1] == "green")
                                    {
                                        texture10[n] = GetTexture2DFromBitmap(block_green);
                                        color10[n] = "green";
                                        turncount++;
                                        pointcountp2++;
                                    }
                                }
                            }
                        }
                    }
                }
                if (turncount > 3)
                    turncount = 0;
            }
            base.Draw();
            Editor.spriteBatch.Begin();
            Editor.BackgroundColor = Microsoft.Xna.Framework.Color.Black;
            if (turncount < 2)
            {
                Editor.spriteBatch.DrawString(Editor.Font, "> Player 1", new Vector2(
                (Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString("> Player 1").X / 2) - 400,
                (Editor.graphics.Viewport.Height / 2) - (Editor.FontHeight / 2) - 25),
                Microsoft.Xna.Framework.Color.White);
            }
            else
            {
                Editor.spriteBatch.DrawString(Editor.Font, "Player 1", new Vector2(
                (Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString("Player 1").X / 2) - 400,
                (Editor.graphics.Viewport.Height / 2) - (Editor.FontHeight / 2) - 25),
                Microsoft.Xna.Framework.Color.White);
            }
            Editor.spriteBatch.DrawString(Editor.Font, pointcountp1.ToString(), new Vector2(
                (Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString(pointcountp1.ToString()).X / 2) - 400,
                (Editor.graphics.Viewport.Height / 2) - (Editor.FontHeight / 2) + 25),
                Microsoft.Xna.Framework.Color.White);
            if (turncount > 1)
            {
                Editor.spriteBatch.DrawString(Editor.Font, "> Player 2", new Vector2(
                (Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString("> Player 2").X / 2) + 400,
                (Editor.graphics.Viewport.Height / 2) - (Editor.FontHeight / 2) - 25),
                Microsoft.Xna.Framework.Color.White);
            }
            else
            {
                Editor.spriteBatch.DrawString(Editor.Font, "Player 2", new Vector2(
                (Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString("Player 2").X / 2) + 400,
                (Editor.graphics.Viewport.Height / 2) - (Editor.FontHeight / 2) - 25),
                Microsoft.Xna.Framework.Color.White);
            }
            Editor.spriteBatch.DrawString(Editor.Font, pointcountp2.ToString(), new Vector2(
                (Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString(pointcountp2.ToString()).X / 2) + 400,
                (Editor.graphics.Viewport.Height / 2) - (Editor.FontHeight / 2) + 25),
                Microsoft.Xna.Framework.Color.White);
            for (int n = 0; n < 10; n++)
            {
                Editor.spriteBatch.Draw(texture1[n], new Vector2(block1[n].X, block1[n].Y), Microsoft.Xna.Framework.Color.White);
                Editor.spriteBatch.Draw(texture2[n], new Vector2(block2[n].X, block2[n].Y), Microsoft.Xna.Framework.Color.White);
                Editor.spriteBatch.Draw(texture3[n], new Vector2(block3[n].X, block3[n].Y), Microsoft.Xna.Framework.Color.White);
                Editor.spriteBatch.Draw(texture4[n], new Vector2(block4[n].X, block4[n].Y), Microsoft.Xna.Framework.Color.White);
                Editor.spriteBatch.Draw(texture5[n], new Vector2(block5[n].X, block5[n].Y), Microsoft.Xna.Framework.Color.White);
                Editor.spriteBatch.Draw(texture6[n], new Vector2(block6[n].X, block6[n].Y), Microsoft.Xna.Framework.Color.White);
                Editor.spriteBatch.Draw(texture7[n], new Vector2(block7[n].X, block7[n].Y), Microsoft.Xna.Framework.Color.White);
                Editor.spriteBatch.Draw(texture8[n], new Vector2(block8[n].X, block8[n].Y), Microsoft.Xna.Framework.Color.White);
                Editor.spriteBatch.Draw(texture9[n], new Vector2(block9[n].X, block9[n].Y), Microsoft.Xna.Framework.Color.White);
                Editor.spriteBatch.Draw(texture10[n], new Vector2(block10[n].X, block10[n].Y), Microsoft.Xna.Framework.Color.White);
            }
            Editor.spriteBatch.End();
        }
        public Texture2D GetTexture2DFromBitmap(Bitmap bmp)
        {
            Texture2D tx = null;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                ms.Seek(0, System.IO.SeekOrigin.Begin);
                tx = Texture2D.FromStream(Editor.graphics, ms);
            }
            return tx;
        }
    }
}