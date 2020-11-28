//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public interface IImmValue
    {

    }

    public interface IImmValue<T> : IImmValue, IDataType<T>
        where T : unmanaged
    {

    }

    public interface IImmValue<W,T> : IImmValue<T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }

    public interface IImmValue<F,W,T> : IImmValue<W,T>
        where F : unmanaged, IImmValue<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }
}