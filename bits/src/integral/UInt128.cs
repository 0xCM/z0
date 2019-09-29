//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;

    partial class Bits
    {
        [MethodImpl(Inline)]
        public static UInt128 and(in UInt128 lhs, in UInt128 rhs)
            => And(lhs.ToVector128(), rhs.ToVector128()).ToUInt128();

        [MethodImpl(Inline)]
        public static ref UInt128 and(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
        {
            dst = And(lhs.ToVector128(), rhs.ToVector128()).ToUInt128();
            return ref dst;            
        }

        [MethodImpl(Inline)]
        public static UInt128 or(in UInt128 lhs, in UInt128 rhs)
            => Or(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();

        [MethodImpl(Inline)]
        public static ref UInt128 or(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
        {
            dst = Or(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();
            return ref dst;            
        }

        [MethodImpl(Inline)]
        public static UInt128 xor(in UInt128 lhs, in UInt128 rhs)
            => Xor(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();

        [MethodImpl(Inline)]
        public static ref UInt128 xor(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
        {
            dst = Xor(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();
            return ref dst;            
        }

        /// <summary>
        /// __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8    
        /// Shifts the source value leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static UInt128 bslli(UInt128 src, byte bytes)        
            => ShiftLeftLogical128BitLane(src, bytes).ToUInt128();                            

    }
}