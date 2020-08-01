//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using System.Linq;
    using System.Collections.Generic;
    using System.Collections;

    using static Konst;
    using static z;

    using N = SystemNode;

    /// <summary>
    /// Encapsulates an ordered collection of <see cref="NodeLink"/> values
    /// such the target of a link at position n-1 is the source of the link at position n.
    /// </summary>
    public struct NodeChain :  INodeChain
    {
        readonly NodeLink[] Components;

        public NodeChain(IEnumerable<NodeLink> links)
        {
            Components = links.Array();
        }

        public N Source
            => Components.FirstOrDefault().Source;

        public N Target
            => Components.LastOrDefault().Target;

        LinkIdentifier ILink.Name
            => Source.LinkTo(Target).Name;


        N ILink<N>.Source =>
            Components.FirstOrDefault().Source;

        N ILink<N>.Target =>
            Components.LastOrDefault().Target;

        int IReadOnlyCollection<Link<N>>.Count
            => Components.Length;

        Link<N> IReadOnlyList<Link<N>>.this[int index]
        {
            get
            {
                var x = Components[index];
                return new Link<N>(x.Source, x.Target);
            }
        }
    
        public override string ToString()
            => string.Join("=>", Components.ToArray());

        IEnumerator IEnumerable.GetEnumerator()
            => Components.GetEnumerator();

        IEnumerator<Link<N>> IEnumerable<Link<N>>.GetEnumerator()
            => (from x in Components select new Link<N>(x.Source, x.Target)).GetEnumerator();
    }
}