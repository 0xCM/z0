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

    public readonly struct ScalarIdentity  : ITypeIdentity<ScalarIdentity>
    {
        public string Identifier {get;}            

        public NumericKind NumericKind {get;}           

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

        [MethodImpl(Inline)]
        public TypeIdentity AsTypeIdentity()
            => TypeIdentity.Define(Identifier);

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Identifier);
        }

        [MethodImpl(Inline)]
        public bool Equals(ScalarIdentity src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(ScalarIdentity other)
            => compare(this, other);
 
        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => Identifier;
    }
}