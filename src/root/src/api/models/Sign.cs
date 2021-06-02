//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static bool IsLeft(this Sign src)
            => src.Kind == PolarityKind.Left;

        [MethodImpl(Inline)]
        public static bool IsRight(this Sign src)
            => src.Kind == PolarityKind.Right;
    }

    public readonly struct Sign
    {
        public PolarityKind Kind {get;}

        [MethodImpl(Inline)]
        public Sign(PolarityKind kind)
            => Kind = kind;

        [MethodImpl(Inline)]
        public static implicit operator Sign(PolarityKind src)
            => new Sign(src);

        [MethodImpl(Inline)]
        public static implicit operator Sign(sbyte src)
            => new Sign(src < 0 ? PolarityKind.Left : PolarityKind.Right);

        [MethodImpl(Inline)]
        public static implicit operator Sign(short src)
            => new Sign(src < 0 ? PolarityKind.Left : PolarityKind.Right);

        [MethodImpl(Inline)]
        public static implicit operator Sign(int src)
            => new Sign(src < 0 ? PolarityKind.Left : PolarityKind.Right);

        [MethodImpl(Inline)]
        public static implicit operator Sign(long src)
            => new Sign(src < 0 ? PolarityKind.Left : PolarityKind.Right);

        [MethodImpl(Inline)]
        public static implicit operator PolarityKind(Sign src)
            => src.Kind;
    }

    /// <summary>
    /// Captures an S-parametric sign classifier via parametricity
    /// </summary>
    public readonly struct Sign<S> : ISignedClass<Sign<S>,S>
        where S : unmanaged, ISignedClass<S>
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
        public PolarityKind Kind
            => SignType.Kind;
    }

    /// <summary>
    /// Captures an S/T-parametric sign classifier via parametricity
    /// </summary>
    public readonly struct Sign<S,T> : ISignedClass<Sign<S,T>,S,T>
        where S : unmanaged, ISignedClass<S>
    {

    }
}