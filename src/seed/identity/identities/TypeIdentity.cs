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
        /// <summary>
        /// Defines a scalar type identity
        /// </summary>
        /// <param name="width">The scalar bit-width</param>
        [MethodImpl(Inline)]
        public static NumericIdentity numeric(NumericKind nk)
            => NumericIdentity.Define(nk);

        /// <summary>
        /// Produces an identifier of the form {bitsize[T]}{u | i | f} for a numeric type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static TypeIdentity numeric<T>(T t = default)
            where T : unmanaged
                => TypeIdentity.Define(typeof(T).NumericKind().Format());

        public static TypeIdentity numeric(string prefix, Type arg)
        {
            var kind = arg.NumericKind();
            var indicator = kind.Indicator().ToChar();
            var width = kind.Width();
            return TypeIdentity.Define($"{prefix}{width}{indicator}");
        }

        public string IdentityText {get;}

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
            => src.IdentityText;

        [MethodImpl(Inline)]
        public static bool operator==(TypeIdentity a, TypeIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(TypeIdentity a, TypeIdentity b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        TypeIdentity(string id)
            => IdentityText = id;
        
        IIdentifiedType<TypeIdentity> Identified => this;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(IdentityText);
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