//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static math;

    public static class RngSuites
    {
        /// <summary>
        /// Samples one point from each generator
        /// </summary>
        /// <param name="sources">A set of random point sources</param>
        public static Span<T> Next<T>(this Span<IBoundPointSource<T>> generators)
            where T : unmanaged
        {
            Span<T> dst = new T[generators.Length];
            for(var i=0; i<generators.Length; i++)
                dst[i] = generators[i].Next();
            return dst;
        }

        /// <summary>
        /// Samples one point from each generator
        /// </summary>
        /// <param name="sources">A set of random point sources</param>
        public static Span<T> Next<T>(this Span<INavigableSource<T>> generators)
            where T : unmanaged
        {
            Span<T> dst = new T[generators.Length];
            for(var i=0; i<generators.Length; i++)
                dst[i] = generators[i].Next();
            return dst;
        }

        /// <summary>
        /// Samples one point from each generator
        /// </summary>
        /// <param name="sources">A set of random point sources</param>
        public static T[] Next<T>(this IBoundPointSource<T>[] sources)
            where T : unmanaged
        {
            var dst = new T[sources.Length];
            for(var i=0; i<sources.Length; i++)
                dst[i] = sources[i].Next();
            return dst;
        }

        /// <summary>
        /// Samples one point from each generator
        /// </summary>
        /// <param name="sources">A set of random point sources</param>
        public static T[] Next<T>(this INavigableSource<T>[] sources)
            where T : unmanaged
        {
            var dst = new T[sources.Length];
            for(var i=0; i<sources.Length; i++)
                dst[i] = sources[i].Next();
            return dst;
        }

    }

}