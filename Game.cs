using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Game
    {
        System.Random rnd = new System.Random();

        bool starsGenerated = false;

        int StarCount;

        int[] starXPosition;
        int[] starYPosition;

        Color Background = new Color(24, 18, 31);

        int frameCounter = 0;

        bool autoUpdate = true;


        public void Setup()
        {
            Window.SetTitle("Baraa Enshassi A2");

            Window.SetSize(600, 600);

            Window.TargetFPS = 60;

            Window.ClearBackground(Background);
        }
        public void StarSetup()
        {
            StarCount = rnd.Next(1, 26);
            starXPosition = new int[StarCount];
            starYPosition = new int[StarCount];

            for (int i = 0; i < StarCount; i++)
            {
                starXPosition[i] = rnd.Next(30, 500);
                starYPosition[i] = rnd.Next(30, 250);
            }

            starsGenerated = true;
        }

        public void Stars()
        {
            if (starsGenerated)
            {
                for (int i = 0; i < StarCount; i++)
                {
                    Draw.FillColor = new Color(255, 255, 227);
                    Draw.Circle(starXPosition[i], starYPosition[i], 5);
                }
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
        public void Update()
        {
            Window.ClearBackground(Background);

            if (autoUpdate)
            {
                frameCounter++;

                if (frameCounter >= 60)
                {
                    starsGenerated = false;

                    StarSetup();

                    frameCounter = 0;
                }
            }
            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                Stars();
            }
            DudeChillin();
        }
    }
}