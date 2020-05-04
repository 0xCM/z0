//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    using static Seed;
    using static Memories;

    /// <summary>
    /// Describes an extract parse failure
    /// </summary>
    public readonly struct ExtractParseFailure
    {
        public static ExtractParseFailure Empty => new ExtractParseFailure(ExtractedMember.Empty, 0, ExtractTermCode.None);
        
        /// <summary>
        /// The data over which the parse failure occurrred
        /// </summary>
        public readonly ExtractedMember Data;   

        /// <summary>
        /// The extracted member sequence
        /// </summary>
        public readonly int Sequence;

        /// <summary>
        /// Specifies the reason the parser stopped parsing
        /// </summary>
        public readonly ExtractTermCode TermCode;
        
        [MethodImpl(Inline)]
        public ExtractParseFailure(ExtractedMember data, int seq, ExtractTermCode term)
        {
            Data = data;
            Sequence = seq;
            TermCode = term;
        }

        public OpUri OpUri => Data.Member.OpUri;
    }
}