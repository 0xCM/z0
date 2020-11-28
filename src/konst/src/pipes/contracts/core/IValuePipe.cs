//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IValuePipe<T> : IPipe<T>, IValueSink<T>, IValueSource<T>
        where T : struct
    {

    }

    [Free]
    public interface IValuePipe<S,T> : IPipe<S,T>, IValueSink<S>, IValueSource<T>
        where S : struct
        where T : struct
    {

    }
}