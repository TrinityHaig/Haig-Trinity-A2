// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

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
            Draw.Triangle(x, y, x - 20, y + 40, x + 20, y + 40);
       
            Draw.FillColor = Color.Black;
            //rectangle for the stump and see if circles will render on top of the tree for the interaactable baubles
            Draw.Rectangle(x, y - 180, 20, 40);
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
            tree (20,60);
            
        }
    }

}
