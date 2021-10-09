//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IVertex
    {

    }

    [Free]
    public interface IVertex<V> : IVertex
        where V : IEquatable<V>
    {
        V Identity {get;}
    }
}