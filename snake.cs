using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
///█ ■
////https://www.youtube.com/watch?v=SGZgvMwjq2U
/// 



namespace Snake
{
    class Program
    {
        class Point{
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        class Snake
        {
           public Point position;
            public Snake(int x, int y)
            {
                position =  new Point(x,y);
            }
        }
        class Map
        {

            public int width;
            public int height;
            public  char[, ] map;
            public Map(int height, int width)
            {
                this.width = width;
                this.height = height;
                map = new char[height, width];
                fill();
            } 
            
            public void draw(Snake snake)
            {
                for(int j = 0; j < height; j++)
                {
                    for(int k = 0; k < width; k++)
                    {
                        if (snake.position.y == j && snake.position.x == k)
                            Console.Write("X");
                        else    
                            Console.Write(map[j,k]);

                    }
                        Console.Write("\n");
                }
            }

             public void fill()
            {
                for(int j = 0; j < height; j++)
                {
                    for(int k = 0; k < width; k++)
                    {
                        map[j,k] = '0';
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Map map = new Map(20,20);
            Snake snake = new Snake(10,10);
            DateTime TimeNow = DateTime.Now;
            double waitTime = 200;
            while (true)
            {
            
                if (TimeNow.AddMilliseconds(waitTime) < DateTime.Now)
                {
                    TimeNow = DateTime.Now;
                    Console.Clear();
                    map.draw(snake);
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo toets = Console.ReadKey(true);
                            if (toets.Key.Equals(ConsoleKey.UpArrow))
                            {
                                Console.WriteLine("Hello\n");
                                break;
                            }
                    }
                }
            }
        }
    }
}

// namespace Snake
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WindowHeight = 16;
//             Console.WindowWidth = 32;
//             int screenwidth = Console.WindowWidth;
//             int screenheight = Console.WindowHeight;
//             Random randomnummer = new Random();
//             int score = 5;
//             int gameover = 0;
//             pixel hoofd = new pixel();
//             hoofd.xpos = screenwidth/2;
//             hoofd.ypos = screenheight/2;
//             hoofd.schermkleur = ConsoleColor.Red;
//             string movement = "RIGHT";
//             List<int> xposlijf = new List<int>();
//             List<int> yposlijf = new List<int>();
//             int berryx = randomnummer.Next(0, screenwidth);
//             int berryy = randomnummer.Next(0, screenheight);
//             DateTime tijd = DateTime.Now;
//             DateTime tijd2 = DateTime.Now;
//             string buttonpressed = "no";
//             while (true)
//             {
//                 Console.Clear();

//                 if(hoofd.xpos == 0 ||hoofd.ypos == screenheight-1 || hoofd.ypos == 0)
//                {
//                    gameover = 1;
//                }
//                for (int i = 0;i< screenwidth; i++)
//                {
//                    Console.SetCursorPosition(i, 0);
//                    Console.Write("■");
//                }
//                for (int i = 0; i < screenwidth; i++)
//                {
//                    Console.SetCursorPosition(i, screenheight -1);
//                    Console.Write("■");
//                }
//                for (int i = 0; i < screenheight; i++)
//                {
//                    Console.SetCursorPosition(0, i);
//                    Console.Write("■");
//                }
//                for (int i = 0; i < screenheight; i++)
//                {
//                    Console.SetCursorPosition(screenwidth - 1, i);
//                    Console.Write("■");
//                }
//                Console.ForegroundColor = ConsoleColor.Green;
//                if (berryx == hoofd.xpos && berryy == hoofd.ypos)
//                {
//                    score++;
//                    berryx = randomnummer.Next(1, screenwidth-2);
//                    berryy = randomnummer.Next(1, screenheight-2);
//                }
//                for (int i = 0; i < xposlijf.Count(); i++)
//                {
//                    Console.SetCursorPosition(xposlijf[i], yposlijf[i]);
//                    Console.Write("■");
//                    if (xposlijf[i] == hoofd.xpos && yposlijf[i] == hoofd.ypos)
//                    {
//                        gameover = 1;
//                    }
//                }
//                if (gameover == 1)
//                {
//                    break;
//                }
//                Console.SetCursorPosition(hoofd.xpos, hoofd.ypos);
//                Console.ForegroundColor = hoofd.schermkleur;
//                Console.Write("■");
//                Console.SetCursorPosition(berryx, berryy);
//                Console.ForegroundColor = ConsoleColor.Cyan;
//                Console.Write("■");
//                tijd = DateTime.Now;
//                buttonpressed = "no";
//                while (true)
//                {
//                    tijd2 = DateTime.Now;
//                    if (tijd2.Subtract(tijd).TotalMilliseconds > 500) { break; }
//                    if (Console.KeyAvailable)
//                    {
//                        ConsoleKeyInfo toets = Console.ReadKey(true);
//                        //Console.WriteLine(toets.Key.ToString());
//                        if (toets.Key.Equals(ConsoleKey.UpArrow) && movement != "DOWN" && buttonpressed == "no")
//                        {
//                            movement = "UP";
//                            buttonpressed = "yes";
//                        }
//                        if (toets.Key.Equals(ConsoleKey.DownArrow) && movement != "UP" && buttonpressed == "no")
//                        {
//                            movement = "DOWN";
//                            buttonpressed = "yes";
//                        }
//                        if (toets.Key.Equals(ConsoleKey.LeftArrow) && movement != "RIGHT" && buttonpressed == "no")
//                        {
//                            movement = "LEFT";
//                            buttonpressed = "yes";
//                        }
//                        if (toets.Key.Equals(ConsoleKey.RightArrow) && movement != "LEFT" && buttonpressed == "no")
//                        {
//                            movement = "RIGHT";
//                            buttonpressed = "yes";
//                        }
//                    }
//                }
//                xposlijf.Add(hoofd.xpos);
//                yposlijf.Add(hoofd.ypos);
//                switch (movement)
//                {
//                    case "UP":
//                        hoofd.ypos--;
//                        break;
//                    case "DOWN":
//                        hoofd.ypos++;
//                        break;
//                    case "LEFT":
//                        hoofd.xpos--;
//                        break;
//                    case "RIGHT":
//                        hoofd.xpos++;
//                        break;
//                }
//                if (xposlijf.Count() > score)
//                {
//                    xposlijf.RemoveAt(0);
//                    yposlijf.RemoveAt(0);
//                }
//            }
//            Console.SetCursorPosition(screenwidth / 5, screenheight / 2);
//            Console.WriteLine("Game over, Score: "+ score);
//            Console.SetCursorPosition(screenwidth / 5, screenheight / 2 +1);
//        }
//        class pixel
//        {
//            public int xpos { get; set; }
//            public int ypos { get; set; }
//            public ConsoleColor schermkleur { get; set; }
//        }
//    }
// }
