//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public interface IImmediate
    {

    }

    public interface IImmediate<T> : IImmediate, IDataType<T>
        where T : unmanaged
    {

    }

    public interface IImmediate<W,T> : IImmediate<T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }

    public interface IImmediate<F,W,T> : IImmediate<W,T>
        where F : unmanaged, IImmediate<F,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}