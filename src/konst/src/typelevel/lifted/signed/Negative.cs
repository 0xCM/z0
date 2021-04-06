//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Promotes the literal classifier <See cref="SignKind.Signed"/> to a type
    /// </summary>
    public readonly struct Negative : ISignedClass<Negative>
    {
        /// <summary>
        /// Reveals the represented literal
        /// </summary>
        public SignKind Kind
            => SignKind.Signed;
    }

}