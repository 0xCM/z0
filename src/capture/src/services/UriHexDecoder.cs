//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Konst;
    using static z;

    public readonly struct UriHexDecoder
    {
        public static int decode(ReadOnlySpan<X86UriHex> src, Span<AsmInstructions> dst)
        {
            var decoder = Capture.Services.RoutineDecoder();
            var count = src.Length;
            for(var i=0u; i<count; i++)
                 seek(dst,i) = decoder.Decode(skip(src,i)).ValueOrDefault(AsmInstructions.Empty);
            return count;
        }

        public static AsmInstructions[] decode(ReadOnlySpan<X86UriHex> src)
        {
            var count = src.Length;
            var dst = alloc<AsmInstructions>(count);
            decode(src, dst);
            return dst;
        }

        public static AsmInstructions[] decode(params X86UriHex[] src)
        {
            var count = src.Length;
            var dst = alloc<AsmInstructions>(count);
            decode(src, dst);
            return dst;
        }

        public static Option<AsmInstructions> decode(X86UriHex src)
            => Capture.DefaultDecoder.Decode(src);

        public static Option<AsmFxList> decode(X86ApiCode src)
            => Capture.DefaultDecoder.Decode(src.Encoded);
    }
}