using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    internal class Maze
    {
        private int _Width { get; set; }
        private int _Height { get; set; }
        private Player _Player;
        private IMazeObject[,] _MazeObjects;
        public Maze(int width,int height) 
        {
            _Width = width;
            _Height = height;
            _MazeObjects = new IMazeObject[width, height];
            _Player = new Player() 
            {
                X = 0,
                Y = 2   
            };
        }
        public void Draw()
        {
            Console.Clear();
            // Draw the maze
            for (int y = 0; y < _Height; y++)
            {
                for (int x = 0; x < _Width; x++)
                {
                    if ((x == 39 && y ==18) || (x == 0 && y ==2))
                    {
                        _MazeObjects[x, y] = new EmptySpace();
                        Console.Write(_MazeObjects[x, y].Icon);
                    }
                    else if (x == 0 || y == 0 || x == _Width -1 || y == _Height -1)
                    {
                        _MazeObjects[x, y] = new Wall();
                        Console.Write(_MazeObjects[x, y].Icon);
                    }
                    else if (x == _Player.X && y == _Player.Y)
                    {
                        Console.Write(_Player.Icon);
                    }
                    else if (x % 3 == 0 && y % 3 == 0)
                    {
                        _MazeObjects[x, y] = new Wall();
                        Console.Write(_MazeObjects[x, y].Icon);
                    }
                    else if (x % 5 == 0 && y % 4 == 0)
                    {
                        _MazeObjects[x, y] = new Wall();
                        Console.Write(_MazeObjects[x, y].Icon);
                    }
                    else if (x % 6 == 0 && y % 7 == 0)
                    {
                        _MazeObjects[x, y] = new Wall();
                        Console.Write(_MazeObjects[x, y].Icon);
                    }
                    else
                    {
                        _MazeObjects[x, y] = new EmptySpace();
                        Console.Write(_MazeObjects[x, y].Icon);
                    }
                }
                Console.WriteLine();
            }
        }
        public void MovePlayer()
        {
            // Move the player to the new position
            ConsoleKeyInfo UserInput = Console.ReadKey();

            ConsoleKey keyPress = UserInput.Key;

            switch(keyPress)
            {
                case ConsoleKey.UpArrow:
                    // Move player up
                    UpdatePlayer(0,-1);
                    break;
                case ConsoleKey.DownArrow:
                    // Move player down
                    UpdatePlayer(0,1);
                    break;
                case ConsoleKey.LeftArrow:
                    // Move player left
                    UpdatePlayer(-1,0);
                    break;
                case ConsoleKey.RightArrow:
                    // Move player right
                    UpdatePlayer(1,0);
                    break;
                default:
                    break;
            }
        }
        public void UpdatePlayer(int dx,int dy)
        {
            // Update the player's position
            int newX = _Player.X + dx;
            int newY = _Player.Y + dy;

            if (newX >= 0 && newX < _Width && newY >= 0 && newY < _Height && _MazeObjects[newX,newY].IsSolid == false)
            {
                _Player.X = newX;
                _Player.Y = newY;
                Draw();
            }
        }
    }
}
