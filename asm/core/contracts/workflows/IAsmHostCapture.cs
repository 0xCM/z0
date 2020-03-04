//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IAsmHostCapture : IAppService<IAsmContext>, IExecutable<AsmHostExtract>
    {
        string Name => GetType().Name;
    }
}