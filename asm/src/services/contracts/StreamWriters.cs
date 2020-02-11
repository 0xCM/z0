//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static zfunc;

    using Z0.AsmSpecs;

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
    public interface IAsmCodeWriter : IAsmStreamWriter
    {
        void Write(in CapturedMember src, int? idpad = null);
    }

    /// <summary>
    /// Defines serivce contract for persting text-formatted x86 encoded assembly 
    /// </summary>
    public interface IAsmRawWriter : IAsmStreamWriter
    {
        void Write(in CapturedMember src, int? idpad = null);
    }

    public interface IAsmFunctionWriter : IAsmStreamWriter
    {
        void Write(AsmFunction src);
    }
}