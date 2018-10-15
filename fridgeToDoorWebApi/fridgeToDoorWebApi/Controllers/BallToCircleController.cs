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
	public class BallToCircleController : ControllerBase
    {

		// GET api/balltocircle/something
        [HttpGet]
        public string Get(double radiusD,
                          double radiusF)
        {
            string result = $"calculate me {radiusD} {radiusF}";

			if (DoubleValueVerifier.IsDoubleArrayValid(
                new double[] { radiusD, radiusF }))
            {
                result =
					CalculatorMain.BallToCircle(new CircleModel(radiusD),
                                                new BallModel(radiusF))
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
