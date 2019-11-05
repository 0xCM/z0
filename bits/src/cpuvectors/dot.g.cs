//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
        
    using static As;
    using static zfunc;
 
    partial class gbits
    {    
        // [MethodImpl(Inline)]
        // public static bit dot<T>(Vector128<T> x, Vector128<T> y)
        //     where T : unmanaged
        //         => Bits.dot(x.AsUInt64(), y.AsUInt64());

        // [MethodImpl(Inline)]
        // public static bit dot<T>(Vector256<T> x, Vector256<T> y)
        //     where T : unmanaged
        //         => Bits.dot(x.AsUInt64(), y.AsUInt64());

    }

}
