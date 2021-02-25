//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct TypeIdentity : IIdentifiedType<TypeIdentity>
    {
        public string Identifier {get;}

        /// <summary>
        /// Defines a scalar type identity
        /// </summary>
        /// <param name="width">The scalar bit-width</param>
        [MethodImpl(Inline)]
        public static NumericIdentity numeric(NumericKind nk)
            => NumericIdentity.define(nk);

        /// <summary>
        /// Produces an identifier of the form {bitsize[T]}{u | i | f} for a numeric type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static TypeIdentity numeric<T>(T t = default)
            where T : unmanaged
                => define(typeof(T).NumericKind().Format());

        public static TypeIdentity numeric(string prefix, Type arg)
        {
            var kind = arg.NumericKind();
            var indicator = kind.Indicator().ToChar();
            var width = kind.Width();
            return TypeIdentity.define($"{prefix}{width}{indicator}");
        }

        [MethodImpl(Inline)]
        public static TypeIdentity define(string id)
            => new TypeIdentity(id);


        [MethodImpl(Inline)]
        public TypeIdentity(string id)
            => Identifier = id;

        IIdentifiedType<TypeIdentity> Identified => this;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Identifier);
        }

        public override int GetHashCode()
            => (int)alg.hash.calc(Identifier);

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();

        [MethodImpl(Inline)]
        public Option<TypeIdentity> ToOption()
            => IsEmpty ? root.none<TypeIdentity>() : root.some(this);

        [MethodImpl(Inline)]
        public static TypeIdentity operator +(TypeIdentity lhs, string rhs)
            => define($"{lhs}{rhs}");

        [MethodImpl(Inline)]
        public static TypeIdentity operator +(string lhs, TypeIdentity rhs)
            => define($"{lhs}{rhs}");

        [MethodImpl(Inline)]
        public static implicit operator string(TypeIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(TypeIdentity a, TypeIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(TypeIdentity a, TypeIdentity b)
            => !a.Equals(b);

        public static TypeIdentity Empty
            => define(EmptyString);
    }
}