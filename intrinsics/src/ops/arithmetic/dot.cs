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
    using static System.Runtime.Intrinsics.X86.Sse41;    
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static zfunc;    

    partial class dinx
    {        
        [MethodImpl(Inline)]
        public static long vdot(Vector256<int> lhs, Vector256<int> rhs)
        {
            var product = vmul(lhs,rhs);
            var sum = vadd(vlo(product),vhi(product));
            var span = sum.ToBlockedSpan();
            return span[0] + span[1];            
        }

        [MethodImpl(Inline)]
        public static ulong vdot(Vector256<uint> lhs, Vector256<uint> rhs)
        {
            var product = vmul(lhs,rhs);
            var sum = vadd(vlo(product),vhi(product));
            var span = sum.ToBlockedSpan();
            return span[0] + span[1];            
        }
    }
}