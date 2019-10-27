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
        public static Vector128<byte> vadd(Vector128<byte> x, Vector128<byte> y)
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector128<sbyte> vadd(Vector128<sbyte> x, Vector128<sbyte> y) 
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector128<short> vadd(Vector128<short> x, Vector128<short> y)
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector128<ushort> vadd(Vector128<ushort> x, Vector128<ushort> y)
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector128<int> vadd(Vector128<int> x, Vector128<int> y)
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector128<uint> vadd(Vector128<uint> x, Vector128<uint> y)
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector128<long> vadd(Vector128<long> x, Vector128<long> y)
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector128<ulong> vadd(Vector128<ulong> x, Vector128<ulong> y)
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector256<byte> vadd(Vector256<byte> x, Vector256<byte> y)
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector256<sbyte> vadd(Vector256<sbyte> x, Vector256<sbyte> y)
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector256<short> vadd(Vector256<short> x, Vector256<short> y)
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector256<ushort> vadd(Vector256<ushort> x, Vector256<ushort> y)
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector256<int> vadd(Vector256<int> x, Vector256<int> y)
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector256<uint> vadd(Vector256<uint> x, Vector256<uint> y)
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector256<long> vadd(Vector256<long> x, Vector256<long> y)
            => Add(x, y);

        [MethodImpl(Inline)]
        public static Vector256<ulong> vadd(Vector256<ulong> x, Vector256<ulong> y)
            => Add(x, y);

   }
}