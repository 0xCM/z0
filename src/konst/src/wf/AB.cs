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

    [ApiHost]
    public readonly partial struct AB
    {
        [MethodImpl(Inline)]
        public static WfType<S,T> type<S,T>(S s = default, T t = default)
            => new WfType<S,T>(typeof(S),typeof(T));

        [MethodImpl(Inline), Op]
        public static WfType type(Type src, Type dst)
            => new WfType(src,dst);

        [MethodImpl(Inline), Op]
        public static string format(WfType t)
            => text.format("{0} -> {1}", t.Source.Name, t.Target.Name);

        [MethodImpl(Inline), Op]
        public static bool eq(WfType a, WfType b)
            => a.Source == b.Source && a.Target == b.Target;

        [MethodImpl(Inline), Op]
        public static ulong hash32(WfType src)
            => hash(src.Source) ^ hash(src.Target);

        [MethodImpl(Inline), Op]
        public static ulong hash64(WfType src)
            => (ulong)hash(src.Source) | ((ulong)hash(src.Target) << 32);
    }
}