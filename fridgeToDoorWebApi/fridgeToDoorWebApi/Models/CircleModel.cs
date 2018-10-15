using System;
using fridgeToDoorWebApi.Models.Abstract;

namespace fridgeToDoorWebApi.Models
{
	public class CircleModel : ShapeModel
    {
		private double _radius;
		private double _diameter;

		public double Radius => _radius;
		public double Diameter => _diameter;

        public CircleModel()
        {
			_radius = 0D;
			_diameter = 0D;
        }

		public CircleModel(double radius)
		{
			_radius = radius;
			_diameter = radius * 2D;
		}

		public override string ToString()
        {
            //throw new NotImplementedException();
			return $"Circle: diameter: {_diameter}";
        }
    }
}
