//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static BlockStorage;

    public static class DataBlockX
    {

        [MethodImpl(Inline)]
        public static Span<byte> AsBytes(this ref Block128 src)
            => DataBlocks.bytes(ref src);

        [MethodImpl(Inline)]
        public static Span<byte> AsBytes(this ref Block256 src)
            => DataBlocks.bytes(ref src);

        [MethodImpl(Inline)]
        public static Span<byte> AsBytes(this ref Block512 src)
            => DataBlocks.bytes(ref src);

        [MethodImpl(Inline)]
        public static Span<byte> AsBytes(this ref Block1024 src)
            => DataBlocks.bytes(ref src);

        [MethodImpl(Inline)]
        public static BitString ToBitString(this Block128 src)
            => src.X1.ToBitString().Concat(src.X0.ToBitString());

        [MethodImpl(Inline)]
        public static Span<char> AsChars(this ref CharBlock2 src)
            => DataBlocks.chars(ref src);

        [MethodImpl(Inline)]
        public static Span<char> AsChars(this ref CharBlock4 src)
            => DataBlocks.chars(ref src);

        [MethodImpl(Inline)]
        public static Span<char> AsChars(this ref CharBlock8 src)
            => DataBlocks.chars(ref src);

        [MethodImpl(Inline)]
        public static Span<char> AsChars(this ref CharBlock16 src)
            => DataBlocks.chars(ref src);

        [MethodImpl(Inline)]
        public static string ToString(this CharBlock2 src)
            => DataBlocks.chars(ref src).ToString();

        [MethodImpl(Inline)]
        public static string ToString(this CharBlock4 src)
            => DataBlocks.chars(ref src).ToString();

        [MethodImpl(Inline)]
        public static string ToString(this CharBlock8 src)
            => DataBlocks.chars(ref src).ToString();

        [MethodImpl(Inline)]
        public static string ToString(this CharBlock16 src)
            => DataBlocks.chars(ref src).ToString();

    }


}