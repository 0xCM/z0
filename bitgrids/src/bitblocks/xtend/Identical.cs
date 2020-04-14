//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static bit Identical<T>(this Block128<T> xb, Block128<T> yb)        
            where T : unmanaged        
                => xb.Data.Identical(yb.Data);

        [MethodImpl(Inline)]
        public static bit Identical<T>(this Block256<T> xb, Block256<T> yb)        
            where T : unmanaged        
                => xb.Data.Identical(yb.Data);
    }
}