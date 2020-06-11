//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IUriHexDecoder : IService
    {
        AsmInstructions[] Decode(ReadOnlySpan<UriHex> src);

        int Decode(ReadOnlySpan<UriHex> src, Span<AsmInstructions> dst);        

        Option<AsmInstructions> Decode(UriHex src); 

        Option<AsmInstructionList> Decode(UriCode src);       

        AsmInstructions[] Decode(params UriHex[] src);
    }
}