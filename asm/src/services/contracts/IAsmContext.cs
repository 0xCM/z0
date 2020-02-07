//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using AsmSpecs;

    using static zfunc;

    public interface IAsmContext : IOpContext
    {
        int ContextId {get;}
        
        IClrIndex ClrIndex {get;}

        AsmFormatConfig AsmFormat {get;}

        CilFormatConfig CilFormat {get;}

        IAssemblyComposition Assemblies {get;}

        DataResourceIndex Resources {get;}

        IAsmContext WithFormat(AsmFormatConfig config);

        IAsmContext WithEmptyClrIndex();
    }
}