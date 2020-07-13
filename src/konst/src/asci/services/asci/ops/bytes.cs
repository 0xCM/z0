//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> bytes(ReadOnlySpan<AsciCharCode> src)
            => z.recover<AsciCharCode,byte>(src);        

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci2 src)
            => z.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci4 src)
            => z.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci8 src)
            => z.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci16 src)
            => z.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci32 src)
            => z.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci64 src)
            => z.bytes(src);
    }
}