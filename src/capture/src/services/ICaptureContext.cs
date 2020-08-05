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

        IMemberExtractor Extractor {get;}

        IExtractParser Parser {get;}

        IAsmFunctionDecoder Decoder {get;}

        IAsmFormatter Formatter {get;}

        AsmWriterFactory WriterFactory {get;}

        ICaptureBroker CaptureBroker {get;}

        TPartCaptureArchive Archive {get;}

        IAppMsgSink MsgSink {get;}

        void Raise<E>(E e)
            where E : IAppEvent; 
    }
}