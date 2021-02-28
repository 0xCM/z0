//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface ISyntaxNode
    {
        Identifier NodeName {get;}

        SyntaxNodeKey NodeKey {get;}
    }

    public interface ISyntaxNode<K> : ISyntaxNode
        where K : unmanaged
    {
        K NodeKind {get;}

        Identifier ISyntaxNode.NodeName
            => NodeKind.ToString();
    }

    public interface ISyntaxNode<T,K> : ISyntaxNode<K>, IEquatable<T>
        where T : ISyntaxNode<T,K>, new()
        where K : unmanaged

    {
        bool IEquatable<T>.Equals(T src)
            => NodeKey.Equals(src.NodeKey);
    }
}