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

    partial struct Flow
    {
        [MethodImpl(Inline)]
        public static WfType<S,T> type<S,T>(S s = default, T t = default)
            => new WfType<S,T>(typeof(S),typeof(T));

        [MethodImpl(Inline), Op]
        public static WfType type(Type src, Type dst)
            => new WfType(src,dst);
    }
}