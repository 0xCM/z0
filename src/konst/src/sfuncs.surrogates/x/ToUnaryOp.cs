//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using S = Surrogates;

    partial class SFXTend
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static S.UnaryOp<T> ToUnaryOp<T>(this S.Func<T,T> src)
            => S.unary(src.Subject.ToUnaryOp(), src.Id);
    }
}