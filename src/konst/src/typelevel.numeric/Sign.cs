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
    /// Captures an S-parametric sign classifier via parametricity
    /// </summary>
    public readonly struct Sign<S> : ISigned<Sign<S>,S>
        where S : unmanaged, ISigned<S>
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
    public readonly struct Sign<S,T> : ISigned<Sign<S,T>,S,T>
        where S : unmanaged, ISigned<S>
    {

    }
}