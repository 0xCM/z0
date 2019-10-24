//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class PrimalSquare
    {
        [MethodImpl(Inline)]
        public static T and<T>(T A, T B,  T C)
            where T : unmanaged, IBitSquare<T>
        {
            // A.Load(out Vector256<ushort> a);
            // B.Load(out Vector256<ushort> b);
            // dinx.vand(a,b).StoreTo(ref C[0]);
            return C;
        }
        
    }
}