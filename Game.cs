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

        int StarCount = 0;

        bool StarSwitch = false;

        Color Background = new Color(24, 18, 31);

        int[] starXPosition = new int[15];
        int[] starYPosition = new int[15];

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Baraa Enshassi A2");
            Window.SetSize(600, 600);
            Window.TargetFPS = 60;

            Window.ClearBackground(Background);

            StarSetup();

        }

        public void StarSetup()
        {
            Draw.FillColor = Background;
            int xStar1Position = Random.Integer(30, 500);
            int yStar1Position = Random.Integer(30, 300);
            Draw.Circle(xStar1Position, yStar1Position, 5);

            //int[] starXPosition = [xStar0Position, xStar1Position, xStar2Position, xStar3Position, xStar4Position, xStar5Position, xStar5Position, xStar6Position, xStar7Position, xStar8Position, xStar9Position, xStar10Position, xStar11Position, xStar12Position, xStar13Position, xStar14Position];
            //int[] starYPosition = [yStar0Position, yStar1Position, yStar2Position, yStar3Position, yStar4Position, yStar5Position, yStar5Position, yStar6Position, yStar7Position, yStar8Position, yStar9Position, yStar10Position, yStar11Position, yStar12Position, yStar13Position, yStar14Position];

            for (int i = 0; i < 15; i++)
            {
                starXPosition[i] = Random.Integer(50, 500);
                starYPosition[i] = Random.Integer(50, 250);
            }
        }

        public void DudeChillin()
        {
            Draw.LineSize = 0;
            Draw.FillColor = new Color(13, 23, 12);
            Draw.Rectangle(0, 420, 600, 200);

            Draw.FillColor = Color.Black;
            Draw.Circle(445, 320, 35);

            Draw.Quad(420, 340, 470, 340, 420, 420, 370, 420);

            Draw.Triangle(420, 340, 440, 420, 420, 420);

            Draw.Triangle(450, 340, 490, 420, 450, 420);

            Draw.Triangle(340, 350, 390, 420, 310, 420);

            Draw.Triangle(380, 350, 430, 420, 350, 420);

 
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Background);

            DudeChillin();

            //(condition) StarSwitch = !StarSwitch

            for (int i = 0; i < 15; i++)
            {
                Draw.LineSize = 0;
                Draw.FillColor = new Color(255, 255, 227);
                Draw.Circle(starXPosition[i], starXPosition[i], 5);
            }
        }
    }

}
