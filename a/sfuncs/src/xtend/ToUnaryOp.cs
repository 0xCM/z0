//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    
    using static Seed;
    using S = Surrogates;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static S.UnaryOp<T> ToUnaryOp<T>(this S.Func<T,T> src)
            => S.unary(src.Subject.ToUnaryOp(), src.Id);
    }
}