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
    /// Defines the type signature for a node-homogenous link
    /// </summary>
    public readonly struct LinkType<T>
    {
        public Type Source {get;}

        public Type Target {get;}

        [MethodImpl(Inline)]
        internal LinkType(Type src, Type dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public bool Equals(LinkType src)
            => DataFlows.eq(this, src);

        [MethodImpl(Inline)]
        public string Format()
            => DataFlows.format(this);

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => (uint)typeof(LinkType<T>).GetHashCode();
        }

        public ulong Hash64
        {
            [MethodImpl(Inline)]
            get => hash(Source,Target);
        }

        public override int GetHashCode()
            => (int)Hashed;

        public static implicit operator Type(LinkType<T> src)
            => typeof(LinkType<T>);

        [MethodImpl(Inline)]
        public static implicit operator LinkType(LinkType<T> src)
            => new LinkType(src.Source, src.Target);

        public static Type Type
            => typeof(LinkType<T>);
    }
}