//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface ICaptureContext : IWfContext
    {
        IAsmDecoder Decoder {get;}

        IAsmFormatter Formatter {get;}

        IWfCaptureBroker CaptureBroker {get;}

        void Raise<E>(E e)
            where E : IAppEvent;

        IAsmWriter AsmWriter(FS.FilePath dst)
            => AsmServices.writer(dst,Formatter);
    }
}