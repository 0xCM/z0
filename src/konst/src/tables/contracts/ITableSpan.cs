//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITableSpan<T> : ISpanBuffer<T>
        where T : struct
    {
    }

    [Free]
    public interface ITableSpan<H,T> : ITableSpan<T>, ISpanBuffer<H,T>
        where H : struct, ITableSpan<H,T>
        where T : struct
    {

    }

    [Free]
    public interface ISpanBuffer<T> : IIndex<T>, INullity, IMeasured
    {

    }

    [Free]
    public interface ISpanBuffer<H,T> : ISpanBuffer<T>
        where H : struct, ISpanBuffer<H,T>
    {
        H Refresh(T[] src);
    }
}