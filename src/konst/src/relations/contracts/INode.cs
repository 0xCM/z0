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

    public interface INode
    {
        /// <summary>
        /// Specifies whether the node covers nonempty content
        /// </summary>
        bool IsNonEmpty {get;}

        /// <summary>
        /// Specifies whether the node covers nempty content
        /// </summary>
        bool IsEmpty => !IsNonEmpty;
    }

    /// <summary>
    /// Chracterizes an atomic value
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    public interface INode<T> : INode
    {
        /// <summary>
        /// The defining content
        /// </summary>
        T Content {get;}
    }

    /// <summary>
    /// Characterizes an atomic value reification
    /// </summary>
    /// <typeparam name="H">The reifying type</typeparam>
    /// <typeparam name="T">The node value type</typeparam>
    public interface INode<H,T> : INode<T>, INodeFactory<H,T>
        where H : INode<H,T>, new()
    {

    }
}