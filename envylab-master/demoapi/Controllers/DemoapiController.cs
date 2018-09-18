using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demoapi.Models;

namespace demoapi.Controllers
{
    [Route("api/[controller]")]
    public class DemoapiController : Controller
    {
        // GET api/values/5
        [HttpGet("{total}")]
        public ActionResult<string> Get(int total)
        {
            var engine = new Engine();
            var result = engine.Calculate(total);
            return result;
        }

    }

    public class Engine
    {
        public string Calculate(int totalnumber)
        {
            bool isLarger = false;
            int lastInit = 1;
            string LargerResult = "";

            do
            {
                StringBuilder sb = new StringBuilder();
                int target = 0;
                int running = lastInit;

                for (int i = lastInit; i < totalnumber; i++)
                {
                    target += running;
                    sb.Append(" " + running);
                    running++;

                    if (target >= totalnumber) break;
                }

                if (target == totalnumber)
                {
                    LargerResult = sb.ToString();
                }
                else if (lastInit == totalnumber)
                {
                    isLarger = true;
                }
                lastInit++;

            } while (lastInit <= totalnumber);

                        
            return LargerResult = !string.IsNullOrEmpty(LargerResult) ? LargerResult.ToString().Trim() : "This number no consecutive number";
        }

    }










}
