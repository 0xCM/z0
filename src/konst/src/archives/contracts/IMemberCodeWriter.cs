//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines serivce contract for persting text-formatted x86 encoded assembly 
    /// </summary>
    public interface IMemberCodeWriter : IFileStreamWriter
    {
        /// <summary>
        /// Write host bits with a specified uri identifier padding
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="idpad">The padding amount</param>
        void Write(MemberCode src, int idpad = 60);
    }
}