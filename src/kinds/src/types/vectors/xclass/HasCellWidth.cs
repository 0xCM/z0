//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Scalars;

    partial class XTend
    {
        /// <summary>
        /// Determines whether a vector of specified kind has a specified natural width
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="w">The width to match</param>
        [MethodImpl(Inline)]
        public static bool HasCellWidth(this VectorKind k, W8 w)
            => k.HasCellType(z8) || k.HasCellType(z8i);

        /// <summary>
        /// Determines whether a vector of specified kind has a specified natural width
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="w">The width to match</param>
        [MethodImpl(Inline)]
        public static bool HasCellWidth(this VectorKind k, W16 w)
            => k.HasCellType(z16) || k.HasCellType(z16i);

        /// <summary>
        /// Determines whether a vector of specified kind has a specified natural width
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="w">The width to match</param>
        [MethodImpl(Inline)]
        public static bool HasCellWidth(this VectorKind k, W32 w)
            => k.HasCellType(z32) || k.HasCellType(z32i) || k.HasCellType(z32f);

        /// <summary>
        /// Determines whether a vector of specified kind has a specified natural width
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="w">The width to match</param>
        [MethodImpl(Inline)]
        public static bool HasCellWidth(this VectorKind k, W64 w)
            => k.HasCellType(z64) || k.HasCellType(z64i) || k.HasCellType(z64f);

    }
}