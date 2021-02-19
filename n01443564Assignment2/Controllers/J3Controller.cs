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
        ///This question is from https://cemc.math.uwaterloo.ca/contests/computing/2018/stage%201/juniorEF.pdf.
        ///Note: I was unable to make starting city(i variable) to remain unchanged in the loop in the
        ///"for statement" for this question.
        ///Create a method that can calculate the total distance for traveling from a starting city to other 4 cities by
        ///entering four positive integers that represent distances between those cities.  
        /// <summary>
        /// The method will take in four positive integers that represent continuous distances between consecutive 
        /// pairs of cities and return sentences describing the distance between the starting city to other cities.
        /// </summary>
        /// <param name="line1">the distance between starting city to city 2</param>
        /// <param name="line2">the distance between city 2 to city 3</param>
        /// <param name="line3">the distance between city 3 to city 4</param>
        /// <param name="line4">the distance between city 4 to city 5</param>
        /// <returns>sentences that describe the distance between the starting city to other cities </returns>
        /// <example>
        /// Get api/J3/Distance/3/10/12/5 ->
        /// 0, since the distance from city 1 to city 1 is 0;
        /// 3, since the distance from city 1 to city 2 is 3;
        /// 13, since the distance from city 1 to city 3 is 13;
        /// 25, since the distance from city 1 to city 4 is 25;
        /// 30, since the distance from city 1 to city 5 is 30;
        /// </example>
        [HttpGet]
        [Route("api/J3/Distance/{line1}/{line2}/{line3}/{line4}")]
        public string Distance(int line1,int line2,int line3,int line4)
        {
            int startDistance = 0;
            int sum = 0;
            string output = "";
            string DistanceMessage = ", since the distance from city 1 to city ";

            List<int> AllDistance = new List<int>(){ startDistance, line1, line2, line3, line4 };
            
            if (line1<0 || line2<0 || line3<0 || line4 < 0)
            {
                return output;
            }

            for ( var i=0; i<AllDistance.Count; i++)
            {
                int otherCity = i + 1;
                sum += AllDistance[i];
                output = output+ sum + DistanceMessage + otherCity + " is " + sum +". ";
            } return output;
        }
    }
}
