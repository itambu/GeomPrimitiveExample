using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericGraph
{
    public class Graph<Vertex, Edge> where Edge : Edge<Vertex>
    {
        public ICollection<Vertex> Vertices { get; protected set; }
        public ICollection<Edge> Edges { get; protected set; }

        public Graph() : this(new List<Vertex>(), new List<Edge>()) { }
        public Graph(ICollection<Vertex> vertices, ICollection<Edge> edge) 
        {
            Vertices = vertices;
            Edges = edge;
        }

        public ICollection<ICollection<Vertex>> ConnectedComponent()
        {
            ICollection<ICollection<Vertex>> components = new List<ICollection<Vertex>>();

            throw new Exception();
        }

    }
}