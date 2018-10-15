using System;

using fridgeToDoorWebApi.Models;

namespace fridgeToDoorWebApi.Controllers.Static
{
    public static class CalculatorMain
    {
		public static bool CubeToSquare(SquareModel door, CubeModel fridge)
		{
			bool result = false;

			double[] sortedDoor = door.SortedArr();
			double[] sortedFridge = fridge.SortedArr();

			if( sortedDoor[0] > sortedFridge [0] && sortedDoor[1] > sortedFridge[1])
			{
				result = true;
			}

			return result;
		}

		public static bool CubeToCircle(CircleModel door, CubeModel fridge)
		{
			bool result = false;

			if( fridge.Diagonal < door.Diameter)
			{
				result = true;
			}

			return result;
		}

		public static bool BallToSquare(SquareModel door, BallModel fridge)
		{
			bool result = false;

			if( fridge.Diameter < door.Height && fridge.Diameter < door.Width)
			{
				result = true;
			}

			return result;
		}

		public static bool BallToCircle(CircleModel door, BallModel fridge)
        {
            bool result = false;

			if (fridge.Diameter < door.Diameter )
            {
                result = true;
            }

            return result;
        }

		public static bool CylinderToSquare(SquareModel door, CylinderModel fridge)
		{
			bool result = false;

			if(fridge.Diameter < door.Width && fridge.Diameter < door.Height)
			{
				result = true;
			}
			else if (fridge.Diameter < door.Width && fridge.Height < door.Height)
			{
				result = true;
			}
			else if (fridge.Diameter < door.Height && fridge.Height < door.Width)
			{
				result = true;
			}

			return result;
		}

		public static bool CylinderToCircle(CircleModel door, CylinderModel fridge)
		{
			bool result = false;

			if(fridge.Diameter < door.Diameter)
			{
				result = true;
			}

			return result;
		}
    }
}
