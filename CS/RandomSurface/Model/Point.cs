#region #Model
namespace Bar3DChart {
   public class Point {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public Point(double x, double y, double z) {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
#endregion #Model