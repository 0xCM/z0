//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.AsmSpecs;

    using static zfunc;

    public interface IAsmHexWriter : IDisposable, IAsmService
    {
        void Write(AsmCode src, int? idpad = null);
        
        void Write(AsmCode[] src, int? idpad = null);        
        
        void Write(CapturedMember src, int? idpad = null);

        void Write(CapturedMember[] src, int? idpad = null);

        FilePath TargetPath {get;}

    }
}