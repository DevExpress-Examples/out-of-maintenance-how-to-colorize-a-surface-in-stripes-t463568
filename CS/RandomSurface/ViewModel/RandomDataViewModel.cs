#region #ViewModel
using System;
using System.Collections.ObjectModel;

namespace Bar3DChart {
    public class RandomDataViewModel {
        public ObservableCollection<Point> DataPoints { get; set; }
        public RandomDataViewModel() {
            int barsCount = 200;
            int maxValue = 200;
            this.DataPoints = DataGenerator.GenerateData(barsCount, maxValue);
        }
    }
    public static class DataGenerator {
        public static ObservableCollection<Point> GenerateData(int pointCount, int maxValue) {
            Random rand = new Random();
            ObservableCollection<Point> bars = new ObservableCollection<Point>();
            for (int i = 0; i < pointCount; i++) {
                Point bar;
                double x = rand.NextDouble() * maxValue * 2;
                double y = rand.NextDouble() * maxValue * 2;
                double z = rand.NextDouble() * maxValue;
                bar = new Point(x, y, z);
                bars.Add(bar);
            }
            return bars;
        }
    }
}
#endregion #ViewModel