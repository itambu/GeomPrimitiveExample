using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace GenericGraph
{
    public class Edge< Vertex> 
    {
        public Vertex? V { get; init; }
        public Vertex? U { get; init; }

        //public StaticInfo? StaticPart { get; init; }
        //public DynamicInfo? DynamicPart { get; set; }
    }
}