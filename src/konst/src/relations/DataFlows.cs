//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.DataFlows, true)]
    public readonly struct DataFlows
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Creates a <see cref='DataFlow{S,T}'/> from a specified source to a specified target;
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static DataFlow<S,T> flow<S,T>(in S src, in T dst)
            => new DataFlow<S,T>(src,dst);

        public static string identifier<S,T>(DataFlow<S,T> flow)
            => Relations.RenderLink<S,T>().Format(flow.Source, flow.Target);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string identifier<T>(DataFlow<T> flow)
            => Relations.RenderLink<T>().Format(flow.Source, flow.Target);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(DataFlow<T> flow)
            => Relations.RenderLink<T>().Format(flow.Source, flow.Target);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LinkType type<T>(DataFlow<T> flow)
            => Links.type<T>();

        [MethodImpl(Inline)]
        public static string format<S,T>(DataFlow<S,T> flow)
            => Relations.RenderLink<S,T>().Format(flow.Source, flow.Target);
    }
}