//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static VectorKind;
    using static NumericId;

    partial class VectorClassOps
    {
        /// <summary>
        /// Determines whether a vector of specified kind has a singed 8-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, sbyte t)
            => ((uint)k & (uint)NumericId.I8) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 8-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, byte t)
            => ((uint)k & (uint)NumericId.U8) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a singed 16-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, short t)
            => ((uint)k & (uint)NumericId.I16) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 16-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, ushort t)
            => ((uint)k & (uint)NumericId.U16) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a singed 32-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, int t)
             => ((uint)k & (uint)NumericId.I32) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 32-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, uint t)
            => ((uint)k & (uint)NumericId.U32) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a singed 64-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, long t)
            => ((uint)k & (uint)NumericId.I64) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 64-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, ulong t)
            => ((uint)k & (uint)NumericId.U64) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a 32-bit floating-point cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, float t)
             => ((uint)k & (uint)NumericId.F32) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a 64-bit floating-point cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, double t)
             => ((uint)k & (uint)NumericId.F64) != 0;
   }
}