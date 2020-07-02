//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static UriHexDecoder;

    public interface TUriHexDecoder : IUriHexDecoder
    {
        AsmInstructions[] IUriHexDecoder.Decode(ReadOnlySpan<IdentifiedCode> src)
            => decode(src);
            
        int IUriHexDecoder.Decode(ReadOnlySpan<IdentifiedCode> src, Span<AsmInstructions> dst)
            => decode(src,dst);
        

        Option<AsmInstructions> IUriHexDecoder.Decode(IdentifiedCode src)
            => decode(src);
  

        Option<AsmInstructionList> IUriHexDecoder.Decode(MemberCode src)
            => decode(src);


        AsmInstructions[] IUriHexDecoder.Decode(params IdentifiedCode[] src)
            => decode(src);
    }
}