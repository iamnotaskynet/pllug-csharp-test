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
	public class BallToSquareController : ControllerBase
    {

		// GET api/balltosquare/something
        [HttpGet]
        public string Get(double widthD,
                          double heightD,
                          double radiusF)
        {
            string result = $"calculate me {widthD} {heightD} {radiusF}";

			if (DoubleValueVerifier.IsDoubleArrayValid(
                new double[] { widthD, heightD, radiusF }))
            {
                result =
                    CalculatorMain.BallToSquare(new SquareModel(widthD, heightD),
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
