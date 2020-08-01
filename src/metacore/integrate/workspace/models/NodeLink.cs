//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using N = SystemNode;

    /// <summary>
    /// Defines a directed edge between two nodes
    /// </summary>
    public readonly struct NodeLink : ILink<N>
    {
        public N Source { get; }        

        public N Target { get; }

        [MethodImpl(Inline)]
        public NodeLink(N src, N dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator NodeChain(NodeLink link)
            => new NodeChain(stream(link));

        [MethodImpl(Inline)]
        public static implicit operator Link<N,N>(NodeLink link)
            => new Link<N,N>(link.Source, link.Target);

        [MethodImpl(Inline)]
        public static implicit operator NodeLink(Link<N> link)
            => new NodeLink(link.Source, link.Target);

        [MethodImpl(Inline)]
        public static implicit operator NodeLink(Link<N,N> link)
            => new NodeLink(link.Source, link.Target);

        public LinkIdentifier Name
            => new LinkIdentifier<N>(Source,Target);

        public NodeLink Reverse()
            => new NodeLink(Target, Source);

        public bool LinkedToSelf
            => Source == Target;

        public override string ToString()
            => Name;
    }
}