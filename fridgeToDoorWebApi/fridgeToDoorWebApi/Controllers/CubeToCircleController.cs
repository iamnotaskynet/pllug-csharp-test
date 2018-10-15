using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fridgeToDoorWebApi.Controllers.Static; //DoubleValueVerifier IsDoubleArrayValid
using fridgeToDoorWebApi.Models;
using fridgeToDoorWebApi.Models.Abstract;

namespace fridgeToDoorWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CubeToCircleController : ControllerBase
    {

        // GET api/cubetocircle/something
        [HttpGet]
        public string Get(double radiusD,
                          double widthF,
                          double heightF,
                          double lengthF)
        {
            string result = $"calculate me {radiusD} {widthF} {heightF} {lengthF}";

			if (DoubleValueVerifier.IsDoubleArrayValid(
                new double[] { radiusD, widthF, heightF, lengthF }))
			{

				CircleModel door = new CircleModel(radiusD);
				CubeModel fridge = new CubeModel(widthF, heightF, lengthF);

				result =
						CalculatorMain.CubeToCircle( door, fridge )
                        ?
					    $"true, door: {door.ToString()}; fridge: {fridge.ToString()}" 
                        : 
					    $"false, door: {door.ToString()};fridge: {fridge.ToString()}" ;
			}
			else
            {
				result += "; Some bad value(s)!";
            }

            return result;
        }

    }
}
