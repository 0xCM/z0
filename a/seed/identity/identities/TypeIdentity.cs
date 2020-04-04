//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct TypeIdentity : IIdentifiedType<TypeIdentity>
    {
        public string Identifier {get;}

        public static TypeIdentity Empty => Define(string.Empty);

        [MethodImpl(Inline)]
        public static TypeIdentity Define(string id)
            => new TypeIdentity(id);

        public Func<string,TypeIdentity> Factory => Define;

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
        
        IIdentifiedType<TypeIdentity> Identified => this;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Identifier);
        }
        
        public override int GetHashCode()
            => Identified.HashCode;

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();        

        [MethodImpl(Inline)]
        public Option<TypeIdentity> ToOption()
            => IsEmpty ? Option.none<TypeIdentity>() : Option.some(this);
    }
}