using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fridgeToDoorWebApi.Models;
using fridgeToDoorWebApi.Controllers.Static;

namespace fridgeToDoorWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
	public class CylinderToSquareController : ControllerBase
    {

        // GET api/cylindertosquare/something
        [HttpGet]
        public string Get(double widthD,
                          double heightD,
                          double radiusF, 
		                  double heightF)
        {
			string result = $"calculate me {widthD} {heightD} {radiusF} {heightF}";


            if (DoubleValueVerifier.IsDoubleArrayValid(
				new double[] { widthD, heightD, radiusF, heightF }))
            {
                result =
                    CalculatorMain.CylinderToSquare(new SquareModel(widthD, heightD),
					                            new CylinderModel(radiusF, heightF))
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
