//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using static Scalars;

    [LiteralProvider]
    public readonly struct Vectors
    {
        /// <summary>
        /// A 1-dimensional vector over signed 8-bit integers
        /// </summary>
        public const string v1xi8 = "v1x" + i8;

        /// <summary>
        /// A 2-dimensional vector over signed 8-bit integers
        /// </summary>
        public const string v2xi8 = "v2x" + i8;

        /// <summary>
        /// A 3-dimensional vector over signed 8-bit integers
        /// </summary>
        public const string v3xi8 = "v3x" + i8;

        /// <summary>
        /// An N-dimensional vector over signed 8-bit integers
        /// </summary>
        public const string vNxi8 = "v{0}x" + i8;

        /// <summary>
        /// A 1-dimensional vector over signed 8-bit integers
        /// </summary>
        public const string v1xu8 = "v1x" + i8;

        /// <summary>
        /// A 2-dimensional vector over unsigned 8-bit integers
        /// </summary>
        public const string v2xu8 = "v2x" + u8;

        /// <summary>
        /// A 3-dimensional vector over unsigned 8-bit integers
        /// </summary>
        public const string v3xu8 = "v3x" + u8;

        /// <summary>
        /// An N-dimensional vector over unsigned 8-bit integers
        /// </summary>
        public const string vNxu8 = "v{0}x" + u8;

        /// <summary>
        /// An N-dimensional vector over signed W-bit integers
        /// </summary>
        public const string vNxuW = "v{N}xu{W}";

        /// <summary>
        /// An N-dimensional vector over unsigned W-bit integers
        /// </summary>
        public const string vNxiW = "v{N}xi{W}";
    }
}