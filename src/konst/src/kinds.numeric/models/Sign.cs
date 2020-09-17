//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Promotes the literal classifier <See cref="SignKind.Neutral"/> to a type
    /// </summary>
    public readonly struct Neutral : ISign<Neutral>
    {
        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind
            => SignKind.Neutral;
    }

    /// <summary>
    /// Defines a T-parametric <See cref="SignKind.Negative"/> literal classifier promotion
    /// </summary>
    public readonly struct Neutral<T> : ISign<Neutral<T>,Neutral,T>
    {
        /// <summary>
        /// Reveals the singleton instance of the nonparametric classifier
        /// </summary>
        public Neutral SignType
            => default;

        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind
            => SignType.Kind;
    }

    /// <summary>
    /// Promotes the literal classifier <See cref="SignKind.Negative"/> to a type
    /// </summary>
    public readonly struct Negative : ISign<Negative>
    {
        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind
            => SignKind.Negative;
    }

    /// <summary>
    /// Defines a T-parametric <See cref="SignKind.Negative"/> literal classifier promotion
    /// </summary>
    public readonly struct Negative<T> : ISign<Negative<T>,Negative,T>
    {
        /// <summary>
        /// Reveals the singleton instance of the nonparametric classifier
        /// </summary>
        public Negative SignType
            => default;

        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind
            => SignType.Kind;
    }

    /// <summary>
    /// Promotes the literal classifier <See cref="SignKind.Positive"/> to a type
    /// </summary>
    public readonly struct Positive : ISign<Positive>
    {
        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind
            => SignKind.Positive;
    }

    /// <summary>
    /// Defines a T-parametric <See cref="SignKind.Negative"/> literal classifier promotion
    /// </summary>
    public readonly struct Positive<T> : ISign<Positive<T>,Positive,T>
    {
        /// <summary>
        /// Reveals the singleton instance of the nonparametric classifier
        /// </summary>
        public Positive SignType
            => default;

        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind
            => SignType.Kind;
    }


    /// <summary>
    /// Captures an S-parametric sign classifier via parametricity
    /// </summary>
    public readonly struct Sign<S> : ISign<Sign<S>,S>
        where S : unmanaged, ISign<S>
    {
        /// <summary>
        /// Reveals the type-level classifier
        /// </summary>
        public static S SignType
            => default;

        /// <summary>
        /// Reveals the literal represented by the type-level classifier
        /// </summary>
        /// <remarks>
        /// The implementation is redundant with that provided by the default interface implementation;
        /// however, accessing that implementation requires a boxing conversion along with polymorphic
        /// dispatch
        /// </remarks>
        public SignKind Kind
            => SignType.Kind;
    }


    /// <summary>
    /// Captures an S/T-parametric sign classifier via parametricity
    /// </summary>
    public readonly struct Sign<S,T> : ISign<Sign<S,T>,S,T>
        where S : unmanaged, ISign<S>
    {

    }

    public readonly struct TypeSign : ITypeSign<TypeSign>
    {
        public TypeSignKind Sign {get;}

        [MethodImpl(Inline)]
        public static implicit operator TypeSign(TypeSignKind src)
            => new TypeSign(src);

        [MethodImpl(Inline)]
        public static implicit operator TypeSignKind(TypeSign src)
            => src.Sign;

        [MethodImpl(Inline)]
        public TypeSign(TypeSignKind kind)
        {
            Sign = kind;
        }
    }
}