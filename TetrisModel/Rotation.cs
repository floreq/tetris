using System.Drawing;

namespace TetrisModel
{
    public class Rotation
    {
        public int[,] Body { get; private set; }
        public int BodyCharacter { get; private set; }
        public Point FromFirstBodyCharacterDiff { get; set; }

        public Rotation(int[,] body, Point fromFirstBodyCharacterDiff, int bodyCharacter = 1)
        {
            Body = body;
            FromFirstBodyCharacterDiff = fromFirstBodyCharacterDiff;
            BodyCharacter = bodyCharacter;
        }
        public Size GetBodySize()
        {
            return new Size(Body.GetLength(1), Body.GetLength(0));
        }
        public Point CalculateCornerDiffrence(Point startPoint)
        {
            return new Point(startPoint.X + FromFirstBodyCharacterDiff.X, startPoint.Y + FromFirstBodyCharacterDiff.Y);
        }
    }
}
