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
    /// Promotes the literal classifier <See cref="SignKind.Signed"/> to a type
    /// </summary>
    public readonly struct Negative : ISigned<Negative>
    {
        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind
            => SignKind.Signed;
    }

    /// <summary>
    /// Defines a T-parametric <See cref="SignKind.Signed"/> literal classifier promotion
    /// </summary>
    public readonly struct Negative<T> : ISigned<Negative<T>,Negative,T>
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
}