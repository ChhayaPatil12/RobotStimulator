using System;
using System.Collections.Generic;

namespace ToyRobotSimulation
{
    public class Tabletop
    {
        public int Width { get; } = 5;
        public int Height { get; } = 5;
    }

    public class Robot
    {
        private Tabletop tabletop;
        public int X { get; private set; }
        public int Y { get; private set; }
        public string Facing { get; private set; }

        public Robot(Tabletop tabletop)
        {
            this.tabletop = tabletop;
        }

        public void Place(int x, int y, string facing)
        {
            if (IsValidPosition(x, y))
            {
                X = x;
                Y = y;
                Facing = facing;
            }
        }

        public void Move()
        {
            switch (Facing)
            {
                case "NORTH":
                    if (Y < tabletop.Height - 1)
                        Y++;
                    break;
                case "SOUTH":
                    if (Y > 0)
                        Y--;
                    break;
                case "EAST":
                    if (X < tabletop.Width - 1)
                        X++;
                    break;
                case "WEST":
                    if (X > 0)
                        X--;
                    break;
            }
        }

        public void Left()
        {
            switch (Facing)
            {
                case "NORTH":
                    Facing = "WEST";
                    break;
                case "WEST":
                    Facing = "SOUTH";
                    break;
                case "SOUTH":
                    Facing = "EAST";
                    break;
                case "EAST":
                    Facing = "NORTH";
                    break;
            }
        }

        public void Right()
        {
            switch (Facing)
            {
                case "NORTH":
                    Facing = "EAST";
                    break;
                case "EAST":
                    Facing = "SOUTH";
                    break;
                case "SOUTH":
                    Facing = "WEST";
                    break;
                case "WEST":
                    Facing = "NORTH";
                    break;
            }
        }

        public string Report()
        {
            return $"{X},{Y},{Facing}";
        }

        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < tabletop.Width && y >= 0 && y < tabletop.Height;
        }
    }

    class Program
    {
        static void Main()
        {
            // Test data
            List<string> commands = new List<string>
            {
                "PLACE 0,0,NORTH",
                "MOVE",
                "REPORT"
            };

            // Process commands
            Tabletop tabletop = new Tabletop();
            Robot robot = new Robot(tabletop);

            foreach (var command in commands)
            {
                ProcessCommand(robot, command);
            }
        }

        static void ProcessCommand(Robot robot, string command)
        {
            var parts = command.Split(" ");
            switch (parts[0])
            {
                case "PLACE":
                    var placeArgs = parts[1].Split(",");
                    robot.Place(int.Parse(placeArgs[0]), int.Parse(placeArgs[1]), placeArgs[2]);
                    break;
                case "MOVE":
                    robot.Move();
                    break;
                case "LEFT":
                    robot.Left();
                    break;
                case "RIGHT":
                    robot.Right();
                    break;
                case "REPORT":
                    Console.WriteLine(robot.Report());
                    break;
            }
        }
    }
}
