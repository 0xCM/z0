//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.Relations, true)]
    public readonly struct Relations
    {
        const NumericKind Closure = UnsignedInts;


        [MethodImpl(Inline)]
        public static string format<T>(Dependency<T> src)
            => RenderLink<T>().Format(src.Source, src.Target);

        [MethodImpl(Inline)]
        public static string format<S,T>(Dependency<S,T> src)
            => RenderLink<S,T>().Format(src.Source, src.Target);

        public static RenderPattern<S,T> RenderLink<S,T>() => "{0} -> {1}";

        public static RenderPattern<T,T> RenderLink<T>() => RenderLink<T,T>();
    }
}