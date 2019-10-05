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
        public static long vdot(Vec256<int> lhs, Vec256<int> rhs)
        {
            var product = vmul(lhs,rhs);
            var sum = vadd(lo(product),hi(product));
            var span = sum.ToSpan128();
            return span[0] + span[1];            
        }

        [MethodImpl(Inline)]
        public static ulong vdot(Vec256<uint> lhs, Vec256<uint> rhs)
        {
            var product = vmul(lhs,rhs);
            var sum = vadd(lo(product),hi(product));
            var span = sum.ToSpan128();
            return span[0] + span[1];            
        }

    }

}