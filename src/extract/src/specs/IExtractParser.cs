//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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
        ExtractParseResult Parse(ExtractedCode src, int seq);

        /// <summary>
        /// Parses an extract sequence, returning a comprehensive result set that includes
        /// outcomes of successful parse operations and any unfortunate failures
        /// </summary>
        /// <param name="src">The source extracts</param>
        ExtractParseResults Parse(ExtractedCode[] src);
    }
}