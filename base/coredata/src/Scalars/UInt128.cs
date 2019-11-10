//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;

    public struct UInt128
    {
        public ulong lo;

        public ulong hi;

        /// <summary>
        /// The 128-bit zero value
        /// </summary>
        public static readonly UInt128 Zero = new UInt128(0,0);

        /// <summary>
        /// The 128-bit one value
        /// </summary>
        public static readonly UInt128 One = new UInt128(1,0);

        /// <summary>
        /// The minimum value the type can represent
        /// </summary>
        public static readonly UInt128 MinVal = Zero;

        /// <summary>
        /// The maximum value the type can represent
        /// </summary>
        public static readonly UInt128 MaxVal = new UInt128(ulong.MaxValue, ulong.MinValue);

        /// <summary>
        /// Creates a new 128-bit integer with specifed lo/hi part values
        /// </summary>
        /// <param name="lo">The lo 64 bits</param>
        /// <param name="hi">The hi 64 bits</param>
        [MethodImpl(Inline)]
        public static UInt128 From(ulong lo, ulong hi)
            => new UInt128(lo,hi);
        
        [MethodImpl(Inline)]
        public static implicit operator Vector128<ulong>(in UInt128 src)
            => Vector128.Create(src.lo, src.hi);

        [MethodImpl(Inline)]
        public static implicit operator Vec128<ulong>(in UInt128 src)
            => Vector128.Create(src.lo, src.hi);

        [MethodImpl(Inline)]
        public static implicit operator UInt128(in Vector128<ulong> src)
            => Unsafe.As<Vector128<ulong>,UInt128>(ref Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        public static implicit operator UInt128(in Vec128<ulong> src)
            => Unsafe.As<Vec128<ulong>, UInt128>(ref Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        public static explicit operator ulong(in UInt128 src)
            => src.lo;

        [MethodImpl(Inline)]
        public static UInt128 operator &(UInt128 a, UInt128 b)
            => and(a,b);

        [MethodImpl(Inline)]
        public static UInt128 operator |(UInt128 a, UInt128 b)
            => or(a,b);

        [MethodImpl(Inline)]
        public static UInt128 operator ^(UInt128 a, UInt128 b)
            => xor(a,b);

        [MethodImpl(Inline)]
        public static UInt128 operator ~(UInt128 src)
            => From(~ src.lo, ~ src.hi);

        [MethodImpl(Inline)]
        public static implicit operator UInt128(ulong src)
            => new UInt128(src, 0ul);


        [MethodImpl(Inline)]
        public static UInt128 operator ++(in UInt128 src)
        {
            src.Inc();
            return src;
        }

        [MethodImpl(Inline)]
        public static UInt128 operator --(in UInt128 src)
        {
            src.Dec();
            return src;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(UInt128 lhs, UInt128 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in UInt128 lhs, in UInt128 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public UInt128(ulong lo, ulong hi)
            : this()
        {
            this.lo = lo;
            this.hi = hi;                                        
        }

        /// <summary>
        /// Increments the value by one
        /// </summary>
        [MethodImpl(Inline)]
        public void Inc()   
        {
            if(lo != MaxVal)
                lo++;
            else
                hi++;
        }


        /// <summary>
        /// Decrements the value by one
        /// </summary>
        [MethodImpl(Inline)]
        public void Dec()   
        {
            if(hi != 0)
                hi--;
            else
                lo--;
        }


        [MethodImpl(Inline)]
        public bool Equals(UInt128 lhs)
            => lo == lhs.lo && hi == lhs.hi;

        public override bool Equals(object obj)
            => obj is UInt128 x && Equals(x);

        public override int GetHashCode()
            => HashCode.Combine(lo,hi);
        
        public override string ToString() 
        {
            var str = string.Empty;
            if(hi != 0)
                str = "0x" + hi.ToString("X") + " "; 
            str += ("0x" +  lo.ToString("X"));            
            return str;
        }
        
 
        [MethodImpl(Inline)]
        static UInt128 and(in UInt128 lhs, in UInt128 rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        static ref UInt128 and(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
        {
            dst = And(lhs, rhs);
            return ref dst;            
        }

        [MethodImpl(Inline)]
        static UInt128 or(in UInt128 lhs, in UInt128 rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        static ref UInt128 or(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
        {
            dst = Or(lhs, rhs);
            return ref dst;            
        }

        [MethodImpl(Inline)]
        static UInt128 xor(in UInt128 lhs, in UInt128 rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        static ref UInt128 xor(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
        {
            dst = Xor(lhs, rhs);
            return ref dst;            
        }

        /// <summary>
        /// __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8    
        /// Shifts the source value leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        static UInt128 bslli(UInt128 src, byte bytes)        
            => ShiftLeftLogical128BitLane(src, bytes);                            

    }    

}