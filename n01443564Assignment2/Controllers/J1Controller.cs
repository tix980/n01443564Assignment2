using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01443564Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        ///This question is from https://cemc.math.uwaterloo.ca/contests/computing/2006/stage1/juniorEn.pdf.
        ///objective: Create a method that would calculate the total calories of the meal by 
        ///entering four integers representing different index choices of the meal on the menu.
        /// <summary>
        /// This method will take in four integer input values(index burger choice, drink choice,
        /// side choice, and dessert choice) and output the total calories of the meal.
        /// </summary>
        /// <param name="burger">an integer that represents index burger choice</param>
        /// <param name="drink">an integer that represents index drink choice</param>
        /// <param name="side">an integer that represents index side choice</param>
        /// <param name="dessert">an integer that represents index dessert choice</param>
        /// <returns>total calories of the meal</returns>
        /// <example>
        /// GET: api/J1/Menu/4/4/4/4 ->
        /// Your total calorie count is 0
        /// </example>
        /// <example>
        /// GET: api/J1/Menu/1/2/3/4 ->
        /// Your total calorie count is 691
        /// </example>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int burgerCal = 0;
            int drinkCal = 0;
            int sideCal = 0;
            int dessertCal = 0;

            if (burger == 1)
            {
                burgerCal += 461;
            }
            else if (burger == 2)
            {
                burgerCal += 431;
            }
            else if (burger == 3)
            {
                burgerCal += 420;
            }
            else
            {
                burgerCal += 0;
            }

            if (drink == 1)
            {
                drinkCal += 130;
            }
            else if (drink == 2)
            {
                drinkCal += 160;
            }
            else if (drink == 3)
            {
                drinkCal += 118;
            }
            else
            {
                drinkCal += 0;
            }


            if (side == 1)
            {
                sideCal += 100;
            }
            else if (side == 2)
            {
                sideCal += 57;
            }
            else if (side == 3)
            {
                sideCal += 70;
            }
            else
            {
                sideCal += 0;
            }


            if (dessert == 1)
            {
                dessertCal += 167;
            }
            else if (dessert == 2)
            {
                dessertCal += 266;
            }
            else if (dessert == 3)
            {
                dessertCal += 75;
            }
            else
            {
                dessertCal += 0;
            }

            int calorie = burgerCal + drinkCal + sideCal + dessertCal;
            return "Your total calorie count is " + calorie;

        }

    }
}