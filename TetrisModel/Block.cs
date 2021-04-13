using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisModel
{
    public class Block
    {
        public List<Rotation> Rotations { get; set; }
        private int actualRotation = 0;
        public Rotation ActualRotation { get => Rotations[actualRotation]; }

        public Block(List<Rotation> rotations)
        {
            Rotations = rotations;
        }
        public Rotation GetNextRotation()
        {
            var nextRotation = actualRotation < Rotations.Count - 1 ? actualRotation + 1 : 0;
            return Rotations[nextRotation];
        }
        public Block SetNextRotation()
        {
            actualRotation = actualRotation < Rotations.Count - 1 ? actualRotation + 1 : 0;
            return this;
        }
        public Block SetRandomRotation()
        {
            actualRotation = new Random().Next(0, Rotations.Count);
            return this;
        }
    }
}
