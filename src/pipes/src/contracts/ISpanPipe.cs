//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ISpanPipe<S,T> : IPipe, ISpanMap<S,T>
    {


    }

    [Free]
    public interface ISpanPipe<W,S,T> : IPipe
        where W : unmanaged, ITypeWidth
        where S : unmanaged
        where T : unmanaged
    {

    }

    [Free]
    public interface ISpanPipe128<S,T> : ISpanPipe<W128,S,T>
        where S : unmanaged
        where T : unmanaged
    {
        uint Flow(in SpanBlock128<S> src, in SpanBlock128<T> dst);
    }

    [Free]
    public interface ISpanPipe256<S,T> : ISpanPipe<W256,S,T>
        where S : unmanaged
        where T : unmanaged
    {
        uint Flow(in SpanBlock256<S> src, in SpanBlock256<T> dst);
    }
}