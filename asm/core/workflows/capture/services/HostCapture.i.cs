//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    public interface IHostCapture : IAppService<IAsmContext>, IExecutable<CapturedHost>
    {
        string Name => GetType().Name;

             
    }
}