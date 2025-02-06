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
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                Draw.FillColor = Color.White;
            }
            else
            {
                Draw.FillColor = Color.Yellow;
            }
            Draw.Circle(x, y, 5);
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
            tree (60,100);
           
        }
    }

}
