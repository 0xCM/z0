//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public interface IImm
    {

    }

    public interface IImm<T> : IImm, IDataType<T>
        where T : unmanaged
    {
        T Content {get;}
    }

    public interface IImm<F,T> : IImm<T>
        where F : unmanaged, IImm<F,T>
        where T : unmanaged
    {

    }
}