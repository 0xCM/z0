//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface ICaptureContext : IShellContext
    {
        IAppContext ContextRoot {get;}

        IAsmDecoder Decoder {get;}

        IAsmFormatter Formatter {get;}

        AsmTextWriterFactory WriterFactory {get;}

        IWfCaptureBroker CaptureBroker {get;}

        void Raise<E>(E e)
            where E : IAppEvent;
    }
}