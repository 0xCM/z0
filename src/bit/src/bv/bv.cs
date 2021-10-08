//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Root;

    [Free]
    public interface IBv : IBlittable
    {
        DataKind IBlittable.TypeKind
            => DataKind.BitVector;
    }

    [Free]
    public interface IBv<T> : IBv, IBlittable<T>
        where T : unmanaged
    {

    }

    [Free]
    public interface IIndexedBits<T> : IBv<T>
        where T : unmanaged
    {
        bit this[byte i] {get;set;}
    }

    [ApiHost]
    public readonly partial struct BV
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static bv1 bv(N1 n, byte src)
            => new bv1(src);

        [MethodImpl(Inline), Op]
        public static bv2 bv(N2 n, byte src)
            => new bv2(src);

        [MethodImpl(Inline), Op]
        public static bv3 bv(N3 n,byte src)
            => new bv3(src);

        [MethodImpl(Inline), Op]
        public static bv4 bv(N4 n,byte src)
            => new bv4(src);

        [MethodImpl(Inline), Op]
        public static bv5 bv(N5 n,byte src)
            => new bv5(src);

        [MethodImpl(Inline), Op]
        public static bv6 bv(N6 n,byte src)
            => new bv6(src);

        [MethodImpl(Inline), Op]
        public static bv7 bv(N7 n,byte src)
            => new bv7(src);

        [MethodImpl(Inline), Op]
        public static bv8 bv(N8 n,byte src)
            => new bv8(src);

        [MethodImpl(Inline), Op]
        public static bv16 bv(N16 n, ushort src)
            => new bv16(src);

        [MethodImpl(Inline), Op]
        public static bv32 bv(N32 n, uint src)
            => new bv32(src);

        [MethodImpl(Inline), Op]
        public static bv64 bv(N64 n, ulong src)
            => new bv64(src);

        [MethodImpl(Inline), Op]
        public static gbv<ByteBlock8> bv(uint n, ByteBlock8 src)
            => new gbv<ByteBlock8>(n, src);

        [MethodImpl(Inline), Op]
        public static gbv<ByteBlock16> bv(uint n, ByteBlock16 src)
            => new gbv<ByteBlock16>(n, src);

        [MethodImpl(Inline), Op]
        public static gbv<ByteBlock32> bv(uint n, ByteBlock32 src)
            => new gbv<ByteBlock32>(n, src);

        [MethodImpl(Inline), Op]
        public static gbv<ByteBlock64> bv(uint n, ByteBlock64 src)
            => new gbv<ByteBlock64>(n, src);

        [MethodImpl(Inline), Op]
        public static gbv<ByteBlock128> bv(uint n, ByteBlock128 src)
            => new gbv<ByteBlock128>(n, src);
    }
}