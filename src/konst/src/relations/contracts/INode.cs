//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface INode
    {
        Label Label {get;}
    }

    /// <summary>
    /// Characterizes an atomic value
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    public interface INode<T> : INode
    {
        T Content {get;}
    }

    /// <summary>
    /// Characterizes an atomic value reification
    /// </summary>
    /// <typeparam name="H">The reifying type</typeparam>
    /// <typeparam name="T">The node value type</typeparam>
    public interface INode<H,T> : INode<T>
        where H : INode<H,T>, new()
    {

    }
}