﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadFlo
{
    public sealed class Graph
    {
        public GraphId Id { get; private set; }
        public GraphName Name { get; private set; }

        public Graph()
        {
            Id = GraphId.Empty;
            Name = GraphName.Empty;
        }

        private readonly static Graph _empty = new Graph();
        public static Graph Empty { get { return _empty; } }

        public bool IsEmpty()
        {
            return this == Empty;
        }


        public Graph GetEmpty()
        {
            return Empty;
        }


        private Graph Clone()
        {
            var c = new Graph();
            c.Id = this.Id;
            c.Name = this.Name;
            return c;
        }

        public Graph WithName(GraphName value)
        {
            var c = this.Clone();
            c.Name = value;
            return c;
        }

        public Graph WithId(GraphId value)
        {
            var c = this.Clone();
            c.Id = value;
            return c;
        }

    }

/*            function Graph(name) {
      this.name = name != null ? name : '';
      this.properties = {};
      this.nodes = [];
      this.edges = [];
      this.initializers = [];
      this.exports = [];
      this.groups = [];
    }
        */
    
}
