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

    public readonly struct ScalarIdentity  : ITypeIdentity<ScalarIdentity>
    {
        [MethodImpl(Inline)]
        public static ScalarIdentity Define(FixedWidth width, NumericIndicator indicator)
            => new ScalarIdentity(width, indicator);

        [MethodImpl(Inline)]
        public static implicit operator string(ScalarIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(ScalarIdentity a, ScalarIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ScalarIdentity a, ScalarIdentity b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        ScalarIdentity(FixedWidth width, NumericIndicator indicator)
        {
            this.Width = width;
            this.Indicator = indicator;
        }

        public readonly FixedWidth Width;
     
        public readonly NumericIndicator Indicator;

        public string Identifier
            => $"{Width.Format()}{Indicator.Format()}";

        public NumericKind NumericKind
            => Width.ToNumericKind(Indicator);

        [MethodImpl(Inline)]
        public bool Equals(ScalarIdentity src)
             => IdentityEquals(this, src);

        public override string ToString()
            => Identifier;
 
        public override int GetHashCode()
            => IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityEquals(this, obj);
    }
}