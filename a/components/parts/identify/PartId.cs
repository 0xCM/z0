//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    public abstract class PartId<P> : IPartId<P>
        where P : PartId<P>, IPartId<P>,  new()
    {
        public static P Part => new P();        

        public abstract PartId Id {get;}

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
        
        public string Format() 
            => Id.Format();

        public override bool Equals(object src)
            => src is P a && a.Id == Id;

        public override int GetHashCode() 
            => Id.GetHashCode();

        public override string ToString()
            => Format();
    }
}