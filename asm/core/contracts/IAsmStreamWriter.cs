//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAsmStreamWriter : IAsmServiceAllocation
    {
        /// <summary>
        /// The writer output path
        /// </summary>
        FilePath TargetPath {get;}        
    }

    /// <summary>
    /// Defines serivce contract for persting text-formatted x86 encoded assembly 
    /// </summary>
    public interface IAsmRawWriter : IAsmStreamWriter
    {
        void Write(in AsmMemberCapture src, int? idpad = null);

        void Write(OpIdentity id, Span<byte> data, int? idpad = null);
    }
}