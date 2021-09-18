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
}