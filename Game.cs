// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

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
            Draw.Triangle(x, y, x, y, x, y);
            Draw.Triangle(x - 20, y - 20, x - 20, y - 20, x - 20, y - 20);
            Draw.Triangle(x - 40, y - 40, x - 40, y - 40, x - 40, y - 40);
            //rectangle for the stump and see if circles will render on top of the tree for the interaactable baubles
            Draw.Rectangle(x, y - 140, 20, 40);
        }
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // mouse placement will change the values to be black hopefully
            float r = 0.0f;
            float g = 0.0f;
            float b = 1.0f;

            ColorF backGround = new ColorF(r, g, b);

            Window.ClearBackground(backGround);
            
        }
    }

}
