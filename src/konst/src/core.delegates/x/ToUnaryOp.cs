//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class DXTend
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static UnaryOp<T> ToUnaryOp<T>(this System.Func<T,T> f)
            => Delegates.@operator(f);
    }
}