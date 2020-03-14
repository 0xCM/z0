//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;

    partial class VectorClassOps
    {
        /// <summary>
        /// Determines whether a vector of specified kind has a specified natural width
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="w">The width to match</param>
        [MethodImpl(Inline)]
        public static bool HasCellWidth(this VectorKind k, N8 w)
            => k.HasCellType(z8) || k.HasCellType(z8i);

        /// <summary>
        /// Determines whether a vector of specified kind has a specified natural width
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="w">The width to match</param>
        [MethodImpl(Inline)]
        public static bool HasCellWidth(this VectorKind k, N16 w)
            => k.HasCellType(z16) || k.HasCellType(z16i);

        /// <summary>
        /// Determines whether a vector of specified kind has a specified natural width
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="w">The width to match</param>
        [MethodImpl(Inline)]
        public static bool HasCellWidth(this VectorKind k, N32 w)
            => k.HasCellType(z32) || k.HasCellType(z32i) || k.HasCellType(z32f);

        /// <summary>
        /// Determines whether a vector of specified kind has a specified natural width
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="w">The width to match</param>
        [MethodImpl(Inline)]
        public static bool HasCellWidth(this VectorKind k, N64 w)
            => k.HasCellType(z64) || k.HasCellType(z64i) || k.HasCellType(z64f);

    }
}