//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmOpContent : ISized
    {

    }

    public interface IAsmOpContent<T> : IAsmOpContent
        where T : struct
    {
        T Data {get;}
    }

    public interface IAsmOpContent<W,T> : IAsmOpContent<T>, ISized<W>
        where T : struct
        where W : unmanaged
    {

    }

}