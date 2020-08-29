//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines service contract for persting text-formatted x86 encoded assembly
    /// </summary>
    public interface IMemberCodeWriter : IArchiveWriter
    {
        /// <summary>
        /// Write host bits with a specified uri identifier padding
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="idpad">The padding amount</param>
        void Write(X86ApiCode src, int idpad = 60);
    }

    public interface IMemberCodeWriter<H> : IMemberCodeWriter, IArchiveWriter<H>
        where H : struct, IMemberCodeWriter<H>
    {

    }
}