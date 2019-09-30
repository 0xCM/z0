//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;

    using static zfunc;    

    partial class inxoc
    {
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vadd_n128x8i(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> vadd_d128x8i(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs) 
            => dinx.vadd(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> vadd_g128x8i(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs) 
            => ginx.vadd(in lhs, in rhs);

        // ~

        [MethodImpl(Inline)]
        public static Vector128<byte> vadd_n128x8u(Vector128<byte> lhs, Vector128<byte> rhs)
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> vadd_d128x8u(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => dinx.vadd(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> vadd_g128x8u(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => ginx.vadd(in lhs, in rhs);

        // ~

        [MethodImpl(Inline)]
        public static Vector128<short> vadd_n128x16i(Vector128<short> lhs, Vector128<short> rhs)
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> vadd_d128x16i(in Vec128<short> lhs, in Vec128<short> rhs)
            => dinx.vadd(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> vadd_g128x16i(in Vec128<short> lhs, in Vec128<short> rhs)
            => ginx.vadd(in lhs, in rhs);

        // ~

        [MethodImpl(Inline)]
        public static Vector128<ushort> vadd_n128x16u(Vector128<ushort> lhs, Vector128<ushort> rhs)
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> vadd_d128x16u(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => dinx.vadd(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> vadd_g128x16u(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => ginx.vadd(in lhs, in rhs);

        // ~

        [MethodImpl(Inline)]
        public static Vector128<int> vadd_n128x32i(Vector128<int> lhs,Vector128<int> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> vadd_d128x32i(in Vec128<int> lhs, in Vec128<int> rhs)
            => dinx.vadd(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> vadd_g128x32i(in Vec128<int> lhs, in Vec128<int> rhs)
            => ginx.vadd(in lhs, in rhs);

        // ~

        [MethodImpl(Inline)]
        public static Vector128<uint> vadd_n128x32u(Vector128<uint> lhs, Vector128<uint> rhs)
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> vadd_d128x32u(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => dinx.vadd(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> vadd_g128x32u(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => ginx.vadd(in lhs, in rhs);

        // ~

        [MethodImpl(Inline)]
        public static Vector128<long> vadd_n128x64i(Vector128<long> lhs, Vector128<long> rhs)
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> vadd_d128x64i(in Vec128<long> lhs, in Vec128<long> rhs)
            => dinx.vadd(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> vadd_g128x64i(in Vec128<long> lhs, in Vec128<long> rhs)
            => ginx.vadd(in lhs, in rhs);

        // ~

        [MethodImpl(Inline)]
        public static Vector128<ulong> vadd_n128x64u(Vector128<ulong> lhs, Vector128<ulong> rhs)
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> vadd_d128x64u(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => dinx.vadd(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> vadd_g128x64u(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => ginx.vadd(in lhs, in rhs);

        // ~ 

        [MethodImpl(Inline)]
        public static Vector128<float> vadd_n128x32f(Vector128<float> lhs, Vector128<float> rhs)
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> vadd_d128x32f(in Vec128<float> lhs, in Vec128<float> rhs)
            => dfp.vadd(in lhs, in lhs);

        [MethodImpl(Inline)]
        public static Vec128<float> vadd_g128x32f(in Vec128<float> lhs, in Vec128<float> rhs)
            => ginx.vadd(in lhs, in lhs);

        // ~

        [MethodImpl(Inline)]
        public static Vector128<double> vadd_n128x64f(Vector128<double> lhs, Vector128<double> rhs)
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> vadd_d128x64f(in Vec128<double> lhs, in Vec128<double> rhs)
            => dfp.vadd(in lhs, in lhs);

        [MethodImpl(Inline)]
        public static Vec128<double> vadd_g128x64f(in Vec128<double> lhs, in Vec128<double> rhs)
            => ginx.vadd(in lhs, in lhs);

    }
}