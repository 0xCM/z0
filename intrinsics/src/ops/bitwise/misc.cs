//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;
 
    using static zfunc;
    
    partial class dinx
    {                
        /// <summary>
        /// unsigned __int64 _pdep_u64 (unsigned __int64 a, unsigned __int64 mask) PDEP r64a, r64b, reg/m64
        /// Deposits contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        internal static ulong scatter(ulong src, ulong mask)        
            => X64.ParallelBitDeposit(src,mask);
    }
}