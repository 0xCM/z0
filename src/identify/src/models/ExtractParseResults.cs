//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Defines the shape of a sequential extract parse operation
    /// </summary>
    public readonly struct ExtractParseResults
    {
        /// <summary>
        /// The unparseable members
        /// </summary>
        public readonly ExtractParseFailure[] Failed;

        /// <summary>
        /// The parsed members
        /// </summary>
        public readonly ParsedMember[] Parsed;

        [MethodImpl(Inline)]
        public static implicit operator ExtractParseResults((ExtractParseFailure[] fail, ParsedMember[] parsed) src)
            => new ExtractParseResults(src.fail, src.parsed);
        
        [MethodImpl(Inline)]
        public ExtractParseResults(ExtractParseFailure[] fail, ParsedMember[] parsed)
        {
            Parsed = parsed;
            Failed = fail;
        }

        public static ExtractParseResults Empty 
            => new ExtractParseResults(Array.Empty<ExtractParseFailure>(), Array.Empty<ParsedMember>());
    }
}