//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public interface IAsmContextual : IServiceFactory<IAsmContext>, ICaptureServices 
    {
        IHostCaptureService HostCaptureService(FolderPath root);

        IEvalWorkflow CreateEvalWorkflow(AsmArchiveConfig config)
        {
            var mx = AppMsgExchange.Create(Context);
            var ac = Z0.AppContext.Create(Context.ApiSet, Context.Random, Context.Settings, mx);
            return EvalWorkflow.Create(ac, ac.Random, config.ArchiveRoot);
        }
    }
}