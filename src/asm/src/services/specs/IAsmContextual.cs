//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public interface IAsmContextual : IServiceFactory<IAsmContext>, ICaptureServices 
    {
        IHostCaptureService HostCaptureService(FolderName area, FolderName subject = null);            

        IHostCaptureService HostCaptureService(FolderPath root);
    }
}