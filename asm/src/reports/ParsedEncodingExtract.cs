//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    partial class AsmInternals
    {
        /// <summary>
        /// Gets the parsed encoding described by teh source record
        /// </summary>
        /// <param name="src">The source record</param>
        public static ParsedEncoding ToParsedEncoding(this ParsedEncodingRecord src)
        {
            var count = src.Length;
            var op = OpDescriptor.Define(src.Uri, src.OpSig);
            var range = MemoryRange.Define(src.Address, src.Address + (MemoryAddress)count);
            var final = CaptureState.Define(op.Id, count, range.End, src.Data.LastByte);
            var outcome = CaptureOutcome.Define(final, range, src.TermCode);
            var parsed = ParsedEncoding.Define(op, outcome, src.Data);
            return parsed;                
        }

    }

}