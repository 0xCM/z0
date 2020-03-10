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

        public static TypeIdentity IdentifyNumericClosure(string root, Type arg)
        {
            var kind = arg.NumericKind();
            var indicator = kind.Indicator().ToChar();
            var width = kind.Width();
            return TypeIdentity.Define($"{root}{width}{indicator}");
        }

        /// <summary>
        /// Produces an identifier of the form {bitsize[T]}{u | i | f} for a numeric type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static TypeIdentity numeric<T>(T t = default)
            where T : unmanaged
                => TypeIdentity.Define(typeof(T).NumericKind().Format());

        /// <summary>
        /// Produces the formatted identifier of the declaring assembly
        /// </summary>
        /// <param name="host">The source type</param>
        [MethodImpl(Inline)]   
        public static string owner(Type host)
            => host.Assembly.Id().Format();

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
            get => text.empty(Identifier);
        }

        [MethodImpl(Inline)]
        public bool Equals(TypeIdentity src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(TypeIdentity src)
            => compare(this, src); 
        public string Format()
            => IdentityShare.format(this);

        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => Format();
    }
}