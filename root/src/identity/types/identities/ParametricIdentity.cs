//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static IdentityShare;

    public readonly struct ParametricIdentity  : IParametricIdentity
    {
        public string Identifier {get;}            

        [MethodImpl(Inline)]
        public static implicit operator string(ParametricIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static implicit operator TypeIdentity(ParametricIdentity src)
            => src.AsTypeIdentity();

        [MethodImpl(Inline)]
        public static bool operator==(ParametricIdentity a, ParametricIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ParametricIdentity a, ParametricIdentity b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        ParametricIdentity(IParametric parametric)
        {
            this.Identifier = text.blank;
        }

        [MethodImpl(Inline)]
        public TypeIdentity AsTypeIdentity()
            => TypeIdentity.Define(Identifier);

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Identifier);
        }

        [MethodImpl(Inline)]
        public bool Equals(ParametricIdentity src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(ParametricIdentity other)
            => compare(this, other);
 
        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => Identifier;
    }
}