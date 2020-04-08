//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    
    public interface IHostCapture : IService<IAsmContext>, IExecutable<CapturedHost>
    {
        string Name => GetType().Name;             
    }
}