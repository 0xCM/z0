//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    

    public interface IAsmHostCaptureFlow : IAppService<IAsmContext>, IExecutable<AsmHostExtract>
    {
        string Name => GetType().Name;
    }

}
