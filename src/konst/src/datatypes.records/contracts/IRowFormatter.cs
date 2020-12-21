//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRowFormatter<S,T>
        where S : struct
    {
        T Format(S src);

    }

    [Free]
    public interface IRowFormatter<S> : IRowFormatter<S,string>
        where S : struct
    {

    }
}