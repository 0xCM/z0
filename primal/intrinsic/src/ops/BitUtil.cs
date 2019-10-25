namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.Intrinsics;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;

    static class BitUtil
    {
        [MethodImpl(Inline)]
        public static Vector128<sbyte> not(Vector128<sbyte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector128<byte> not(Vector128<byte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector128<short> not(Vector128<short> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector128<ushort> not(Vector128<ushort> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector128<int> not(Vector128<int> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector128<uint> not(Vector128<uint> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector128<long> not(Vector128<long> src)
            => not(src.AsUInt32()).AsInt64();

        [MethodImpl(Inline)]
        public static Vector128<ulong> not(Vector128<ulong> src)
            => not(src.AsUInt32()).AsUInt64();

        [MethodImpl(Inline)]
        public static Vector256<sbyte> not(Vector256<sbyte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector256<byte> not(Vector256<byte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector256<short> not(Vector256<short> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector256<ushort> not(Vector256<ushort> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector256<int> not(Vector256<int> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector256<uint> not(Vector256<uint> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector256<long> not(Vector256<long> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector256<ulong> not(Vector256<ulong> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector128<uint> and(Vector128<uint> lhs, Vector128<uint> rhs)
            => And(lhs, rhs);
    }
}