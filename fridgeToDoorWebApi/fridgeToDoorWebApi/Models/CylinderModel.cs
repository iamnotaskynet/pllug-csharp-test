using System;
using fridgeToDoorWebApi.Models.Abstract;
namespace fridgeToDoorWebApi.Models
{
	public class CylinderModel : ShapeModel
    {
		private double _radius;
		private double _height;
        private double _diameter;

        public double Radius => _radius;
		public double Height => _height;
        public double Diameter => _diameter;

		public CylinderModel()
        {
            _radius = 0D;
			_height = 0D;
            _diameter = 0D;
        }

		public CylinderModel(double radius, double height)
        {
            _radius = radius;
			_height = height;
            _diameter = radius * 2D;
        }

        public override string ToString()
        {
            //throw new NotImplementedException();
            return $"Cylinder: ";
        }
    }
}
