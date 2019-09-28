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

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;

    public static partial class dinx
    {
        
        [MethodImpl(Inline)]
        public static Vec128<byte> or(Vec128<byte> lhs, Vec128<byte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> or(Vec128<short> lhs, Vec128<short> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> or(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> or(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> or(Vec128<int> lhs, Vec128<int> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> or(Vec128<uint> lhs, Vec128<uint> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> or(Vec128<long> lhs, Vec128<long> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> or(Vec128<ulong> lhs, Vec128<ulong> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> or(Vec128<float> lhs, Vec128<float> rhs)
            => Or(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> or(Vec128<double> lhs, Vec128<double> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> or(Vec256<byte> lhs, Vec256<byte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> or(Vec256<short> lhs, Vec256<short> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> or(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> or(Vec256<ushort> lhs, Vec256<ushort> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> or(Vec256<int> lhs, Vec256<int> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> or(Vec256<uint> lhs, Vec256<uint> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> or(Vec256<long> lhs, Vec256<long> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> or(Vec256<ulong> lhs, Vec256<ulong> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> or(Vec256<float> lhs, Vec256<float> rhs)
            => Or(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec256<double> or(Vec256<double> lhs, Vec256<double> rhs)
            => Or(lhs, rhs);
    }

}