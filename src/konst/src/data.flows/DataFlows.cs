//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.DataFlows, true)]
    public readonly struct DataFlows
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static string format<T>(DataFlow<T> flow)
            => text.format("{0} -> {1}", flow.Source, flow.Target);

        [MethodImpl(Inline)]
        public static LinkType<T> type<T>(DataFlow<T> flow)
            => Links.type<T>();

        [MethodImpl(Inline)]
        public static string format<S,T>(DataFlow<S,T> flow)
            => text.format("{0} -> {1}", flow.Source, flow.Target);

        [MethodImpl(Inline)]
        public static LinkType<S,T> type<S,T>(DataFlow<S,T> flow)
            => Links.type(flow.Source, flow.Target);
    }
}