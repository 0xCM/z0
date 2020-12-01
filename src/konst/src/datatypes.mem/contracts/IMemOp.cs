//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMemOp
    {

    }

    public interface IMemOp<T> : IMemOp, IDataType<T>
        where T : unmanaged
    {

    }

    public interface IMemOp<W,T> : IMemOp<T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {

    }

    public interface IMemOp<F,W,T> : IMemOp<W,T>
        where T : unmanaged
        where F : unmanaged, IMemOp<F,W,T>
        where W : unmanaged, ITypeWidth
    {

    }
}