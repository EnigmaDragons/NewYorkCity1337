using Microsoft.Xna.Framework;
using NewYorkCity1337.Graphics;

namespace NewYorkCity1337.Tiles
{
    public class TileLocation
    {
        public int Column { get; }
        public int Row { get; }

        public TileLocation(Vector2 pixelLoc) : this((int)pixelLoc.X / new TileSize().Get(), (int)pixelLoc.Y / new TileSize().Get()) {}

        public TileLocation(int column, int row)
        {
            Column = column;
            Row = row;
        }

        protected bool Equals(TileLocation other)
        {
            return Column == other.Column && Row == other.Row;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((TileLocation) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Column*397) ^ Row;
            }
        }
    }
}
