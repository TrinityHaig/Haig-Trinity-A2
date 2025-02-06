// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        float[] x = [60,140,200,340];
        float[] y = [100,240,170,320,30];
        

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Christmas Trees");
            Window.SetSize(400,400);
            Window.TargetFPS = 60;
            
        }

        public void tree(float x, float y)
        {
            
            //The leaves of the Tree are in 3 triangle segments 
            Draw.FillColor = Color.Green;
            Draw.Triangle(x, y, x - 40, y + 80, x + 40, y + 80);

            //rectangle for the stump
            Draw.FillColor = Color.Black;
            Draw.Rectangle(x - 5,y + 80,10,20);
            //star
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                Draw.FillColor = Color.White;
            }
            else
            {
                Draw.FillColor = Color.Yellow;
            }
            Draw.Circle(x, y, 5);
            //baubles start from here
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                Draw.FillColor = Color.Blue;
            }
            else
            {
                Draw.FillColor = Color.Red;
            }
            Draw.Circle(x + 7, y + 50, 5);
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                Draw.FillColor = Color.Red;
            }
            else
            {
                Draw.FillColor = Color.Blue;
            }
            Draw.Circle(x - 8, y + 30, 5);
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                Draw.FillColor = Color.Red;
            }
            else
            {
                Draw.FillColor = Color.Blue;
            }
            Draw.Circle(x - 9, y + 70, 5);
        }
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // mouse placement will change the values to be black hopefully
            float r = 0.1f;
            float g = 0.3f;
            float b = 0.5f;

            ColorF backGround = new ColorF(r, g, b);

            Window.ClearBackground(backGround);
            tree(x[0], y[0]);
            tree(x[1], y[3]);
            tree(x[2], y[1]);
            tree(x[1], y[2]);
            tree(x[0], y[3]);
            tree(x[3], y[2]);
            tree(x[2], y[4]);
            tree(x[3], y[4]);
        }
    }

}
