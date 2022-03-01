using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01018195.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Check to see how many times we need to roll 2 dices to get a sum of 10
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int sum = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = n; j >= 1; j--)
                {
                    int k = i + j;
                    if (k == 10)
                    {
                        
                        sum ++;
                    }
                }
                
            }
            return "There are "+sum.ToString()+" total ways to get the sum 10";

        }
    }
}
