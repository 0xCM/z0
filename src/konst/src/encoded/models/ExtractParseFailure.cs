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
    /// Describes an extract parse failure
    /// </summary>
    public readonly struct ExtractParseFailure
    {
        /// <summary>
        /// The data over which the parse failure occurred
        /// </summary>
        public readonly X86ApiExtract Data;

        /// <summary>
        /// The extracted member sequence
        /// </summary>
        public readonly int Sequence;

        /// <summary>
        /// Specifies the reason the parser stopped parsing
        /// </summary>
        public readonly ExtractTermCode TermCode;

        [MethodImpl(Inline)]
        public ExtractParseFailure(X86ApiExtract data, int seq, ExtractTermCode term)
        {
            Data = data;
            Sequence = seq;
            TermCode = term;
        }

        public OpUri OpUri
            => Data.Member.OpUri;

        public static ExtractParseFailure Empty
            => new ExtractParseFailure(X86ApiExtract.Empty, 0, ExtractTermCode.None);
    }
}