//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TypeIdentity : ITypeIdentity<TypeIdentity>
    {
        public string Identifier {get;}

        public static TypeIdentity Empty => Define(string.Empty);

        /// <summary>
        /// Defines a scalar type identity
        /// </summary>
        /// <param name="width">The scalar bit-width</param>
        [MethodImpl(Inline)]
        public static ScalarIdentity Scalar(NumericKind kind)
            => ScalarIdentity.Define(kind);

        [MethodImpl(Inline)]
        public static TypeIdentity Define(string identifier)
            => new TypeIdentity(identifier);
        
        [MethodImpl(Inline)]
        public static TypeIdentity operator +(TypeIdentity lhs, string rhs)
            => Define($"{lhs}{rhs}");

        [MethodImpl(Inline)]
        public static TypeIdentity operator +(string lhs, TypeIdentity rhs)
            => Define($"{lhs}{rhs}");

        [MethodImpl(Inline)]
        public static implicit operator string(TypeIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(TypeIdentity a, TypeIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(TypeIdentity a, TypeIdentity b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        TypeIdentity(string id)
            => Identifier = id;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Identifier);
        }

        [MethodImpl(Inline)]
        public bool Equals(TypeIdentity src)
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