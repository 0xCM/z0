//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
 
    using static zfunc;

    partial class inxsoc
    {
        public static UInt128 clmul(ulong x, ulong y)
            => Cl.clmul(x,y);

        public static ref UInt128 clmul(ulong x, ulong y, ref UInt128 dst)
            => ref Cl.clmul(x,y, ref dst);

        public static ulong clmulr8u(ulong a, ulong b, ulong poly)
            => Cl.clmulr8u(a,b,poly);
    }

    public static class Cl
    {
        [MethodImpl(Inline)]
        public static UInt128 clmul(ulong x, ulong y)
        {
            var u = Vec128.scalar(x);
            var v = Vec128.scalar(y);
            var z = CarrylessMultiply(u, v, 0);
            var dst = default(UInt128);
            ginx.vstore(z, ref dst.lo);
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<ulong> clmul(ulong x, ulong y, out Vec128<ulong> dst)
        {
            var u = Vec128.scalar(x);
            var v = Vec128.scalar(y);
            dst = CarrylessMultiply(u, v, 0);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ulong clmulr8u(ulong a, ulong b, ulong poly)
        {
            var prod = default(UInt128);
            clmul(a,b, ref prod);
            prod.lo ^= clmul(prod.lo >> 8, poly).lo;
            prod.lo ^= clmul(prod.lo >> 8, poly).lo;
            return prod.lo;
        }

        [MethodImpl(Inline)]
        public static ref UInt128 clmul(ulong x, ulong y, ref UInt128 dst)
        {

            var u = Vec128.scalar(x);
            var v = Vec128.scalar(y);
            var z = CarrylessMultiply(u, v, 0);
            ginx.vstore(z,ref dst.lo);
            return ref dst;
        }
    }

}