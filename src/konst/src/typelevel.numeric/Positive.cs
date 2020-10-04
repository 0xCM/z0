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
    /// Promotes the literal classifier <See cref="SignKind.Unsigned"/> to a type
    /// </summary>
    public readonly struct Positive : ISigned<Positive>
    {
        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind
            => SignKind.Unsigned;
    }

    /// <summary>
    /// Defines a T-parametric <See cref="SignKind.Signed"/> literal classifier promotion
    /// </summary>
    public readonly struct Positive<T> : ISigned<Positive<T>,Positive,T>
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
}