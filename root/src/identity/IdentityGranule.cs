//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static RootShare;

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
             => IdentityEquals(this, src);

        public override string ToString()
            => Identifier;
 
        public override int GetHashCode()
            => IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityEquals(this, obj);

        public int CompareTo(IIdentity other)
            => IdentityCompare(this, other);

    }

}
