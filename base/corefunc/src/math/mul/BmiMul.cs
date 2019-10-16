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

    using static zfunc;
    using static As;

    public static unsafe class BmiMul
    {
        [MethodImpl(Inline)]
        public static ulong hi(ulong x, ulong y)
            => Bmi2.X64.MultiplyNoFlags(x,y);

        [MethodImpl(Inline)]
        public static ulong hi(uint x, uint y)
            => Bmi2.MultiplyNoFlags(x,y);

        [MethodImpl(Inline)]
        public static uint lo(uint x, uint y)
        {
            var lo = 0u;
            Bmi2.MultiplyNoFlags(x,y, refptr(ref lo));
            return lo;
        }

        [MethodImpl(Inline)]
        public static ulong lo(ulong x, ulong y)
        {
            var lo = 0ul;            
            Bmi2.X64.MultiplyNoFlags(x,y, &lo);
            return lo;
        }

        [MethodImpl(Inline)]
        public static void lo(uint x, uint y, ref uint lo)
            => Bmi2.MultiplyNoFlags(x,y, refptr(ref lo));

        [MethodImpl(Inline)]
        public static void lo(ulong x, ulong y, ref ulong lo)
            => Bmi2.X64.MultiplyNoFlags(x,y, refptr(ref lo));

        [MethodImpl(Inline)]
        public static void full(uint x, uint y, out uint lo, out uint hi)
        {
           lo = 0u;
           hi = Bmi2.MultiplyNoFlags(x,y, refptr(ref lo));
        }

        [MethodImpl(Inline)]
        public static void full(ulong x, ulong y, out ulong lo, out ulong hi)
        {
           lo = 0ul;
           hi = Bmi2.X64.MultiplyNoFlags(x,y, refptr(ref lo));
        }

    }


}