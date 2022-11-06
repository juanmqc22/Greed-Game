using Raylib_cs;
using Unit04.Game.Casting;


namespace Unit04.Game.Services
{
 
    /// The responsibility of a KeyboardService is to detect player key presses and translate them 
    /// into a point representing a direction.
   
    public class KeyboardService
    {
        private int cellSize = 15;

        /// Constructs a new instance of KeyboardService using the given cell size.
        public KeyboardService(int cellSize)
        {
            this.cellSize = cellSize;
        }

        /// Gets the selected direction based on the currently pressed keys.
        public Point GetDirection()
        {
            int dx = 0;
            int dy = 0;

            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                dx = -1;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                dx = 1;
            }

            Point direction = new Point(dx, dy);
            direction = direction.Scale(cellSize);

            return direction;
        }

        /// Keeps Artifacts in motion.
        public Point MoveArtifact()
        {
            int dx = 0;
            int dy = 1;

            Point direction = new Point(dx, dy);
            direction = direction.Scale(cellSize);

            return direction;
        }
    }
}