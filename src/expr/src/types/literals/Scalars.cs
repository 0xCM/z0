//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using static Naturals;
    using static Composers;

    [LiteralProvider]
    public readonly struct Scalars
    {
        /// <summary>
        /// An unsigned bit (An abstract type)
        /// </summary>
        public const string u1 = N0;

        /// <summary>
        /// A signed bit (An abstract type)
        /// </summary>
        public const string i1 = N1;

        /// <summary>
        /// A quantity of bit-width 1 that may have the value of 0 or 1
        /// </summary>
        public const string bit = u1 + or + i1;

        /// <summary>
        /// Signed 8-bit scalars
        /// </summary>
        public const string i8 = i + N8;

        /// <summary>
        /// Unsigned 8-bit scalars
        /// </summary>
        public const string u8 = u + N8;

        /// <summary>
        /// Signed 16-bit scalars
        /// </summary>
        public const string i16 = i + N16;

        /// <summary>
        /// Unsigned 16-bit scalars
        /// </summary>
        public const string u16 = u + N16;

        /// <summary>
        /// Signed 32-bit scalars
        /// </summary>
        public const string i32 = i + N32;

        /// <summary>
        /// Unsigned 32-bit scalars
        /// </summary>
        public const string u32 = u + N32;

        /// <summary>
        /// Signed 64-bit scalars
        /// </summary>
        public const string i64 = i + N64;

        /// <summary>
        /// Unsigned 64-bit scalars
        /// </summary>
        public const string u64 = u + N64;

        /// <summary>
        /// 16-bit floating points
        /// </summary>
        public const string f16 = f + N16;

        /// <summary>
        /// 32-bit floating points
        /// </summary>
        public const string f32 = f + N32;

        /// <summary>
        /// 64-bit floating points
        /// </summary>
        public const string f64 = f + N64;

        /// <summary>
        /// Signed N-bit scalars
        /// </summary>
        public const string iN = i + N;

        /// <summary>
        /// Unsigned N-bit scalars
        /// </summary>
        public const string uN = u + N;
    }
}