//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vor(Vector128<byte> x, Vector128<byte> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector128<short> vor(Vector128<short> x, Vector128<short> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vor(Vector128<sbyte> x, Vector128<sbyte> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vor(Vector128<ushort> x, Vector128<ushort> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector128<int> vor(Vector128<int> x, Vector128<int> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector128<uint> vor(Vector128<uint> x, Vector128<uint> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector128<long> vor(Vector128<long> x, Vector128<long> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vor(Vector128<ulong> x, Vector128<ulong> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector256<byte> vor(Vector256<byte> x, Vector256<byte> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector256<short> vor(Vector256<short> x, Vector256<short> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vor(Vector256<sbyte> x, Vector256<sbyte> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vor(Vector256<ushort> x, Vector256<ushort> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector256<int> vor(Vector256<int> x, Vector256<int> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector256<uint> vor(Vector256<uint> x, Vector256<uint> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector256<long> vor(Vector256<long> x, Vector256<long> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vor(Vector256<ulong> x, Vector256<ulong> y)
            => Or(x, y);
    }
}