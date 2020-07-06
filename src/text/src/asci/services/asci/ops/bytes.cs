//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> bytes(ReadOnlySpan<AsciCharCode> src)
            => Root.cast<AsciCharCode,byte>(src);        

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci2 src)
            => Root.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci4 src)
            => Root.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci8 src)
            => Root.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci16 src)
            => As.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci32 src)
            => As.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci64 src)
            => As.bytes(src);
    }
}