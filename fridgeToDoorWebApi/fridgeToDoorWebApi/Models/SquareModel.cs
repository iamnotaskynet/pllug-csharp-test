using System;
using fridgeToDoorWebApi.Models.Abstract;

namespace fridgeToDoorWebApi.Models
{
	public class SquareModel : ShapeModel
	{
		private double _width;
		private double _height;

		public double Width => _width;
		public double Height => _height;

        public double[] SortedArr()
        {
            double[] result = { _width, _height };
            Array.Sort(result);
            return result;
        }

		public SquareModel()
        {
			_width = 0D;
			_height = 0D;
        }

		public SquareModel(double width, double height)
        {
            _width = width;
            _height = height;
        }

		public override string ToString()
		{
			//throw new NotImplementedException();
			return "Square";
		}
	}
}
