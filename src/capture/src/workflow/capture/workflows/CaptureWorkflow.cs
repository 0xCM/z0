//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct CaptureWorkflow : ICaptureWorkflow
    {
        public ICaptureContext Context {get;}

        public ICaptureBroker Broker {get;}
        
        [MethodImpl(Inline)]
        internal CaptureWorkflow(IAsmContext context, IAsmFunctionDecoder decoder, IAsmFormatter formatter, AsmWriterFactory writerfactory, TPartCaptureArchive archive)
        {
            Broker = CaptureBroker.Allocate(context.AppPaths.AppStandardOutPath);
            Context = new CaptureContext(context, decoder, formatter, writerfactory, Broker, archive);
        }

        public void Dispose()
        {
            Broker.Dispose();
        }
    }
}