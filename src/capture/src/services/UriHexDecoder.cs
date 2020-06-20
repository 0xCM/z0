//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static Konst;
    using static Memories;

    public readonly struct UriHexDecoder : IUriHexDecoder
    {        
        public static IUriHexDecoder Service => default(UriHexDecoder);
                    
        
        public int Decode(ReadOnlySpan<UriHex> src, Span<AsmInstructions> dst)
        {
            var decoder = Capture.Services.AsmDecoder();
            var count = src.Length;
            for(var i=0; i<count; i++)
                 seek(dst,i) = decoder.Decode(skip(src,i)).ValueOrDefault(AsmInstructions.Empty);
            return count;
        }

        public AsmInstructions[] Decode(ReadOnlySpan<UriHex> src)
        {
            var count = src.Length;
            var dst = Root.alloc<AsmInstructions>(count);
            Decode(src, dst);
            return dst;
        }

        public AsmInstructions[] Decode(params UriHex[] src)
        {
            var count = src.Length;
            var dst = Root.alloc<AsmInstructions>(count);
            Decode(src, dst);
            return dst;
        }

        public Option<AsmInstructions> Decode(UriHex src)
            => Capture.Services.DefaultFunctionDecoder.Decode(src);

        public Option<AsmInstructionList> Decode(UriCode src)
            => Capture.Services.DefaultFunctionDecoder.Decode(src.Encoded);            
    }
}