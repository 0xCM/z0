//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    /// <summary>
    /// Characterizes a service that extracts host-defined operations
    /// </summary>
    public interface IMemberExtractor : IService
    {
        /// <summary>
        /// Extracts encoded content that defines executable code for a located member
        /// </summary>
        /// <param name="src">The source member</param>
        ExtractedMember Extract(ApiMember src);        

        /// <summary>
        /// Extracts encoded content that defines executable code for an array of located members
        /// </summary>
        /// <param name="src">The source member</param>
        ExtractedMember[] Extract(ApiMember[] src);

        /// <summary>
        /// Extracts encoded content for all operations defined by a host
        /// </summary>
        /// <param name="src">The source member</param>
        ExtractedMember[] Extract(IApiHost src);        
    }
}