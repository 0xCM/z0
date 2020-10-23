//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmMem
    {

    }

    public interface IAsmMem<T> : IAsmMem, IAsmContent<T>
        where T : unmanaged
    {

    }

    public interface IAsmMem<W,T> : IAsmMem<T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {

    }

    public interface IAsmMem<F,W,T> : IAsmMem<W,T>
        where T : unmanaged
        where F : unmanaged, IAsmMem<F,W,T>
        where W : unmanaged, ITypeWidth
    {

    }
}