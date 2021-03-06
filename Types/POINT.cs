using System;
using System.Runtime.InteropServices;

namespace TOAPI.Types
{
    [Serializable]
    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct POINT : IEquatable<POINT>
    {
        public int x;
        public int y;

        public POINT(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public bool Equals(POINT rhs)
        {
            return (rhs.X == this.x) && (rhs.Y == this.y);
        }
    }
}
