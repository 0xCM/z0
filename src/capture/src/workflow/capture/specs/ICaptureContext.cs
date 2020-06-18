//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface ICaptureContext : IContext
    {
        IApiSet ApiSet {get;}

        IMemberExtractor Extractor {get;}

        IExtractParser Parser {get;}

        IAsmFunctionDecoder Decoder {get;}

        IAsmFormatter Formatter {get;}

        AsmWriterFactory WriterFactory {get;}

        ICaptureBroker Broker {get;}

        ICaptureArchive Archive {get;}

        IAppMsgSink MsgSink {get;}

        ref readonly E Raise<E>(in E e)
            where E : IAppEvent;

        CorrelationToken Correlate();                    
    }
}