using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01443564Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        [HttpGet]
        [Route("api/J3/Distance/{line1}/{line2}/{line3}/{line4}")]
        public string Distance(int line1,int line2,int line3,int line4)
        {
            int startDistance = 0;
            List<int> AllDistance = new List<int> { startDistance,line1, line2, line3, line4 };
            string output = "";
            int sum = 0;
            for( var i=0; i<AllDistance.Count; i++)
            {
                sum += AllDistance[i];
                output = output+ (sum + ", since the distance from city 1 to city " + (i +1) + " is " + sum +". ");
            } return output;
        }
    }
}
