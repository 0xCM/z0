//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;

    using Z0.Asm;

    public interface IAsmFunctionDecoder : IAsmService
    {        
        /// <summary>
        /// Decodes a function from a member capture
        /// </summary>
        /// <param name="src">The cource capture</param>
        AsmFunction DecodeFunction(AsmMemberCapture member, bool emitcil = true);   

        /// <summary>
        /// Decodes a function from the parsed encoding package
        /// </summary>
        /// <param name="parsed">The parsed data</param>
        AsmFunction DecodeFunction(ParsedEncoding parsed);
    }
}