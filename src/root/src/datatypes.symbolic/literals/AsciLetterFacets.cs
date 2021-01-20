//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using C = AsciLetterCode;

    /// <summary>
    /// Defines attributes related to the <see cref='C'/> type
    /// </summary>
    public readonly struct AsciLetterFacets
    {
        /// <summary>
        /// The code of the first lowercase letter
        /// </summary>
        public const C MinLowerCode = C.a;

        /// <summary>
        /// The code of the last lowercase letter
        /// </summary>
        public const C MaxLowerCode = C.z;

        /// <summary>
        /// The code of the first uppercase letter
        /// </summary>
        public const C MinUpperCode = C.A;

        /// <summary>
        /// The code of the last uppercase letter
        /// </summary>
        public const C MaxUpperCode = C.Z;
    }
}