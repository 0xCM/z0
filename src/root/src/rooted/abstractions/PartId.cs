//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    public abstract class PartId<P> : IPartId<P>
        where P : PartId<P>, IPartId<P>,  new()
    {
        public PartId Id {get;}

        protected PartId(PartId id)
            => Id = id;

        [MethodImpl(Inline)]
        public static implicit operator PartId(PartId<P> src)
            => src.Id;

        [MethodImpl(Inline)]
        public static bool operator ==(PartId<P> p1, PartId<P> p2)
            => p1.Id == p2.Id;

        [MethodImpl(Inline)]
        public static bool operator !=(PartId<P> p1, PartId<P> p2)
            => p1.Id != p2.Id;

        [MethodImpl(Inline)]
        public bool Equals(P src)
            => Id == src.Id;

        public override bool Equals(object src)
            => src is P x && Equals(x);

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => hash(Id);
        }

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public string Format()
            => root.format(Id);

        public override string ToString()
            => Format();
    }
}