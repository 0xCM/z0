//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;

    public interface IAsmFunctionDecoder : IService
    {        
        /// <summary>
        /// Decodes a function from the parsed encoding package
        /// </summary>
        /// <param name="parsed">The parsed data</param>
        Option<AsmFunction> DecodeParsed(ParsedMember parsed);

        Option<AsmFunction> DecodeCaptured(ApiMemberCapture src);       

        Option<AsmFunction> DecodeExtract(ParsedExtract src);
    }
}