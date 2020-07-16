//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct LinkIdentifier<S,T> : IIdentified<Paired<S,T>>
    {
        public Paired<S,T> Id {get;}

        public string Identifier {get;}
        
        public static implicit operator LinkIdentifier(LinkIdentifier<S,T> src)
            => src.Nongeneric;
        
        public static implicit operator LinkIdentifier<S,T>((S src, T dst) link)
            => new LinkIdentifier<S,T>(link.src, link.dst);
        
        [MethodImpl(Inline)]
        public LinkIdentifier(S src, T dst)
        {
            Id = (src,dst);
            Identifier = text.concat(src, " -> ", dst);
        }

        public LinkIdentifier Nongeneric
        {
            get => new LinkIdentifier(Identifier);
        }
        
        public string Format()
            => Identifier;


        public override string ToString()
            => Identifier;
    }
}