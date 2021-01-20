//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using C = AsciDigitCode;

    /// <summary>
    /// Defines attributes related to the <see cref='C'/> type
    /// </summary>
    public readonly struct AsciDigitFacets
    {
        /// <summary>
        /// The first digit code
        /// </summary>
        public const C MinCode = C.d0;

        /// <summary>
        /// The last declared code
        /// </summary>
        public const C MaxCode = C.d9;

        /// <summary>
        /// The count of defined asci digits
        /// </summary>
        public const byte Count = MaxCode - MinCode + 1;
    }
}