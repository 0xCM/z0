//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface ICaptureContext : IShellBase
    {
        IAppContext Root {get;}

        IApiSet ApiSet
             => Root;

        IAsmDecoder Decoder {get;}

        IAsmFormatter Formatter {get;}

        AsmTextWriterFactory WriterFactory {get;}

        IWfCaptureBroker CaptureBroker {get;}

        void Raise<E>(E e)
            where E : IAppEvent;
    }
}