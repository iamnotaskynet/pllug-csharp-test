using System;
namespace fridgeToDoorWebApi.Controllers.Static
{
	public static class DoubleValueVerifier
    {   
		private const double _MINIMUM = 1D;
		private const double _MAXIMUM = 140000D;

        
		public static bool IsDoubleValueValid(double value){
			return value >= _MINIMUM && value < _MAXIMUM;
		}
        
		public static bool IsDoubleArrayValid(double[] arr)
		{
			bool result = true;

			foreach(double value in arr)
			{
				if(!IsDoubleValueValid(value))
				{
					result = false;
				}
			}

			return result;
        }

    }
}
