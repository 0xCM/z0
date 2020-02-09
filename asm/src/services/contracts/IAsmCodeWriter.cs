//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    /// <summary>
    /// Defines serivce contract for persting text-formatted x86 encoded assembly 
    /// </summary>
    public interface IAsmCodeWriter : IAsmServiceAllocation
    {
        void Write(AsmCode src, int? idpad = null);
        
        void Write(AsmCode[] src, int? idpad = null);        
        
        /// <summary>
        /// The path to which data is writting
        /// </summary>
        FilePath TargetPath {get;}

    }
}