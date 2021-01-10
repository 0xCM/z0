//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XVexKinds
    {
        /// <summary>
        /// Determines whether a vector of specified kind has a singed 8-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Op]
        public static bool HasCellType(this VectorKind k, sbyte t)
            => VKinds.test(k,t);

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 8-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Op]
        public static bool HasCellType(this VectorKind k, byte t)
            => VKinds.test(k,t);

        /// <summary>
        /// Determines whether a vector of specified kind has a singed 16-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Op]
        public static bool HasCellType(this VectorKind k, short t)
            => VKinds.test(k,t);

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 16-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Op]
        public static bool HasCellType(this VectorKind k, ushort t)
            => VKinds.test(k,t);

        /// <summary>
        /// Determines whether a vector of specified kind has a singed 32-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Op]
        public static bool HasCellType(this VectorKind k, int t)
            => VKinds.test(k,t);

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 32-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Op]
        public static bool HasCellType(this VectorKind k, uint t)
            => VKinds.test(k,t);

        /// <summary>
        /// Determines whether a vector of specified kind has a singed 64-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Op]
        public static bool HasCellType(this VectorKind k, long t)
            => VKinds.test(k,t);

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 64-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Op]
        public static bool HasCellType(this VectorKind k, ulong t)
            => VKinds.test(k,t);

        /// <summary>
        /// Determines whether a vector of specified kind has a 32-bit floating-point cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Op]
        public static bool HasCellType(this VectorKind k, float t)
            => VKinds.test(k,t);

        /// <summary>
        /// Determines whether a vector of specified kind has a 64-bit floating-point cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Op]
        public static bool HasCellType(this VectorKind k, double t)
            => VKinds.test(k,t);
    }
}