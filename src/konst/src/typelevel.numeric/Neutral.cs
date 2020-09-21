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
    public readonly struct Neutral : ISigned<Neutral>
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
    public readonly struct Neutral<T> : ISigned<Neutral<T>,Neutral,T>
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
}