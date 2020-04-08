//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;    
    
    using static Seed;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static T FirstCell<T>(this Vector128<T> src)
            where T : unmanaged 
                => src.Cell(0);
        
        [MethodImpl(Inline)]
        public static T FirstCell<T>(this Vector256<T> src)
            where T : unmanaged 
                => src.Cell(0);
    }
}