//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static System.Func<T,T,T,T> ToFunc<T>(this Z0.TernaryOp<T> f)
            => Delegates.func(f);
    }
}