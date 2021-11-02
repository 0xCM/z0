//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Graphs;

    using static Root;
    using static core;

    public struct GraphSymbols
    {
        /// <summary>
        /// The symbol used to depict an edge between two nodes
        /// </summary>
        public text15 Connector;

        [MethodImpl(Inline)]
        public GraphSymbols(text15 connector)
        {
            Connector = connector;
        }

        public static GraphSymbols Default => new GraphSymbols(" -> ");
    }

    public class GraphTests : AppService<GraphTests>
    {
        public void Run()
        {
            var labels = Letters;
            var g = cycle(0u, (uint)labels.Length - 1).Seal();
            var dst = text.buffer();
            var symbols = GraphSymbols.Default;
            render(g, dst);
            Write(dst.Emit());
            render(g, symbols, labels, dst);
            Write(dst.Emit());
        }

        public static Digraph cycle(uint src, uint dst)
        {
            var g = graphs.digraph();
            for(var i=src; i<dst; i+=2)
                g.Connect(i, i+1);
            g.Connect(dst,src);
            return g;
        }

        public static Digraph cycle(uint period)
            => cycle(0u,period);

        public static void render(Digraph src, ITextBuffer dst)
        {
            var counter = 0u;
            var symbols = GraphSymbols.Default;
            var connector = symbols.Connector;
            dst.AppendLine("digraph G {");
            src.Walk(e => dst.AppendLineFormat("  \"{0}\"{1}\"{2}\"", e.Source.Key, connector, e.Target.Key));
            dst.AppendLine("}");
        }

        public static void render(Digraph src, GraphSymbols symbols, ReadOnlySpan<Label> labels, ITextBuffer dst)
        {
            var count = src.EdgeCount;
            var edges = src.Edges;
            dst.AppendLine("digraph G {");
            var connector = symbols.Connector.Format();
            for(var i=0u; i<count; i++)
            {
                ref readonly var edge = ref skip(edges,i);
                var v0 = edge.Source;
                var v1 = edge.Target;
                ref readonly var a0 = ref skip(labels, v0.Key);
                ref readonly var a1 = ref skip(labels, v1.Key);
                dst.AppendLineFormat("  {0}{1}{2}", a0, connector, a1);
            }
            dst.AppendLine("}");
        }

        static ReadOnlySpan<Label> Letters => new Label[]{"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
    }
}