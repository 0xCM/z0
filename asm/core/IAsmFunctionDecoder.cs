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
        /// Decodes a function from a member capture
        /// </summary>
        /// <param name="src">The cource capture</param>
        AsmFunction DecodeFunction(CapturedOp member);   

        /// <summary>
        /// Decodes a function from the parsed encoding package
        /// </summary>
        /// <param name="parsed">The parsed data</param>
        AsmFunction DecodeFunction(ParsedMemberCode parsed);

        
        AsmFunction[] Decode(params ParsedExtract[] src);     
    }
}