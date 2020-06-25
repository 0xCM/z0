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

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;
    using static Memories;

    partial class Vectors
    {
        [MethodImpl(Inline)]
        public static Vector128<ulong> vlo(Vector128<ulong> src)
            => vscalar(n128,src.GetElement(0));

        [MethodImpl(Inline)]
        public static Vector128<sbyte> vlo(Vector256<sbyte> src)
            => ExtractVector128(src, 0);

        [MethodImpl(Inline)]
        public static Vector128<byte> vlo(Vector256<byte> src)
            => ExtractVector128(src, 0);

        [MethodImpl(Inline)]
        public static Vector128<short> vlo(Vector256<short> src)
            => ExtractVector128(src, 0);

        [MethodImpl(Inline)]
        public static Vector128<ushort> vlo(Vector256<ushort> src)
            => ExtractVector128(src, 0);

        [MethodImpl(Inline)]
        public static Vector128<int> vlo(Vector256<int> src)
            => ExtractVector128(src, 0);

        [MethodImpl(Inline)]
        public static Vector128<uint> vlo(Vector256<uint> src)
            => ExtractVector128(src, 0);

        [MethodImpl(Inline)]
        public static Vector128<long> vlo(Vector256<long> src)
            => ExtractVector128(src, 0);

        [MethodImpl(Inline)]
        public static Vector128<ulong> vlo(Vector256<ulong> src)
            => ExtractVector128(src, 0);

        [MethodImpl(Inline)]
        public static Vector128<float> vlo(Vector256<float> src)
            => ExtractVector128(src, 0);

        [MethodImpl(Inline)]
        public static Vector128<double> vlo(Vector256<double> src)
            => ExtractVector128(src, 0);

        [MethodImpl(Inline)]
        public static void vlo(Vector256<ulong> src, out ulong x0, out ulong x1)
        {
            x0 = src.GetElement(0);
            x1 = src.GetElement(1);
        }
    }
}