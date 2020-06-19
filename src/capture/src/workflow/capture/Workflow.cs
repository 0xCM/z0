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
        internal CaptureWorkflow(IAsmContext context, IAsmFunctionDecoder decoder, IAsmFormatter formatter, AsmWriterFactory writerfactory, ICaptureArchive archive)
        {
            Broker = CaptureBroker.Service;
            Context = new CaptureWorkflowContext(context, decoder, formatter, writerfactory, Broker, archive);
        }
    }
}