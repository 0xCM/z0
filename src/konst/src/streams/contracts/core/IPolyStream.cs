//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IPolyStream<T> : IValueSource<T>, IValueStream<T>
        where T : struct
    {

    }

    [Free]
    public interface IPolyStream : IPolySourced
    {
        IPolyStream<T> Stream<T>()
            where T : struct;
    }
}