//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a service that consumes raw extract bytes and emits, hopefully,
    /// a sequence of bytes that defines member content exactly, with no more nor less
    /// bits than needed
    /// </summary>
    public interface IExtractParser
    {
        /// <summary>
        /// Parses a single extract
        /// </summary>
        /// <param name="src"></param>
        /// <param name="seq"></param>
        ExtractParseResult Parse(in X86ApiExtract src, uint seq);

        /// <summary>
        /// Parses an extract sequence, returning a comprehensive result set that includes
        /// outcomes of successful parse operations and any unfortunate failures
        /// </summary>
        /// <param name="src">The source extracts</param>
        X86ApiMembers ParseMembers(ReadOnlySpan<X86ApiExtract> src);

        Outcome<X86ApiMember> ParseMember(in X86ApiExtract src, uint seq);


        ExtractParseResults Parse(X86ApiExtract[] src);
    }
}