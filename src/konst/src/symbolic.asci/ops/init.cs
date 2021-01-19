//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static asci2 init(AsciCharCode c0, AsciCharCode c1)
            => new asci2(pack(c0,c1, out var dst));

        [MethodImpl(Inline), Op]
        public static asci2 init(N2 n)
            => new asci2(0x2020);

        [MethodImpl(Inline), Op]
        public static asci4 init(AsciCharCode c0, AsciCharCode c1, AsciCharCode c2, AsciCharCode c3)
            => new asci4(pack(c0,c1,c2,c3, out var dst));

        [MethodImpl(Inline), Op]
        public static asci4 init(N4 n)
            => new asci4(0x20202020);

        [MethodImpl(Inline), Op]
        public static asci8 init(N8 n, AsciCharCode fill = AsciCharCode.Space)
            => new asci8(z.vlo64(z.vbroadcast(w128, (byte)fill)));

        [MethodImpl(Inline), Op]
        public static asci16 init(N16 n, AsciCharCode fill = AsciCharCode.Space)
            => new asci16(z.vbroadcast(w128, (byte)fill));

        [MethodImpl(Inline), Op]
        public static asci32 init(N32 n, AsciCharCode fill = AsciCharCode.Space)
            => new asci32(z.vbroadcast(w256, (byte)fill));

        [MethodImpl(Inline)]
        public static asci2 init(N2 n, ReadOnlySpan<AsciCharCode> src)
            => new asci2(z.first(recover<AsciCharCode,ushort>(src)));

        [MethodImpl(Inline), Op]
        public static asci4 init(N4 n, ReadOnlySpan<AsciCharCode> src)
            => new asci4(z.first(recover<AsciCharCode,asci4>(src)));

        [MethodImpl(Inline), Op]
        public static asci8 init(N8 n, ReadOnlySpan<AsciCharCode> src)
            => new asci8(z.first(z.recover<AsciCharCode,asci8>(src)));

        [MethodImpl(Inline), Op]
        public static asci16 init(N16 n, ReadOnlySpan<AsciCharCode> src)
            => new asci16(recover<AsciCharCode,byte>(src));

        [MethodImpl(Inline), Op]
        public static asci32 init(N32 n, ReadOnlySpan<AsciCharCode> src)
            => new asci32(recover<AsciCharCode,byte>(src));

        [MethodImpl(Inline), Op]
        public static asci64 init(N64 n, ReadOnlySpan<AsciCharCode> src)
            => new asci64(recover<AsciCharCode,byte>(src));

        [MethodImpl(Inline), Op]
        public static asci64 init(N64 n, AsciCharCode fill = AsciCharCode.Space)
            => new asci64(cpu.vbroadcast(w512, (byte)fill));

        [MethodImpl(Inline), Op]
        public static asci2 init(N2 n, ReadOnlySpan<byte> src)
            => view(n, memory.first(recover<byte,ushort>(src)));

        [MethodImpl(Inline), Op]
        public static asci4 init(N4 n, ReadOnlySpan<byte> src)
            => view(n, memory.first(recover<byte,uint>(src)));

        [MethodImpl(Inline), Op]
        public static asci8 init(N8 n, ReadOnlySpan<byte> src)
            => view(n, memory.first(recover<byte,uint>(src)));

        [MethodImpl(Inline), Op]
        public static asci16 init(N16 n, ulong lo, ulong hi)
            => new asci16(Vector128.Create(lo,hi).AsByte());
    }
}