//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core    
    {
        [MethodImpl(Inline)]
        public static Lazy<T> defer<T>(Func<T> factory) 
            => new Lazy<T>(factory);
    }
}