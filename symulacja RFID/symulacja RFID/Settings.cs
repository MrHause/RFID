using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symulacja_RFID
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
        Rightup,
        Rightdown,
        Leftup,
        Leftdown
    };
    class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static int sens_range { get; set; }
        public static int sens_range_temp { get; set; }
        public static int noise { get; set; }
        public static int broken { get; set; }
        public static int vlin { get; set; }
        public static int vrot { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            vlin = 0;
            vrot = 0;
            broken = 0;
            noise = 1;
            sens_range = 3;
            Width = 1;
            Height = 1;
            Speed =10;
            Score = 0;
            Points = 100;
            GameOver = false;
            direction = Direction.Down;
        }
    }
}
