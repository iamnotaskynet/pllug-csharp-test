using System;
using fridgeToDoorWebApi.Models.Abstract;

namespace fridgeToDoorWebApi.Models
{
	public class CubeModel : ShapeModel
	{
		private double _width;
		private double _height;
		private double _length;
		//for comparing with circle
		private double _diagonal;

		public double Width => _width;
		public double Height => _height;
		public double Length => _length;
		//for comparing with circle
		public double Diagonal => _diagonal;


		public double[] SortedArr() 
		{
			double[] result = {_width, _height, _length};
			Array.Sort(result);
			return result;
	    }

        public CubeModel()
        {
			_width = 0D;
            _height = 0D;
			_length = 0D;
			_diagonal = 0D;
        }

		public CubeModel(double width, double height, double length)
        {
			_width = width;
			_height = height;
			_length = length;
			//calculating some side hypotenuse
			//double hypotenuse = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            //calculating diagonal with the same formula
			//double diagonal = Math.Sqrt(Math.Pow(hypotenuse, 2) + Math.Pow(length, 2));
			_diagonal = Math.Sqrt(width + height + length);
        }

		public override string ToString()
        {
            //throw new NotImplementedException();
			return $"Cube: diagonal: {_diagonal}";
        }
    }
}
