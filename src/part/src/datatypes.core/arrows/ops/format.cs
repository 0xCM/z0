//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Arrows
    {
        [Op, Closures(Closure)]
        public static string format(ArrowType t)
            => render<string>().Format(t.Source.Name, t.Target.Name);

        [Op, Closures(Closure)]
        public static string format<T>(ArrowType<T> src)
            => render<string>().Format(src.Source.Name, src.Target.Name);

        public static string format<S,T>(ArrowType<S,T> src)
            => render<string>().Format(src.Source.Name, src.Target.Name);

        /// <summary>
        /// Renders a graph using basic graphviz format
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="label">An optional label for the graph</param>
        /// <typeparam name="V">The verex index type</typeparam>
        public static string format<V>(Graph<V> src, string label = null)
            where V : unmanaged
        {
            var count = src.EdgeCount;
            var buffer = text.buffer();
            buffer.AppendLine("digraph " +(label ?? "g") + "   {");
            for(var i=0; i< count; i++)
            {
                ref readonly var edge = ref src.Edge(i);
                buffer.AppendLine($"    {edge.Source} -> {edge.Target}");
            }
            buffer.AppendLine("}");
            return buffer.ToString();
        }

        public static RenderPattern<S,T> render<S,T>() => "{0} -> {1}";

        public static RenderPattern<T,T> render<T>() => render<T,T>();
    }
}