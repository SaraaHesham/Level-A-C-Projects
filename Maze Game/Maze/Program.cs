namespace Maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello To Maze Game");
            Console.WriteLine("Use Keyboard Arrows To Move The Player");

            Maze maze = new Maze(40, 20);
            
            while (true)
            {
                maze.Draw();
                maze.MovePlayer();
            }
        }
    }
}
