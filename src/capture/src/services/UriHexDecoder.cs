//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static Konst;
    using static Root;
    
    public readonly struct UriHexDecoder : TUriHexDecoder
    {        
        public static IUriHexDecoder Service => default(UriHexDecoder);

        public static int decode(ReadOnlySpan<IdentifiedCode> src, Span<AsmInstructions> dst)
        {
            var decoder = Capture.Services.AsmDecoder();
            var count = src.Length;
            for(var i=0; i<count; i++)
                 seek(dst,i) = decoder.Decode(skip(src,i)).ValueOrDefault(AsmInstructions.Empty);
            return count;
        }

        public static AsmInstructions[] decode(ReadOnlySpan<IdentifiedCode> src)
        {
            var count = src.Length;
            var dst = Root.alloc<AsmInstructions>(count);
            decode(src, dst);
            return dst;
        }

        public static AsmInstructions[] decode(params IdentifiedCode[] src)
        {
            var count = src.Length;
            var dst = Root.alloc<AsmInstructions>(count);
            decode(src, dst);
            return dst;
        }
        
        public static Option<AsmInstructions> decode(IdentifiedCode src)
            => Capture.DefaultDecoder.Decode(src);

        public static Option<AsmInstructionList> decode(MemberCode src)
            => Capture.DefaultDecoder.Decode(src.Encoded);      
    }
}