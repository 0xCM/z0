//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ScalarIdentity  : ITypeIdentity<ScalarIdentity>
    {
        [MethodImpl(Inline)]
        public static ScalarIdentity Define(NumericKind kind)
            => new ScalarIdentity(kind);

        [MethodImpl(Inline)]
        public static implicit operator string(ScalarIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static implicit operator TypeIdentity(ScalarIdentity src)
            => src.AsTypeIdentity();

        [MethodImpl(Inline)]
        public static bool operator==(ScalarIdentity a, ScalarIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ScalarIdentity a, ScalarIdentity b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        ScalarIdentity(NumericKind kind)
        {
            this.NumericKind = kind;
            this.Identifier = $"{kind.WidthKind().Format()}{NumericKind.Indicator().Format()}";
        }
     
        public string Identifier {get;}            

        public NumericKind NumericKind {get;}           


        [MethodImpl(Inline)]
        public TypeIdentity AsTypeIdentity()
            => TypeIdentity.Define(Identifier);

        [MethodImpl(Inline)]
        public bool Equals(ScalarIdentity src)
            => IdentityEquals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(IIdentity other)
            => IdentityCompare(this, other);

        public override string ToString()
            => Identifier;
 
        public override int GetHashCode()
            => IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityEquals(this, obj);
    }
}