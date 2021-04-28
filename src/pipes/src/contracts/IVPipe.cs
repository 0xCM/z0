//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IVPipe<W,S,T>
        where W : unmanaged, ITypeWidth
        where S : unmanaged
        where T : unmanaged
    {

    }

    public interface IVPipe128<S,T> : IVPipe<W128,S,T>
        where S : unmanaged
        where T : unmanaged
    {
        uint Flow(in SpanBlock128<S> src, in SpanBlock128<T> dst);
    }

    public interface IVPipe256<S,T> : IVPipe<W256,S,T>
        where S : unmanaged
        where T : unmanaged
    {
        uint Flow(in SpanBlock256<S> src, in SpanBlock256<T> dst);
    }
}