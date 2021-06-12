//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IConduit
    {
        void Flow();

    }

    [Free]
    public interface IConduit<S> : IConduit
    {
    }

    [Free]
    public interface IConduit<H,S> : IConduit<S>
        where H : IConduit<H,S>
    {

    }
}