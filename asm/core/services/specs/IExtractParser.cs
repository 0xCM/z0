//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    /// <summary>
    /// Characterizes a service that consumes raw extract bytes and emits, hopefully,
    /// a sequence of bytes that defines member content exactly, with no more nor less
    /// bits than needed
    /// </summary>    
    public interface IExtractParser : IService
    {
        /// <summary>
        /// Parses a single extract
        /// </summary>
        /// <param name="src">The source extract</param>
        /// <param name="seq">The sequence number to confer upon the result</param>
        Option<ParsedExtract> Parse(in MemberExtract src, int seq = 0);

        /// <summary>
        /// Parses an extract sequence
        /// </summary>
        /// <param name="src">The source extracts</param>
        ParsedExtract[] Parse(MemberExtract[] src);
    }

}