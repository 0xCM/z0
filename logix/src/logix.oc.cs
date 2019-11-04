//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;
    using static LogicOps;
    using static ScalarOps;
    using static CpuOps;
    using static BitMatrixOps;
    using static BitVectorOps;

    public static partial class logixoc
    {
        public static int work_ring_buffer()
        {
            var buffer = RingBuffer.alloc<byte>(64);
            buffer.Push(3);
            buffer.Push(4);
            var x = buffer.Pop();
            var y = buffer.Pop();
            return x + y;
        }



        public static ref BitStack push(bit src, ref BitStack dst)
        {
            dst.Push(src);
            return ref dst;
        }

        public static bit pop(ref BitStack src)
            => src.Pop();

        public static bit and_logic(bit a, bit b)
            => and(a,b);

        public static ulong and_scalar(ulong a, ulong b)
            => and(a,b);

        public static Vector128<ulong> and_v128(Vector128<ulong> a, Vector128<ulong> b)
            => and(a,b);

        public static Vector256<ulong> and_v256(Vector256<ulong> a, Vector256<ulong> b)
            => and(a,b);

        public static bit nor_logic(bit a, bit b)
            => nor(a,b);

        public static ulong nor_scalar(ulong a, ulong b)
            => nor(a,b);

        public static Vector128<ulong> nor_v128(Vector128<ulong> a, Vector128<ulong> b)
            => nor(a,b);

        public static Vector256<ulong> nor_v256(Vector256<ulong> a, Vector256<ulong> b)
            => nor(a,b);

        public static bit xnor_logic(bit a, bit b)
            => xnor(a,b);

        public static ulong xnor_scalar(ulong a, ulong b)
            => xnor(a,b);

        public static Vector128<ulong> xnor_v128(Vector128<ulong> a, Vector128<ulong> b)
            => xnor(a,b);

        public static Vector256<ulong> xnor_v256(Vector256<ulong> a, Vector256<ulong> b)
            => xnor(a,b);

        public static bit imply_logic(bit a, bit b)
            => imply(a,b);

        public static ulong imply_scalar(ulong a, ulong b)
            => imply(a,b);

        public static Vector128<ulong> imply_v128(Vector128<ulong> a, Vector128<ulong> b)
            => imply(a,b);

        public static Vector256<ulong> imply_v256(Vector256<ulong> a, Vector256<ulong> b)
            => imply(a,b);

        public static bit notimply_logic(bit a, bit b)
            => notimply(a,b);

        public static ulong notimply_scalar(ulong a, ulong b)
            => notimply(a,b);

        public static Vector128<ulong> notimply_v128(Vector128<ulong> a, Vector128<ulong> b)
            => notimply(a,b);

        public static Vector256<ulong> notimply_v256(Vector256<ulong> a, Vector256<ulong> b)
            => notimply(a,b);

        public static bit cimply_logic(bit a, bit b)
            => cimply(a,b);

        public static ulong cimply_scalar(ulong a, ulong b)
            => cimply(a,b);

        public static Vector128<ulong> cimply_v128(Vector128<ulong> a, Vector128<ulong> b)
            => cimply(a,b);

        public static Vector256<ulong> cimply_v256(Vector256<ulong> a, Vector256<ulong> b)
            => cimply(a,b);

        public static bit cnotimply_logic(bit a, bit b)
            => cnotimply(a,b);

        public static ulong cnotimply_scalar(ulong a, ulong b)
            => cnotimply(a,b);

        public static Vector128<ulong> cnotimply_v128(Vector128<ulong> a, Vector128<ulong> b)
            => cnotimply(a,b);

        public static Vector256<ulong> cnotimply_v256(Vector256<ulong> a, Vector256<ulong> b)
            => cnotimply(a,b);

    }

    public static class lbmoc
    {
        public static ref BitMatrix<ulong> or_and_xor_bm(in BitMatrix<ulong> a, in BitMatrix<ulong> b, ref BitMatrix<ulong> C)
            => ref or(and(a,b, ref C), xor(a,b, ref C), ref C);

       public static ref BitMatrix<ulong> nand_or_and_xor_bm(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> C)
            => ref nand(B,or(and(A,B, ref C), xor(A,B, ref C), ref C), ref C);


        public static bit comp1_logic(bit a, bit b)
            => or(and(a,b), xor(a,b));

        public static ulong comp1_scalar(ulong a, ulong b)
            => or(and(a,b), xor(a,b));

        public static Vector128<ulong> comp1_v128(Vector128<ulong> a, Vector128<ulong> b)
            => or(and(a,b), xor(a,b));

        public static Vector256<ulong> comp1_v256(Vector256<ulong> a, Vector256<ulong> b)
            => or(and(a,b), xor(a,b));

        public static bit comp2_logic(bit a, bit b)
            => nand(b,or(and(a,b), xor(a,b)));

        public static ulong comp2_scalar(ulong a, ulong b)
            => nand(b, or(and(a,b), xor(a,b)));

        public static Vector128<ulong> comp2_v128(Vector128<ulong> a, Vector128<ulong> b)
            => nand(b,or(and(a,b), xor(a,b)));

        public static Vector256<ulong> comp2_v256(Vector256<ulong> a, Vector256<ulong> b)
            => nand(b,or(and(a,b), xor(a,b)));
    
        public static bit comp3_logic(bit a, bit b)
            => select(a,nand(b,or(and(a,b), xor(a,b))), cnotimply(nor(a,b), xor(b,a)));

        public static ulong comp3_scalar(ulong a, ulong b)
            => select(a,nand(b,or(and(a,b), xor(a,b))), cnotimply(nor(a,b), xor(b,a)));

        public static Vector128<ulong> comp3_v128(Vector128<ulong> a, Vector128<ulong> b)
            => select(a,nand(b,or(and(a,b), xor(a,b))), cnotimply(nor(a,b), xor(b,a)));

        public static Vector256<ulong> comp3_v256(Vector256<ulong> a, Vector256<ulong> b)
            => select(a,nand(b,or(and(a,b), xor(a,b))), cnotimply(nor(a,b), xor(b,a)));

    }
}