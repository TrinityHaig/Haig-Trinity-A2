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
            Window.SetTitle("Yippee wahoo game!"); //edit name later DO NOT FORGET.
            Window.SetSize(800,800);
            Window.TargetFPS = 60;
            Window.ClearBackground(Color.Cyan); //placeholder colour since idk what i wanna make yet
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

        }
    }

}
