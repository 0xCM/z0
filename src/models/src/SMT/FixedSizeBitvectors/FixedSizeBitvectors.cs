//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models.SMT
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// http://smtlib.cs.uiowa.edu/theories-FixedSizeBitVectors.shtml
    /// </summary>
    [ApiHost]
    public readonly partial struct FixedSizeBitvectors
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Truncated integer division which takes an integer x ≥ 0 and an integer y > 0 and returns the integer part of x divided by y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <typeparam name="T">An unsigned integral type</typeparam>
        [MethodImpl(Inline), Div, Closures(UnsignedInts)]
        public static T div<T>(T x, T y)
            where T : unmanaged
                => gmath.div<T>(x, y);

        /// <summary>
        /// which takes an integer x ≥ 0 and y > 0 and returns the remainder when x is divided by y.
        /// Note that we always have the following equivalence for y > 0: (x div y) * y + (x rem y) = x.
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <typeparam name="T">An unsigned integral type</typeparam>
        [MethodImpl(Inline), Mod, Closures(UnsignedInts)]
        public static T rem<T>(T a, T b)
            where T : unmanaged
                => gmath.mod<T>(a, b);

        /// <summary>
        /// Factory method to create a <typeparamref name='T'/>-parametric bitvector
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">An unsigned integral type</typeparam>
        [MethodImpl(Inline), Mod, Closures(UnsignedInts)]
        public static Bitvector<T> bv<T>(bits<T> src)
            where T : unmanaged
                => new Bitvector<T>(src);

        /// <summary>
        /// Factory method to create a natural <typeparamref name='T'/>-parametric bitvector
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="N"></typeparam>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Mod, Closures(UnsignedInts)]
        public static Bitvector<N,T> bv<N,T>(bits<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new Bitvector<N,T>(src);
    }
}