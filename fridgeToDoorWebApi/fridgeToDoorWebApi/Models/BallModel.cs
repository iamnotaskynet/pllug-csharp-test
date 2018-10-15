using System;
using fridgeToDoorWebApi.Models.Abstract;

namespace fridgeToDoorWebApi.Models
{
	public class BallModel : ShapeModel
    {
		private double _radius;
        private double _diameter;

        public double Radius => _radius;
        public double Diameter => _diameter;

		public BallModel()
        {
            _radius = 0D;
            _diameter = 0D;
        }

		public BallModel(double radius)
        {
            _radius = radius;
            _diameter = radius * 2D;
        }

        public override string ToString()
        {
            //throw new NotImplementedException();
            return $"Ball: diameter: {_diameter}";
        }
    }
}
