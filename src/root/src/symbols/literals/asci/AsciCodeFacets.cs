//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using C = AsciCharCode;

    /// <summary>
    /// Defines <see cref='AsciCharCode'/> attributges
    /// </summary>
    public readonly struct AsciCodeFacets
    {
        /// <summary>
        /// The numeric value of the firt asci code
        /// </summary>
        public const byte MinCodeValue = 0;

        /// <summary>
        /// The numeric value of the last asci code
        /// </summary>
        public const byte MaxCodeValue = 127;

        /// <summary>
        /// The first asci code
        /// </summary>
        public const C MinCode = MinCodeValue;

        /// <summary>
        /// The last asci code
        /// </summary>
        public const C MaxCode = (C)MaxCodeValue;

        /// <summary>
        /// The first digit code
        /// </summary>
        public const C MinDigitCode = (C)C.d0;

        /// <summary>
        /// The last declared code
        /// </summary>
        public const C MaxDigitCode = (C)C.d9;

        /// <summary>
        /// The count of defined asci digits
        /// </summary>
        public const byte DigitCount = MaxDigitCode - MinDigitCode + 1;

        /// <summary>
        /// The code of the first lowercase letter
        /// </summary>
        public const C MinLowerCode = C.a;

        /// <summary>
        /// The code of the last lowercase letter
        /// </summary>
        public const C MaxLowerCode = C.z;

        /// <summary>
        /// The count of lowercase letters
        /// </summary>
        public const byte LowerCount = MaxLowerCode - MinLowerCode + 1;

        /// <summary>
        /// The count of uppercase letters
        /// </summary>
        public const byte UpperCount = MaxUpperCode - MinUpperCode + 1;

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