//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;

    using Z0.Asm;

    public interface IMachineContext : IContext
    {
        IAsmContext AsmContext {get;}
        
        IAppMsgSink AppMsgSink {get;}        
        
        PartId[] Parts {get;}

        TCaptureArchive Archive {get;}

        IAsmFunctionDecoder Decoder {get;}

        IAsmFormatter Formatter {get;}

        FolderPath TargetRoot 
            => AsmContext.AppPaths.AppDataPath;
    }
}