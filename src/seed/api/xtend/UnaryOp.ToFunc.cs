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
        public static System.Func<T,T> ToFunc<T>(this Z0.UnaryOp<T> f)
            => new System.Func<T,T>(f);
    }
}