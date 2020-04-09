//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    /// <summary>
    /// Characterizes a service that extracts host-defined operations
    /// </summary>
    public interface IHostOpExtractor : IService
    {
        /// <summary>
        /// Extracts encoded content that defines executable code for a located member
        /// </summary>
        /// <param name="src">The source member</param>
        MemberExtract Extract(in ApiMember src);        

        /// <summary>
        /// Extracts encoded content that defines executable code for an array of located members
        /// </summary>
        /// <param name="src">The source member</param>
        MemberExtract[] Extract(ApiMember[] src);

        /// <summary>
        /// Extracts encoded content for all operations defined by a host
        /// </summary>
        /// <param name="src">The source member</param>
        MemberExtract[] Extract(ApiHost src);        
    }
}