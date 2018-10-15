using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fridgeToDoorWebApi.Models;
using fridgeToDoorWebApi.Controllers.Static; //DoubleValueVerifier IsDoubleArrayValid

namespace fridgeToDoorWebApi.Controllers
{   
	[Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CubeToSquareController : ControllerBase
    {

        // GET api/cubetosquare/something
        [HttpGet]
		public string Get(double widthD, 
		                  double heightD, 
		                  double widthF, 
		                  double heightF,
		                  double lengthF )
        {   
			string result = $"calculating {widthD} {heightD} {widthF} {heightF} {lengthF}";

			if( DoubleValueVerifier.IsDoubleArrayValid(
				new double[] { widthD, heightD, widthF, heightF, lengthF }) )
			{
				result =
					CalculatorMain.CubeToSquare(new SquareModel(widthD, heightD),
												new CubeModel(widthF, heightF, lengthF))
					?
					"true" : "false";
			}
			else
			{
				result += "\nSome bad value(s)!";
			}

			return result;
        }

    }
}
