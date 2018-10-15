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
	public class CylinderToCircleController : ControllerBase
    {

        // GET api/cylindertocircle/something
        [HttpGet]
        public string Get(double radiusD,
                          double radiusF,
		                  double heightF)
        {
			string result = $"calculate me {radiusD} {radiusF} {heightF}";


            if (DoubleValueVerifier.IsDoubleArrayValid(
                new double[] { radiusD, radiusF, heightF }))
            {
                result =
					CalculatorMain.CylinderToCircle(new CircleModel(radiusD),
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
