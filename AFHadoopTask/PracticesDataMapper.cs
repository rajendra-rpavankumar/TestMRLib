﻿using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFTask.Mapper
{

    public class PracticesDataMapper : MapperBase
    {

        public override void Map(string inputLine, MapperContext context)
        {
           

                context.EmitKeyValue("LONDON", "LONDON");
            
        }
    }
}
