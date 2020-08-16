//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IUriHexDecoder : IService
    {
        AsmInstructions[] Decode(ReadOnlySpan<IdentifiedCode> src);

        int Decode(ReadOnlySpan<IdentifiedCode> src, Span<AsmInstructions> dst);        

        Option<AsmInstructions> Decode(IdentifiedCode src); 

        Option<AsmInstructionList> Decode(MemberCode src);       

        AsmInstructions[] Decode(params IdentifiedCode[] src);
    }
}