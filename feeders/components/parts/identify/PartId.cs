//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
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
            => p2.Me.Equals(p1.Me);

        [MethodImpl(Inline)]
        public static bool operator !=(PartId<P> p1, PartId<P> p2)
            => !p1.Me.Equals(p2.Me);

        protected P Me => (P)this;
        
        [MethodImpl(Inline)]
        public bool Equals(P src)
            => Me.Equals(src);    
        
        public string Format() 
            => Me.Formatted;

        public override bool Equals(object src)
            => src is P a && a.Id == Id;

        public override int GetHashCode() 
            => Me.HashCode;

        public override string ToString()
            => Me.Formatted;
    }
}