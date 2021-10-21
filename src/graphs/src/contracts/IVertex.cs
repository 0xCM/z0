//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Graphs
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IVertex : IExpr
    {
        Label Name {get;}
    }

    [Free]
    public interface IVertex<V> : IVertex
    {
        V Value {get;}
    }
}