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
    public static class logix
    {
        public static int work_ring_buffer()
        {
            var buffer = MicroBuffers.ring<byte>(64);
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
            => impl(a,b);

        public static ulong imply_scalar(ulong a, ulong b)
            => impl(a,b);

        public static Vector128<ulong> imply_v128(Vector128<ulong> a, Vector128<ulong> b)
            => impl(a,b);

        public static Vector256<ulong> imply_v256(Vector256<ulong> a, Vector256<ulong> b)
            => impl(a,b);

        public static bit notimply_logic(bit a, bit b)
            => nonimpl(a,b);

        public static ulong notimply_scalar(ulong a, ulong b)
            => nonimpl(a,b);

        public static Vector128<ulong> notimply_v128(Vector128<ulong> a, Vector128<ulong> b)
            => nonimpl(a,b);

        public static Vector256<ulong> notimply_v256(Vector256<ulong> a, Vector256<ulong> b)
            => nonimpl(a,b);

        public static bit cimply_logic(bit a, bit b)
            => cimpl(a,b);

        public static ulong cimply_scalar(ulong a, ulong b)
            => cimpl(a,b);

        public static Vector128<ulong> cimply_v128(Vector128<ulong> a, Vector128<ulong> b)
            => cimpl(a,b);

        public static Vector256<ulong> cimply_v256(Vector256<ulong> a, Vector256<ulong> b)
            => cimpl(a,b);

        public static bit cnotimply_logic(bit a, bit b)
            => cnonimpl(a,b);

        public static ulong cnotimply_scalar(ulong a, ulong b)
            => cnonimpl(a,b);

        public static Vector128<ulong> cnotimply_v128(Vector128<ulong> a, Vector128<ulong> b)
            => cnonimpl(a,b);

        public static Vector256<ulong> cnotimply_v256(Vector256<ulong> a, Vector256<ulong> b)
            => cnonimpl(a,b);
    }
}