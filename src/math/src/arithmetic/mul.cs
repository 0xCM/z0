//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;

    using static Konst;        
    using static z;

    partial class math
    {
        [MethodImpl(Inline), Mul]
        public static sbyte mul(sbyte a, sbyte rhs)
            => (sbyte)(a * rhs);

        [MethodImpl(Inline), Mul]
        public static byte mul(byte a, byte b)
            => (byte)(a * b);

        [MethodImpl(Inline), Mul]
        public static short mul(short a, short b)
            => (short)(a * b);

        [MethodImpl(Inline), Mul]
        public static ushort mul(ushort a, ushort b)
            => (ushort)(a * b);

        [MethodImpl(Inline), Mul]
        public static int mul(int a, int b)
            => a * b;

        [MethodImpl(Inline), Mul]
        public static uint mul(uint a, uint b)
            => a * b;

        [MethodImpl(Inline), Mul]
        public static long mul(long a, long b)
            => a * b;

        [MethodImpl(Inline), Mul]
        public static ulong mul(ulong a, ulong b)
            => a * b;


        [MethodImpl(Inline), Op]
        public static unsafe void mul(uint x, uint y, out uint lo, out uint hi)
        {
           lo = 0u;
           hi = MultiplyNoFlags(x,y, gptr(lo));
        }

        [MethodImpl(Inline), Op]
        public static unsafe void mul(ulong x, ulong y, out ulong lo, out ulong hi)
        {
           lo = 0ul;
           hi = Bmi2.X64.MultiplyNoFlags(x,y, z.gptr(lo));
        }

        [MethodImpl(Inline), Op]
        public static ref Pair<uint> mul(uint x, uint y, out Pair<uint> dst)                 
        {
            mul(x,y, out dst.Left, out dst.Right);
            return ref dst;
        }
            
        [MethodImpl(Inline), Op]
        public static unsafe ref Pair<uint> mul(in ConstPair<uint> src, ref Pair<uint> dst)                 
        {
            dst.Right = MultiplyNoFlags(src.Left, src.Right, gptr(dst.Left));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static unsafe ref Pair<ulong> mul(in ConstPair<ulong> src, ref Pair<ulong> dst)  
        {               
            dst.Right = Bmi2.X64.MultiplyNoFlags(src.Left, src.Right, z.gptr(dst.Left));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref Pair<ulong> mul(ulong x, ulong y, out Pair<ulong> dst)                 
        {
            math.mul(x,y, out dst.Left, out dst.Right);
            return ref dst;
        }
    }
}