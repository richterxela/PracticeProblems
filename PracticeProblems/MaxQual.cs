using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;
    using System.Text;
    using System;



    class Result
    {

        /*
         * Complete the 'findMaximumQuality' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY packets
         *  2. INTEGER channels
         */

        public static long findMaximumQuality(List<int> packets, int channels)
        {
            packets.Sort();



            return 
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int packetsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> packets = new List<int>();

            for (int i = 0; i < packetsCount; i++)
            {
                int packetsItem = Convert.ToInt32(Console.ReadLine().Trim());
                packets.Add(packetsItem);
            }

            int channels = Convert.ToInt32(Console.ReadLine().Trim());

            long result = Result.findMaximumQuality(packets, channels);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
