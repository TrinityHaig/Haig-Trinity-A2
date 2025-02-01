﻿// Include the namespaces (code libraries) you need below.
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
