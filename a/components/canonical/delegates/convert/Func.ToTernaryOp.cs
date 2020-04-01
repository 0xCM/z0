//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static TernaryOp<T> ToTernaryOp<T>(this System.Func<T,T,T,T> f)
            => new TernaryOp<T>(f);
    }
}