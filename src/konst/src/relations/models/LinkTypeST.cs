//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Graphs;

    public readonly struct LinkType<S,T>
    {
        public Type Source {get;}

        public Type Target {get;}

        [MethodImpl(Inline)]
        public LinkType(Type src, Type dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public bool Equals(LinkType src)
            => api.eq(this, src);

        [MethodImpl(Inline)]
        public string Format()
            => Links.format(this);

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => (uint)typeof(LinkType<S,T>).GetHashCode();
        }

        public ulong Hash64
        {
            [MethodImpl(Inline)]
            get => alg.hash.combine(Source,Target);
        }

        public override int GetHashCode()
            => (int)Hashed;

        [MethodImpl(Inline)]
        public static implicit operator Type(LinkType<S,T> src)
            => typeof(LinkType<S,T>);

        [MethodImpl(Inline)]
        public static implicit operator LinkType(LinkType<S,T> src)
            => new LinkType(src.Source, src.Target);
    }
}