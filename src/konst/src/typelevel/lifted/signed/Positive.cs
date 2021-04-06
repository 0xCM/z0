//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Promotes the literal classifier <See cref="SignKind.Unsigned"/> to a type
    /// </summary>
    public readonly struct Positive : ISignedClass<Positive>
    {
        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind
            => SignKind.Unsigned;
    }
}