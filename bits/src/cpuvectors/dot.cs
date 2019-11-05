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
 
    partial class Bits
    {    
        
        // [MethodImpl(Inline)]
        // public static bit dot(Vector128<ulong> x, Vector128<ulong> y)
        //     => odd(dinx.vextract(AvxPops.avxpop(dinx.vand(x,y)), 0));

        // [MethodImpl(Inline)]
        // public static bit dot(Vector256<ulong> x, Vector256<ulong> y)
        // {            
        //     var z = AvxPops.avxpop(dinx.vand(x,y));
        //     var z0 = dinx.vextract(dinx.vlo(z),0);
        //     var z1 = dinx.vextract(dinx.vhi(z),0);
        //     return odd(z0 + z1);
        // }                
    }

}