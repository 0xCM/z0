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
    using static IdentityOps;

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

        [MethodImpl(Inline)]
        IdentityGranule(string atomic)
        {
            this.Identifier = atomic;
        }

        [MethodImpl(Inline)]
        public bool Equals(IdentityGranule src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(IdentityGranule other)
            => compare(this, other);

        public string Format()
            => format(this);

        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => Format();
    }
}
