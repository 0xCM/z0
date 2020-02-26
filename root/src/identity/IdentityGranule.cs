//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct IdentityGranule : IIdentity<IdentityGranule>
    {                
        public string Identifier {get;}

        [MethodImpl(Inline)]
        public static IdentityGranule Define(string atomic)
            => new IdentityGranule(atomic);

        [MethodImpl(Inline)]
        public static implicit operator string(IdentityGranule src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(IdentityGranule a, IdentityGranule b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(IdentityGranule a, IdentityGranule b)
            => !a.Equals(b);

        IdentityGranule(string atomic)
        {
            this.Identifier = atomic;
        }

        [MethodImpl(Inline)]
        public bool Equals(IdentityGranule src)
            => IdentityCommons.IdentityEquals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(IIdentity other)
            => IdentityCommons.IdentityCompare(this, other);
 
        public override int GetHashCode()
            => IdentityCommons.IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityCommons.IdentityEquals(this, obj);

        public override string ToString()
            => Identifier;


    }

}
