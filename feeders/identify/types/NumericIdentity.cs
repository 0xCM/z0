//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Identify;
    using static IdentityShare;

    public readonly partial struct NumericIdentity  : INumericIdentity
    {
        public string Identifier {get;}            

        public NumericKind NumericKind {get;}           

        [MethodImpl(Inline)]
        public static NumericIdentity Define(NumericKind kind)
            => new NumericIdentity(kind);

        [MethodImpl(Inline)]
        public static implicit operator string(NumericIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static implicit operator TypeIdentity(NumericIdentity src)
            => src.AsTypeIdentity();

        [MethodImpl(Inline)]
        public static bool operator==(NumericIdentity a, NumericIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(NumericIdentity a, NumericIdentity b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        NumericIdentity(NumericKind kind)
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
        public bool Equals(NumericIdentity src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(NumericIdentity other)
            => compare(this, other);
 
        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => Identifier;
    }
}