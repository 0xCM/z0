//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Characterizes a node produder
    /// </summary>
    /// <typeparam name="H">The type that reifies the node value</typeparam>
    /// <typeparam name="T">The node's value type</typeparam>
    public interface INodeFactory<H,T>
        where H : INode<H,T>, new()
    {
        H Create(T content, bool terminal, bool empty);
    }
}