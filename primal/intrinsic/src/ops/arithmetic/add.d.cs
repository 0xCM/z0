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
        public static Vector128<byte> vadd(Vector128<byte> lhs, Vector128<byte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<sbyte> vadd(Vector128<sbyte> lhs, Vector128<sbyte> rhs) 
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<short> vadd(Vector128<short> lhs, Vector128<short> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<ushort> vadd(Vector128<ushort> lhs, Vector128<ushort> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<int> vadd(Vector128<int> lhs, Vector128<int> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<uint> vadd(Vector128<uint> lhs, Vector128<uint> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<long> vadd(Vector128<long> lhs, Vector128<long> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<ulong> vadd(Vector128<ulong> lhs, Vector128<ulong> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<byte> vadd(Vector256<byte> lhs, Vector256<byte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<sbyte> vadd(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<short> vadd(Vector256<short> lhs, Vector256<short> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<ushort> vadd(Vector256<ushort> lhs, Vector256<ushort> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<int> vadd(Vector256<int> lhs, Vector256<int> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<uint> vadd(Vector256<uint> lhs, Vector256<uint> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<long> vadd(Vector256<long> lhs, Vector256<long> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<ulong> vadd(Vector256<ulong> lhs, Vector256<ulong> rhs)
            => Add(lhs, rhs);

   }
}