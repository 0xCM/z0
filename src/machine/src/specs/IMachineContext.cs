//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Asm;

    public interface IMachineContext : IContext
    {
        IAsmContext AsmContext {get;}
        
        IAppMsgSink AppMsgSink {get;}        
        
        PartId[] Parts {get;}

        ICaptureArchive Archive {get;}

        IAsmFunctionDecoder Decoder {get;}

        IAsmFormatter Formatter {get;}
    }
}