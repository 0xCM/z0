//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct Flow
    {
        [MethodImpl(Inline)]
        public static WfType<S,T> type<S,T>(S s = default, T t = default)
            => new WfType<S,T>(typeof(S),typeof(T));

        [MethodImpl(Inline), Op]
        public static WfType type(Type src, Type dst)
            => new WfType(src,dst);

        [MethodImpl(Inline), Op]
        public static bool eq(WfType a, WfType b)
            => a.Source == b.Source && a.Target == b.Target;
    }
}