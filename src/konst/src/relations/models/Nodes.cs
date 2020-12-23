//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Part;

    public class Nodes<V>
        where V : unmanaged
    {
        /// <summary>
        /// Correlates sources with their targets
        /// </summary>
        Dictionary<V,List<V>> SourceIndex;

        /// <summary>
        /// Correlates targets with their sources
        /// </summary>
        IDictionary<V,List<V>> TargetIndex;

        public static Nodes<V> Build(Node<V>[] vertices, Link<V>[] edges)
        {
            var index = new Nodes<V>();
            index.SourceIndex = new Dictionary<V, List<V>>();
            index.TargetIndex = new Dictionary<V, List<V>>();

            for(var i=0; i<edges.Length; i++)
            {
                var edge = edges[i];
                if(index.SourceIndex.TryGetValue(edge.Source, out List<V> targets))
                    targets.Add(edge.Target);
                else
                    index.SourceIndex[edge.Source] = list(edge.Target);

                if(index.TargetIndex.TryGetValue(edge.Target, out List<V> sources))
                    sources.Add(edge.Source);
                else
                    index.TargetIndex[edge.Target] = list(edge.Source);
            }
            return index;

        }

        [MethodImpl(Inline)]
        static List<V> list(V first)
        {
            var list = new List<V>();
            list.Add(first);
            return list;
        }

        /// <summary>
        /// Retrieves the indices of a targets' source vertices
        /// </summary>
        /// <param name="source">The source vertex</param>
        [MethodImpl(Inline)]
        public List<V> Sources(V target)
        {
            if(SourceIndex.TryGetValue(target, out List<V> sources))
                return sources;
            else
                return new List<V>();
        }

        /// <summary>
        /// Retrieves the indices of a sources' target vertices
        /// </summary>
        /// <param name="source">The source vertex</param>
        [MethodImpl(Inline)]
        public List<V> Targets(V source)
        {
            if(TargetIndex.TryGetValue(source, out List<V> targets))
                return targets;
            else
                return new List<V>();
        }
    }
}