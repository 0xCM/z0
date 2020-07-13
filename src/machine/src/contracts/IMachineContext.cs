//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    public interface IMachineContext : IContext
    {
        IAsmContext AsmContext {get;}
        
        IAppMsgSink AppMsgSink {get;}        
        
        PartId[] Parts {get;}

        TPartCaptureArchive Archive {get;}

        IAsmFunctionDecoder Decoder {get;}

        IAsmFormatter Formatter {get;}

        FolderPath TargetRoot 
            => AsmContext.AppPaths.AppDataRoot;
    }
}