using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01443564Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// This question is from https://cemc.math.uwaterloo.ca/contests/computing/2012/stage1/juniorEn.pdf.
        ///objective: Create a method that determine if the fish-finder finds a fish by 
        ///entering four four consecutive depth readings. 
        /// <summary>
        /// This method will take in four interger input values of consecutive depth readings
        /// and output the result of fish-finder by returning a sentence.
        /// </summary>
        /// <param name="reading1">the interger value of first depth reading</param>
        /// <param name="reading2">the interger value of second depth reading</param>
        /// <param name="reading3">the interger value of third depth reading</param>
        /// <param name="reading4">the interger value of fourth depth reading</param>
        /// <returns>one of the four possibilities of fish-finder's results.(Fish Rising,
        /// Fish Diving,Fish At Constant Depth,No Fish)
        /// </returns>
        /// <example>
        /// Get: api/J2/FishFinder/1/10/12/13 ->
        /// "Fish Rising"
        /// </example>
        /// Get: api/J2/FishFinder/9/6/5/2 ->
        /// "Fish Diving"
        /// </example>
        /// Get: api/J2/FishFinder/5/5/5/5->
        /// "Fish At Constant Depth"
        /// </example>
        /// Get: api/J2/FishFinder/30/10/20/20 ->
        /// "No Fish"
        /// </example>
        
        [Route("api/J2/FishFinder/{reading1}/{reading2}/{reading3}/{reading4}")]
        [HttpGet]

        public string FishFinder(int reading1, int reading2, int reading3, int reading4)
        {
            int r1 =reading1;
            int r2 = reading2;
            int r3 = reading3;
            int r4 = reading4;

            if (r1 < r2 && r2 < r3 && r3 < r4)
            {
                return "Fish Rising";
            }
            else if (r1 > r2 && r2 > r3 && r3 > r4)
            {
                return "Fish Diving";
            }
            else if (r1 == r2 && r2 == r3 && r3 == r4)
            {
                return "Fish At Constant Depth";
            }
            else
            {
                return "No Fish";
            }
        }
    }
}
