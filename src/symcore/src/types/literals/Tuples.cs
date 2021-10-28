//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using static Naturals;
    using static Composers;
    using static Scalars;

    [LiteralProvider]
    public readonly struct Tuples
    {
        /// <summary>
        /// Unsigned 8-bit scalar 1-tuples
        /// </summary>
        public const string u8x1 = u8 + x + N1;

        /// <summary>
        /// Unsigned 8-bit scalar 2-tuples
        /// </summary>
        public const string u8x2 = u8 + x + N2;

        /// <summary>
        /// Unsigned 8-bit scalar 3-tuples
        /// </summary>
        public const string u8x3 = u8 + x + N3;

        /// <summary>
        /// Signed 8-bit N-parametric N-tuples
        /// </summary>
        public const string u8xN = u8 + x + N;

        /// <summary>
        /// Signed 8-bit scalar 1-tuples
        /// </summary>
        public const string i8x1 = i8 + x + N1;

        /// <summary>
        /// Signed 8-bit scalar 2-tuples
        /// </summary>
        public const string i8x2 = i8 + x + N2;

        /// <summary>
        /// Signed 8-bit scalar 3-tuples
        /// </summary>
        public const string i8x3 = i8 + x + N3;

        /// <summary>
        /// Signed 8-bit N-parametric N-tuples
        /// </summary>
        public const string i8xN = i8 + x + N;
    }
}