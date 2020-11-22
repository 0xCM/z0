//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataPipe<T> : IPipe<T>, IDataSink<T>, IDataSource<T>
        where T : struct
    {

    }

    [Free]
    public interface IDataPipe<S,T> : IPipe<S,T>, IDataSink<S>, IDataSource<T>
        where S : struct
        where T : struct
    {

    }
}