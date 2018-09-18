// A Hello World! program in C#.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace api
{
    public class Engine
    {
        public List<int> Calculate(int totalnumber)
        {
            bool isLarger = false;
            int lastInit = 1;
            // string LargerResult = "";
            var LargerResult = new List<int>();

            do
            {
                // StringBuilder sb = new StringBuilder();
                var sb = new List<int>();
                int target = 0;
                int running = lastInit;

                for (int i = lastInit; i < totalnumber; i++)
                {
                    target += running;
                    // sb.Append(" " + running);
                    sb.Add(running);
                    running++;

                    if (target >= totalnumber) break;
                }

                if (target == totalnumber)
                {
                    // LargerResult = sb.ToString();
                    LargerResult = sb.ToList();
                }
                else if (lastInit == totalnumber)
                {
                    isLarger = true;
                }
                lastInit++;

            } while (lastInit <= totalnumber);

            return LargerResult;
            // return LargerResult = !string.IsNullOrEmpty(LargerResult) ? LargerResult.ToString().Trim() : "This number no consecutive number";
        }

    }
}