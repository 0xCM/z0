//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IChannel
    {
        void Flow();

    }

    [Free]
    public interface IChannel<S> : IChannel
    {
    }

    [Free]
    public interface IChannel<H,S> : IChannel<S>
        where H : IChannel<H,S>
    {

    }
}