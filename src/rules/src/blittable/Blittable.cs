//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Blit;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct BZ
    {
        const NumericKind Closure = UnsignedInts;

        const byte TypeKindCount = 11;

        [MethodImpl(Inline), Op]
        public static SmallName name(ReadOnlySpan<char> src)
        {
            var present = 0u;
            for(var i=0; i<present; i++)
            {
                if(skip(src,i) != 0)
                    present++;
                else
                    break;
            }
            var length = min(present,SmallName.MaxLength);
            var storage = Cell128.Empty;
            var dst = storage.Bytes;
            for(var i=0; i<length; i++)
                seek(dst,i) = (byte)skip(src,i);
            seek(dst,15) = (byte)length;
            return new SmallName(storage);
        }

        [MethodImpl(Inline), Op]
        public static u1<bit> u1(bit src)
            => new u1<bit>(src);

        [MethodImpl(Inline), Op]
        public static u1<byte> u1(byte src)
            => new u1<byte>(src);

        [MethodImpl(Inline), Op]
        public static u2<byte> u2(byte src)
            => new u2<byte>(src);

        [MethodImpl(Inline), Op]
        public static u3<byte> u3(byte src)
            => new u3<byte>(src);

        [MethodImpl(Inline), Op]
        public static u4<byte> u4(byte src)
            => new u4<byte>(src);

        [MethodImpl(Inline), Op]
        public static u5<byte> u5(byte src)
            => new u5<byte>(src);

        [MethodImpl(Inline), Op]
        public static u6<byte> u6(byte src)
            => new u6<byte>(src);

        [MethodImpl(Inline), Op]
        public static u8<byte> u8(byte src)
            => new u8<byte>(src);

        [MethodImpl(Inline), Op]
        public static u16<ushort> u16(ushort src)
            => new u16<ushort>(src);

        [MethodImpl(Inline), Op]
        public static u32<uint> u32(uint src)
            => new u32<uint>(src);

        [MethodImpl(Inline), Op]
        public static u64<ulong> u64(ulong src)
            => new u64<ulong>(src);

        [MethodImpl(Inline), Op]
        public static v1<bit> v1(bit[] src)
            => new v1<bit>(src);

        [MethodImpl(Inline), Op]
        public static v1<byte> v1(byte[] src)
            => new v1<byte>(src);

        [MethodImpl(Inline), Op]
        public static v8<byte> v8(byte[] src)
            => new v8<byte>(src);

        [MethodImpl(Inline), Op]
        public static v16<ushort> v16(ushort[] src)
            => new v16<ushort>(src);

        [MethodImpl(Inline), Op]
        public static v32<uint> v32(uint[] src)
            => new v32<uint>(src);

        [MethodImpl(Inline), Op]
        public static v64<ulong> v64(ulong[] src)
            => new v64<ulong>(src);

        [MethodImpl(Inline), Op]
        public static v64<MemoryAddress> v64(MemoryAddress[] src)
            => new v64<MemoryAddress>(src);
    }
}
