using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFHadoopTask
{
    class Program
    {
        static void Main(string[] args)
        {
            HadoopJobConfiguration practice_jobConfig = new HadoopJobConfiguration()
            {
                InputPath = "Input/AFTask",
                OutputFolder = "Output/AFTaskPractices",
            };
        }
    }
}
