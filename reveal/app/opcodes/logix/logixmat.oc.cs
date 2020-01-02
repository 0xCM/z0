//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using Z0.Logix;

    using static zfunc;
    using static Logix.LogicOps;
    using static Logix.ScalarOps;
    using static Logix.CpuOps;
    using static Logix.BitMatrixOps;
    using static Logix.BitVectorOps;

    [OpCodeProvider]
    public static class logixmat
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
