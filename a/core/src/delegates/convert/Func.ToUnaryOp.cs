//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Components;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static UnaryOp<T> ToUnaryOp<T>(this System.Func<T,T> f)
            => new UnaryOp<T>(f);
    }
}