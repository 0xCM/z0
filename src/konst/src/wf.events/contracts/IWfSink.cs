//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfSink : ISink
    {

    }

    [Free]
    public interface IWfSink<T> : IDataSink<T>
        where T : struct
    {

    }

    [Free]
    public interface IWfSink<H,T> : ISink, IDataSink<T>
        where T : struct
        where H : struct, IWfSink<H,T>
    {

    }
}