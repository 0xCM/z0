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
        /// Parses an extract sequence, returning a comprehensive result set that includes
        /// outcomes of successful parse operations and any unfortunate failures
        /// </summary>
        /// <param name="src">The source extracts</param>
        ApiMemberCodeTable ParseMembers(ReadOnlySpan<X86ApiExtract> src);

        Outcome<ApiMemberCode> ParseMember(in X86ApiExtract src, uint seq);
    }
}