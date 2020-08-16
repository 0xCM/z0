//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface ICaptureContext : IAppBase
    {
        IAsmContext Asm{get;}
        
        IApiSet ApiSet {get;}

        IExtractionParser Parser {get;}

        IAsmRoutineDecoder Decoder {get;}

        IAsmFormatter Formatter {get;}

        AsmWriterFactory WriterFactory {get;}

        IWfCaptureBroker CaptureBroker {get;}

        IPartCaptureArchive Archive {get;}

        IAppMsgSink MsgSink {get;}

        void Raise<E>(E e)
            where E : IAppEvent; 
    }
}