//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Components;
    using static NumericReps;

    public static class VectorKindOps
    {
        /// <summary>
        /// Determines whether a vector of specified kind has a singed 8-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, sbyte t)
            => ((uint)k & (uint)NumericKindId.I8) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 8-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, byte t)
            => ((uint)k & (uint)NumericKindId.U8) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a singed 16-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, short t)
            => ((uint)k & (uint)NumericKindId.I16) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 16-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, ushort t)
            => ((uint)k & (uint)NumericKindId.U16) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a singed 32-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, int t)
             => ((uint)k & (uint)NumericKindId.I32) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 32-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, uint t)
            => ((uint)k & (uint)NumericKindId.U32) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a singed 64-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, long t)
            => ((uint)k & (uint)NumericKindId.I64) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 64-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, ulong t)
            => ((uint)k & (uint)NumericKindId.U64) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a 32-bit floating-point cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, float t)
             => ((uint)k & (uint)NumericKindId.F32) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a 64-bit floating-point cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline)]
        public static bool HasCellType(this VectorKind k, double t)
             => ((uint)k & (uint)NumericKindId.F64) != 0;

        /// <summary>
        /// Returns the clr cell type of a vector of specified kind
        /// </summary>
        /// <param name="kind">The vector kind</param>
        public static Type CellType(this VectorKind kind)       
        {
            if(kind.HasCellType(z8i))
                return typeof(sbyte);
            else if(kind.HasCellType(z8))
                return typeof(byte);
            else if(kind.HasCellType(z16i))
                return typeof(short);
            else if(kind.HasCellType(z16))
                return typeof(ushort);
            else if(kind.HasCellType(z32i))
                return typeof(int);
            else if(kind.HasCellType(z32))
                return typeof(uint);
            else if(kind.HasCellType(z64i))
                return typeof(long);
            else if(kind.HasCellType(z64))
                return typeof(ulong);
            else if(kind.HasCellType(z32f))
                return typeof(float);
            else if(kind.HasCellType(z64f))
                return typeof(double);
            else 
                return typeof(void);                
        }

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