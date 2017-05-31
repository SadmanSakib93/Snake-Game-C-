using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace SNAKE_GAME
{
    public partial class Game : Form
    {
        static int[] x = new int[1000];
        static int[] y = new int[1000];
        static int[] x_p = new int[1000];
        static int[] y_p = new int[1000];
        int foodX, foodY;
        int specialFoodX, specialFoodY,specialFoodTimer;
        int snakeMoveDirection, snakeAndFoodWidth, score, textMoveDirectionLeft;
        static int snakeLength;
        static int normalFood;

        bool movingLeft, movingRight, movingDown, movingUp, gamePaused, highScoreDone, specialFoodDraw, specialFoodGone;


        public Game()
        {
            InitializeComponent();
            if(NewGame.level==1)
                gameTimer.Interval = 500 / 4;
            else if (NewGame.level == 2)
                gameTimer.Interval = 300 / 4;
            else if (NewGame.level == 3)
                gameTimer.Interval = 400 / 4;
            gameTimer.Tick += new EventHandler(Update);
            gameTimer.Start();

            System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer();
            tm.Interval = 100;
            tm.Tick += new EventHandler(textAnim);
            tm.Start();

            specialFoodGone = true;
            snakeMoveDirection = 0;
            textMoveDirectionLeft = 0;
            score = 0;
            snakeAndFoodWidth = 10;
            x[0] = y[0] = 250;
            if(NewGame.level==3)
                y[0] = 300;
            snakeLength = 4;
            normalFood = 0;
            movingLeft = true;
            for (int i = 0; i <= snakeLength; i++)
            {
                x[i + 1] = x[i] + 10;
                y[i + 1] = y[i];
            }
            generateFood();
            generateSpecialFood();

        }


    public static void moveUpFromLeft() {
        x_p[0] = x[0];
        y_p[0] = y[0];
        y[0] = y[0] - 10;

        for (int i = 1; i <= snakeLength; i++)
        {
            x_p[i] = x[i];
            y_p[i] = y[i];
            x[i] = x_p[i - 1];
            y[i] = y_p[i - 1];


        }
    }

    public static void moveDownFromLeft() {
        x_p[0] = x[0];
        y_p[0] = y[0];
        y[0] = y[0] + 10;

        for (int i = 1; i <= snakeLength; i++)
        {
            x_p[i] = x[i];
            y_p[i] = y[i];
            x[i] = x_p[i - 1];
            y[i] = y_p[i - 1];


        }
    }

    public static void moveLeftFromUp() {
        x_p[0] = x[0];
        y_p[0] = y[0];
        x[0] = x[0] - 10;

        for (int i = 1; i <= snakeLength; i++)
        {
            x_p[i] = x[i];
            y_p[i] = y[i];
            x[i] = x_p[i - 1];
            y[i] = y_p[i - 1];
        }


    }

    public static void moveRightFromUp() {
        x_p[0] = x[0];
        y_p[0] = y[0];
        x[0] = x[0] + 10;

        for (int i = 1; i <= snakeLength; i++)
        {
            x_p[i] = x[i];
            y_p[i] = y[i];
            x[i] = x_p[i - 1];
            y[i] = y_p[i - 1];
        }
    }

    public static void moveUpFromRight() {
        x_p[0] = x[0];
        y_p[0] = y[0];
        y[0] = y[0] - 10;

        for (int i = 1; i <= snakeLength; i++)
        {
            x_p[i] = x[i];
            y_p[i] = y[i];
            x[i] = x_p[i - 1];
            y[i] = y_p[i - 1];
        }
    }

    public static void moveDownFromRight() {
        x_p[0] = x[0];
        y_p[0] = y[0];
        y[0] = y[0] + 10;

        for (int i = 1; i <= snakeLength; i++)
        {
            x_p[i] = x[i];
            y_p[i] = y[i];
            x[i] = x_p[i - 1];
            y[i] = y_p[i - 1];
        }
    }

    public static void moveLeftFromDown() {
        x_p[0] = x[0];
        y_p[0] = y[0];
        x[0] = x[0] - 10;


        for (int i = 1; i <= snakeLength; i++)
        {
            x_p[i] = x[i];
            y_p[i] = y[i];
            x[i] = x_p[i - 1];
            y[i] = y_p[i - 1];
        }
    }

    public static void moveRightFromDown() {
        x_p[0] = x[0];
        y_p[0] = y[0];
        x[0] = x[0] + 10;


        for (int i = 1; i <= snakeLength; i++)
        {
            x_p[i] = x[i];
            y_p[i] = y[i];
            x[i] = x_p[i - 1];
            y[i] = y_p[i - 1];
        }
    }
       
        
        public void generateFood()
        {
            Random random = new Random();
            foodX = random.Next(10, 550);
            foodY = random.Next(60, 440);

        }
        public void generateSpecialFood()
        {
            Random random = new Random();
            specialFoodX = random.Next(10, 550);
            specialFoodY = random.Next(60, 440);

        }


        public void foodCheck()
        {
            // For CLASSIC & ADVANCED LEVEL
            if (NewGame.level == 1 || NewGame.level == 2)
            {
                if (movingLeft)
                {
                    if ((x[0] <= foodX + snakeAndFoodWidth) && (x[0] >= foodX) && (y[0] >= foodY - snakeAndFoodWidth) && (y[0] <= foodY + snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        score++;
                        generateFood();
                        if (specialFoodDraw)
                        {
                            specialFoodTimer = 0;
                            generateSpecialFood();
                        }
                    }
                }

                else if (movingRight)
                {
                    if ((x[0] + snakeAndFoodWidth >= foodX) && (x[0] + snakeAndFoodWidth <= foodX + snakeAndFoodWidth) && (y[0] >= foodY - snakeAndFoodWidth) && (y[0] <= foodY + snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        score++;
                        generateFood();
                        if (specialFoodDraw)
                        {
                            specialFoodTimer = 0;
                            generateSpecialFood();
                        }
                    }
                }
                else if (movingUp)
                {
                    if ((y[0] <= foodY + snakeAndFoodWidth) && (y[0] >= foodY) && (x[0] <= foodX + snakeAndFoodWidth) && (x[0] >= foodX - snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        score++;
                        generateFood();
                        if (specialFoodDraw)
                        {
                            specialFoodTimer = 0;
                            generateSpecialFood();
                        }
                    }
                }
                else if (movingDown)
                {
                    if ((y[0] + snakeAndFoodWidth >= foodY) && (y[0] + snakeAndFoodWidth <= foodY + snakeAndFoodWidth) && (x[0] <= foodX + snakeAndFoodWidth) && (x[0] >= foodX - snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        score++;
                        generateFood();
                        if (specialFoodDraw)
                        {
                            specialFoodTimer = 0;
                            generateSpecialFood();
                        }
                    }
                }
            }

                // For SPECIAL LEVEL
            else
            {
                if (movingLeft)
                {
                    if ((x[0] <= foodX + snakeAndFoodWidth) && (x[0] >= foodX) && (y[0] >= foodY - snakeAndFoodWidth) && (y[0] <= foodY + snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        score++;
                        generateFood();
                        if (specialFoodDraw)
                        {
                            specialFoodTimer = 0;
                            generateSpecialFood();
                        }
                    }
                }
                if (movingLeft)
                {
                    if ((x[0] <= foodX + snakeAndFoodWidth) && (x[0] >= foodX) && (y[0] - 150 >= foodY - snakeAndFoodWidth) && (y[0] - 150 <= foodY + snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        score++;
                        generateFood();
                        if (specialFoodDraw)
                        {
                            specialFoodTimer = 0;
                            generateSpecialFood();
                        };
                    }
                }

                if (movingRight)
                {
                    if ((x[0] + snakeAndFoodWidth >= foodX) && (x[0] + snakeAndFoodWidth <= foodX + snakeAndFoodWidth) && (y[0] >= foodY - snakeAndFoodWidth) && (y[0] <= foodY + snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        score++;
                        generateFood();
                        if (specialFoodDraw)
                        {
                            specialFoodTimer = 0;
                            generateSpecialFood();
                        }
                    }
                }
                if (movingRight)
                {
                    if ((x[0] + snakeAndFoodWidth >= foodX) && (x[0] + snakeAndFoodWidth <= foodX + snakeAndFoodWidth) && (y[0]-150 >= foodY - snakeAndFoodWidth) && (y[0]-150 <= foodY + snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        score++;
                        generateFood();
                        if (specialFoodDraw)
                        {
                            specialFoodTimer = 0;
                            generateSpecialFood();
                        }
                    }
                }
                if (movingUp)
                {
                    if ((y[0] <= foodY + snakeAndFoodWidth) && (y[0] >= foodY) && (x[0] <= foodX + snakeAndFoodWidth) && (x[0] >= foodX - snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        score++;
                        generateFood();
                        if (specialFoodDraw)
                        {
                            specialFoodTimer = 0;
                            generateSpecialFood();
                        }
                    }
                }
                if (movingUp)
                {
                    if ((y[0] - 150 <= foodY + snakeAndFoodWidth) && (y[0] - 150 >= foodY) && (x[0] <= foodX + snakeAndFoodWidth) && (x[0] >= foodX - snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        score++;
                        generateFood();
                        if (specialFoodDraw)
                        {
                            specialFoodTimer = 0;
                            generateSpecialFood();
                        }
                    }
                }
                if (movingDown)
                {
                    if ((y[0] + snakeAndFoodWidth >= foodY) && (y[0] + snakeAndFoodWidth <= foodY + snakeAndFoodWidth) && (x[0] <= foodX + snakeAndFoodWidth) && (x[0] >= foodX - snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        score++;
                        generateFood();
                        if (specialFoodDraw)
                        {
                            specialFoodTimer = 0;
                            generateSpecialFood();
                        }
                    }
                }
                if (movingDown)
                {
                    if ((y[0]-150 + snakeAndFoodWidth >= foodY) && (y[0]-150 + snakeAndFoodWidth <= foodY + snakeAndFoodWidth) && (x[0] <= foodX + snakeAndFoodWidth) && (x[0] >= foodX - snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        score++;
                        generateFood();
                        if (specialFoodDraw)
                        {
                            specialFoodTimer = 0;
                            generateSpecialFood();
                        }
                    }
                }
            }
        }


        public void specialFoodCheck()
        {
            // For CLASSIC & ADVANCED LEVEL
            if (NewGame.level == 1 || NewGame.level == 2)
            {
                if (movingLeft)
                {
                    if ((x[0] <= specialFoodX + snakeAndFoodWidth) && (x[0] >= specialFoodX) && (y[0] >= specialFoodY - snakeAndFoodWidth) && (y[0] <= specialFoodY + snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        if (NewGame.level == 1)
                            score = score + 5;
                        if (NewGame.level == 2)
                            score = score + 10;
                        if (NewGame.level == 3)
                            score = score +15;

                        generateFood();
                        generateSpecialFood();
                        specialFoodDraw = false;
                        specialFoodTimer = 0;

                    }
                }

                else if (movingRight)
                {
                    if ((x[0] + snakeAndFoodWidth >= specialFoodX) && (x[0] + snakeAndFoodWidth <= specialFoodX + snakeAndFoodWidth) && (y[0] >= specialFoodY - snakeAndFoodWidth) && (y[0] <= specialFoodY + snakeAndFoodWidth))
                    {
                        snakeLength++;
                        normalFood++;
                        if (NewGame.level == 1)
                            score = score + 5;
                        if (NewGame.level == 2)
                            score = score + 10;
                        if (NewGame.level == 3)
                            score = score + 15;
                        generateFood();
                        generateSpecialFood();
                        specialFoodDraw = false;
                        specialFoodTimer = 0;

                    }
                }
                else if (movingUp)
                {
                    if ((y[0] <= specialFoodY + snakeAndFoodWidth) && (y[0] >= specialFoodY) && (x[0] <= specialFoodX + snakeAndFoodWidth) && (x[0] >= specialFoodX - snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        if (NewGame.level == 1)
                            score = score + 5;
                        if (NewGame.level == 2)
                            score = score + 10;
                        if (NewGame.level == 3)
                            score = score + 15;
                        generateFood();
                        generateSpecialFood();
                        specialFoodDraw = false;
                        specialFoodTimer = 0;
                    }
                }
                else if (movingDown)
                {
                    if ((y[0] + snakeAndFoodWidth >= specialFoodY) && (y[0] + snakeAndFoodWidth <= specialFoodY + snakeAndFoodWidth) && (x[0] <= specialFoodX + snakeAndFoodWidth) && (x[0] >= specialFoodX - snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        if (NewGame.level == 1)
                            score = score + 5;
                        if (NewGame.level == 2)
                            score = score + 10;
                        if (NewGame.level == 3)
                            score = score + 15;
                        generateFood();
                        generateSpecialFood();
                        specialFoodDraw = false;
                        specialFoodTimer = 0;

                    }
                }
            }

                // For SPECIAL LEVEL
            else
            {
                if (movingLeft)
                {
                    if ((x[0] <= specialFoodX + snakeAndFoodWidth) && (x[0] >= specialFoodX) && (y[0] >= specialFoodY - snakeAndFoodWidth) && (y[0] <= specialFoodY + snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        if (NewGame.level == 1)
                            score = score + 5;
                        if (NewGame.level == 2)
                            score = score + 10;
                        if (NewGame.level == 3)
                            score = score + 15;
                        generateFood();
                        generateSpecialFood();
                        specialFoodDraw = false;
                        specialFoodTimer = 0;

                    }
                }
                if (movingLeft)
                {
                    if ((x[0] <= specialFoodX + snakeAndFoodWidth) && (x[0] >= specialFoodX) && (y[0] - 150 >= specialFoodY - snakeAndFoodWidth) && (y[0] - 150 <= specialFoodY + snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        if (NewGame.level == 1)
                            score = score + 5;
                        if (NewGame.level == 2)
                            score = score + 10;
                        if (NewGame.level == 3)
                            score = score + 15;
                        generateFood();
                        generateSpecialFood();
                        specialFoodDraw = false;
                        specialFoodTimer = 0;

                    }
                }

                if (movingRight)
                {
                    if ((x[0] + snakeAndFoodWidth >= specialFoodX) && (x[0] + snakeAndFoodWidth <= specialFoodX + snakeAndFoodWidth) && (y[0] >= specialFoodY - snakeAndFoodWidth) && (y[0] <= specialFoodY+ snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        if (NewGame.level == 1)
                            score = score + 5;
                        if (NewGame.level == 2)
                            score = score + 10;
                        if (NewGame.level == 3)
                            score = score + 15;
                        generateFood();
                        generateSpecialFood();
                        specialFoodDraw = false;
                        specialFoodTimer = 0;

                    }
                }
                if (movingRight)
                {
                    if ((x[0] + snakeAndFoodWidth >= specialFoodX) && (x[0] + snakeAndFoodWidth <= specialFoodX + snakeAndFoodWidth) && (y[0] - 150 >= specialFoodY - snakeAndFoodWidth) && (y[0] - 150 <= specialFoodY + snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        if (NewGame.level == 1)
                            score = score + 5;
                        if (NewGame.level == 2)
                            score = score + 10;
                        if (NewGame.level == 3)
                            score = score + 15;
                        generateFood();
                        generateSpecialFood();
                        specialFoodDraw = false;
                        specialFoodTimer = 0;
                    }
                }
                if (movingUp)
                {
                    if ((y[0] <= specialFoodY + snakeAndFoodWidth) && (y[0] >= specialFoodY) && (x[0] <= specialFoodX + snakeAndFoodWidth) && (x[0] >= specialFoodX - snakeAndFoodWidth))
                    {

                        snakeLength++;
                        normalFood++;
                        if (NewGame.level == 1)
                            score = score + 5;
                        if (NewGame.level == 2)
                            score = score + 10;
                        if (NewGame.level == 3)
                            score = score + 15;
                        generateFood();
                        generateSpecialFood();
                        specialFoodDraw = false;
                        specialFoodTimer = 0;

                    }
                }
                if (movingUp)
                {
                    if ((y[0] - 150 <= specialFoodY + snakeAndFoodWidth) && (y[0] - 150 >= specialFoodY) && (x[0] <= specialFoodX + snakeAndFoodWidth) && (x[0] >= specialFoodX - snakeAndFoodWidth))
                    {
                        snakeLength++;
                        normalFood++;
                        if (NewGame.level == 1)
                            score = score + 5;
                        if (NewGame.level == 2)
                            score = score + 10;
                        if (NewGame.level == 3)
                            score = score + 15;
                        generateFood();
                        generateSpecialFood();
                        specialFoodDraw = false;
                        specialFoodTimer = 0;
                    }
                }
                if (movingDown)
                {
                    if ((y[0] + snakeAndFoodWidth >= specialFoodY) && (y[0] + snakeAndFoodWidth <= specialFoodY + snakeAndFoodWidth) && (x[0] <= specialFoodX + snakeAndFoodWidth) && (x[0] >= specialFoodX - snakeAndFoodWidth))
                    {
                        snakeLength++;
                        normalFood++;
                        if (NewGame.level == 1)
                            score = score + 5;
                        if (NewGame.level == 2)
                            score = score + 10;
                        if (NewGame.level == 3)
                            score = score + 15;
                        generateSpecialFood();
                        generateFood();
                        specialFoodDraw = false;
                        specialFoodTimer = 0;
                    }
                }
                if (movingDown)
                {
                    if ((y[0] - 150 + snakeAndFoodWidth >= specialFoodY) && (y[0] - 150 + snakeAndFoodWidth <= specialFoodY + snakeAndFoodWidth) && (x[0] <= specialFoodX + snakeAndFoodWidth) && (x[0] >= specialFoodX - snakeAndFoodWidth))
                    {
                        snakeLength++;
                        normalFood++;
                        if (NewGame.level == 1)
                            score = score + 5;
                        if (NewGame.level == 2)
                            score = score + 10;
                        if (NewGame.level == 3)
                            score = score + 15;
                        generateFood();
                        generateSpecialFood();
                        specialFoodDraw = false;
                        specialFoodTimer = 0;
                    }
                }
            }
        }

        public void snakeSideTouch()
        {
            if (NewGame.level == 1 )
            {
                for (int i = 0; i <= snakeLength; i++)
                {
                    if (x[i] <= 0)
                    {
                        x[i] = x[i] + gameBox.Size.Width;
                    }
                }
                for (int i = 0; i <= snakeLength; i++)
                {
                    if ( x[i] >= gameBox.Size.Width)
                    {
                        x[i] = 0;
                    }
                }

                for (int i = 0; i <= snakeLength; i++)
                {
                    if (y[i] <= -10)
                    {
                        y[i] = y[i] +gameBox.Size.Height+ 10;
                    }
                }
                for (int i = 0; i <= snakeLength; i++)
                {
                    if (y[i] + snakeAndFoodWidth >= gameBox.Size.Height+50 )
                    {
                        y[i] = 0;
                    }
                }
            }


            else if (NewGame.level == 2 || NewGame.level == 3)
            {
                if (x[0] <= -10)
                {
                    gameOver();
                }
                if (x[0] >= gameBox.Size.Width)
                {
                    gameOver();
                }
                if (y[0] <= -10)
                {
                    gameOver();
                }
                if (y[0] + snakeAndFoodWidth >= gameBox.Size.Height +10)
                {
                    gameOver();
                }
            }

        }
        public void gameOverCheck()
        {
            for (int z = 1; z <= snakeLength; z++)
            {
                if (x[0] == x[z] && y[0] == y[z])
                {
                    gameOver();
                    
                }
            }

        }
        public void gameOver()
        {

            if (SNAKE_GAME.Menu.currentHighScore < score)
            {
                highScoreDone = true;
                StreamWriter highScoreWrite = new StreamWriter("High Score.txt");
                highScoreWrite.Write(score);
                highScoreWrite.Close();
            }


            Thread gameOverThread;
            movingUp = movingDown = movingLeft = movingRight = false;
            snakeMoveDirection = -1;
            this.Close();
            gameOverThread = new Thread(openNewGame);
            gameOverThread.SetApartmentState(ApartmentState.STA);
            gameOverThread.Start();
        }

        

        private void openNewGame()
        {
            if(!highScoreDone)
                Application.Run(new GameOverForm());
            else
                Application.Run(new GameOverHighScoreForm());
        }
                
            
        

        private void Update(object sender, EventArgs e)
        {
            if (snakeMoveDirection == 0)
            {
                for (int i = 0; i <= snakeLength; i++)
                    x[i] = x[i] - 10;
            }
            //Move UP from LEFT (at first)
            if (snakeMoveDirection == 1)
            {
                moveUpFromLeft();
            }
            //Move DOWN from LEFT (at first)
            else if (snakeMoveDirection == 2)
            {
                moveDownFromLeft();
            }

            //Move LEFT from UP
            else if (snakeMoveDirection == 3)
            {
                moveLeftFromUp();
            }

            //Move RIGHT from UP
            else if (snakeMoveDirection == 4)
            {
                moveRightFromUp();
            }

            //Move UP from RIGHT
            else if (snakeMoveDirection == 5)
            {
                moveUpFromRight();
            }

            //Move DOWN from RIGHT
            else if (snakeMoveDirection == 6)
            {
                moveDownFromRight();
            }
            //Move LEFT from DOWN
            else if (snakeMoveDirection == 7)
            {
                moveLeftFromDown();
            }

            //Move RIGHT from DOWN
            else if (snakeMoveDirection == 8)
            {
                moveRightFromDown();
            }

            foodCheck();
            if (specialFoodDraw)
                specialFoodCheck();
            snakeSideTouch();
            gameOverCheck();
            gameBox.Invalidate();
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = gameBox.CreateGraphics();

            if (normalFood != 0 && normalFood % 5 == 0 && specialFoodGone)
                specialFoodDraw = true;
            if (normalFood % 5 != 0)
            {
                specialFoodDraw = false;
                specialFoodGone = true;
            }


            //FOOD//
            Brush foodColor = Brushes.Green;
            canvas.FillRectangle(foodColor, foodX, foodY, 10, 10);


            //SPECIAL FOOD//

            if (specialFoodDraw && specialFoodTimer<50)
                {
                    Random randonGen = new Random();

                    Brush specialFoodColor = new System.Drawing.SolidBrush(Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255)));
                    canvas.FillRectangle(specialFoodColor, specialFoodX, specialFoodY, 10, 10);
                    specialFoodTimer++;

                    if (specialFoodTimer == 50)
                    {
                        specialFoodTimer = 0;
                        specialFoodDraw = false;
                        specialFoodGone = false;

                    }

                }


            //SNAKE//
            if (NewGame.level == 1 || NewGame.level == 2)
            {
                for (int i = 0; i < snakeLength; i++)
                {
                    Brush snake_color = i == 0 ? Brushes.Red : Brushes.Black;
                    canvas.FillRectangle(snake_color, new Rectangle(x[i], y[i], 10, 10));
                }
            }
            else
            {
                for (int i = 0; i < snakeLength; i++)
                {
                    Brush snake_color = i == 0 ? Brushes.Red : Brushes.Black;
                    canvas.FillRectangle(snake_color, new Rectangle(x[i], y[i], 10, 10));
                }
                for (int i = 0; i < snakeLength; i++)
                {
                    Brush snake_color = i == 0 ? Brushes.Black : Brushes.Red;
                    canvas.FillRectangle(snake_color, new Rectangle(x[i], y[i]-150, 10, 10));
                }
            }


            //SCORE
            scoreLabel.Text = "Score: " +score ;

            //Animation
            if (NewGame.level == 1)
                animLabel.Text = "CLASSIC LEVEL";
            if (NewGame.level == 2)
                animLabel.Text = "ADVANCE LEVEL";
            if (NewGame.level == 3)
                animLabel.Text = "SPECIAL LEVEL";

            //PAUSE AND RESUME
            if (gamePaused)
                pauseResume.Text = "Press ENTER to RESUME";
            if(!gamePaused)
                pauseResume.Text = "Press P to PAUSE";

            
        }

            private void textAnim(object sender, EventArgs e)
            {


                if(textMoveDirectionLeft==0)
                {
                    animLabel.Location = new Point(animLabel.Location.X + 2, animLabel.Location.Y);
                    if (animLabel.Location.X >= gameBox.Size.Width - animLabel.Size.Width+10)
                       textMoveDirectionLeft=1;
                }

 
                if(textMoveDirectionLeft==1)
                {
                    animLabel.Location = new Point(animLabel.Location.X - 2, animLabel.Location.Y);
                    if(animLabel.Location.X == 0)
                        textMoveDirectionLeft=0;
                }
                
        }
    




        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && movingLeft && !gamePaused) //Move UP from LEFT (at first)
            {
                snakeMoveDirection = 1;
                movingLeft = false;
                movingUp = true;
            }
            if (e.KeyCode == Keys.Down && movingLeft && !gamePaused) //Move DOWN from LEFT (at first)
            {
                snakeMoveDirection = 2;
                movingLeft = false;
                movingDown = true;
            }
            if (e.KeyCode == Keys.Left && movingUp && !gamePaused) //Move LEFT from UP
            {
                snakeMoveDirection = 3;
                movingLeft = true;
                movingUp = false;
            }
            if (e.KeyCode == Keys.Right && movingUp && !gamePaused) //Move RIGHT from UP
            {
                snakeMoveDirection = 4;
                movingRight = true;
                movingUp = false;
            }
            if (e.KeyCode == Keys.Up && movingRight && !gamePaused) //Move UP from RIGHT
            {
                snakeMoveDirection = 5;
                movingRight = false;
                movingUp = true;
            }
            if (e.KeyCode == Keys.Down && movingRight && !gamePaused) //Move DOWN from RIGHT
            {
                snakeMoveDirection = 6;
                movingRight = false;
                movingDown = true;
            }
            if (e.KeyCode == Keys.Left && movingDown && !gamePaused) //Move LEFT from DOWN
            {
                snakeMoveDirection = 7;
                movingLeft = true;
                movingDown = false;
            }
            if (e.KeyCode == Keys.Right && movingDown && !gamePaused) //Move LEFT from DOWN
            {
                snakeMoveDirection = 8;
                movingRight = true;
                movingDown = false;
            }
            if (e.KeyCode == Keys.P && !gamePaused) //Pause Game
            {
                snakeMoveDirection = snakeMoveDirection + 50;
                textMoveDirectionLeft = textMoveDirectionLeft + 50;
                gamePaused = true;
            }
            if (e.KeyCode == Keys.Enter && gamePaused) //Resume Game
            {
                textMoveDirectionLeft = textMoveDirectionLeft - 50;
                snakeMoveDirection = snakeMoveDirection - 50;
                gamePaused = false;
            }
            if (e.KeyCode == Keys.Escape && gamePaused) //ESC while Game Paused
            {
                Thread menuForm;
                this.Close();
                menuForm = new Thread(openMenuOnEsc);
                menuForm.SetApartmentState(ApartmentState.STA);
                menuForm.Start();

            }


        }

        private void openMenuOnEsc()
        {
            Application.Run(new Menu());
        }

    }
}
