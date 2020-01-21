//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static partial class TypeApiX
    {
        /// <summary>
        /// Specifies the bit-width of a classified cpu vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static int BitWidth(this VectorKind k)
            => VectorType.width(k);

        [MethodImpl(Inline)]
        public static bool IsSome(this VectorKind k)
            => k != VectorKind.None;

        [MethodImpl(Inline)]
        public static VectorWidth Width(this VectorKind kind)
            => (VectorWidth)((ushort)kind);

        /// <summary>
        /// Determines whether a type is an intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t)
            => VectorType.test(t);

        /// <summary>
        /// Determines whether a type is an intrinsic vector of specified width
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t, FixedWidth width)        
            => VectorType.vector(t,(int)width);
    }
}
