//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IEdge
    {
        Label Label {get;}
    }

    [Free]
    public interface IEdge<V> : IEdge
        where V : IEquatable<V>
    {
        V Source {get;}

        V Target {get;}
    }
}