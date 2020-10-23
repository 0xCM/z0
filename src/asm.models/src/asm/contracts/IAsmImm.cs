//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAsmImm
    {

    }

    public interface IAsmImm<T> : IAsmImm
        where T : unmanaged
    {

    }

    public interface IAsmImm<W,T> : IAsmImm<T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }

    public interface IAsmImm<F,W,T> : IAsmImm<W,T>
        where F : unmanaged, IAsmImm<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }
}