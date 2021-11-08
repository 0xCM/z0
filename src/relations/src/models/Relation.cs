//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IRelation
    {
        Label Source {get;}

        Label Target {get;}
    }

    public interface IRelation<K> : IRelation
        where K : unmanaged
    {

    }

    [StructLayout(LayoutKind.Sequential, Pack =1)]
    public readonly struct Relation<K>
        where K : unmanaged
    {
        public K Kind {get;}

        public Label Source {get;}

        public Label Target {get;}

        [MethodImpl(Inline)]
        public Relation(K kind, Label src, Label dst)
        {
            Kind = kind;
            Source = src;
            Target = dst;
        }

        public string Format()
            => string.Format("{0}:{1} -> {2}", Kind, Source, Target);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(Relation<K> src)
            => core.bw64(Kind) == core.bw64(src.Kind)
            && Source == src.Source
            && Target == src.Target;

    }

    [StructLayout(LayoutKind.Sequential, Pack =1)]
    public readonly struct Relation
    {
        public Label Source {get;}

        public Label Target {get;}

        [MethodImpl(Inline)]
        public Relation(Label src, Label dst)
        {
            Source = src;
            Target = dst;
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => alg.hash.combine(Source.Hash, Target.Hash);
        }

        public string Format()
            => string.Format("{0} -> {1}", Source, Target);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(Relation src)
            => Source == src.Source && Target == src.Target;

        public override int GetHashCode()
            => (int)Hash;
    }
}