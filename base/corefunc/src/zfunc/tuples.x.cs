//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;

    partial class xfunc
    {
        static string coord<T>(T val)
            => val == null ? "null" : val.ToString();

        [MethodImpl(Inline)]
        public static string Format<X,Y>(this (X x,Y y) src)
            => parenthetical(src.x.ToString(), ",", src.y.ToString());
        
        [MethodImpl(Inline)]
        public static string Format<X,Y>(this IEnumerable<(X x,Y y)> src)
            => string.Join(", ", src.Select(x => x.Format()));

        /// <summary>
        /// Emits the canonical 2-tuple display format
        /// </summary>
        /// <typeparam name="X1">The type of the first coordinate</typeparam>
        /// <typeparam name="X2">The type of the second coordinate</typeparam>
        /// <param name="x">The tuple to format</param>
        [MethodImpl(Inline)]
        public static string Format<X1, X2>(this (X1 x1, X2 x2) x,
            TupleFormat style = TupleFormat.Coordinate)
                => boundaryFn(style)(string.Join(", ", coord(x.x1), coord(x.x2)));

        /// <summary>
        /// Emits the canonical 3-tuple display format
        /// </summary>
        /// <typeparam name="X1">The type of the first coordinate</typeparam>
        /// <typeparam name="X2">The type of the second coordinate</typeparam>
        /// <typeparam name="X3">The type of the third coordinate</typeparam>
        /// <param name="x">The tuple to format</param>
        [MethodImpl(Inline)]
        public static string Format<X1, X2, X3>(this (X1 x1, X2 x2, X3 x3) x,
            TupleFormat style = TupleFormat.Coordinate)
                => boundaryFn(style)(string.Join(", ", coord(x.x1), coord(x.x2), coord(x.x3)));

        /// <summary>
        /// Emits the canonical 4-tuple display format
        /// </summary>
        /// <typeparam name="X1">The type of the first coordinate</typeparam>
        /// <typeparam name="X2">The type of the second coordinate</typeparam>
        /// <typeparam name="X3">The type of the third coordinate</typeparam>
        /// <typeparam name="X4">The type of the fourth coordinate</typeparam>
        /// <param name="x">The tuple to format</param>
        [MethodImpl(Inline)]
        public static string Format<X1, X2, X3, X4>(this (X1 x1, X2 x2, X3 x3, X4 x4) x,
            TupleFormat style = TupleFormat.Coordinate)
                => boundaryFn(style)(string.Join(", ", coord(x.x1), coord(x.x2), coord(x.x3), coord(x.x4)));

        /// <summary>
        /// Emits the canonical 5-tuple display format
        /// </summary>
        /// <typeparam name="X1">The type of the first coordinate</typeparam>
        /// <typeparam name="X2">The type of the second coordinate</typeparam>
        /// <typeparam name="X3">The type of the third coordinate</typeparam>
        /// <typeparam name="X4">The type of the fourth coordinate</typeparam>
        /// <typeparam name="X5">The type of the fifth coordinate</typeparam>
        /// <param name="x">The tuple to format</param>
        [MethodImpl(Inline)]
        public static string Format<X1, X2, X3, X4, X5>(this (X1 x1, X2 x2, X3 x3, X4 x4, X5 x5) x, 
            TupleFormat style = TupleFormat.Coordinate)
                => boundaryFn(style)(string.Join(", ", coord(x.x1), coord(x.x2), coord(x.x3), coord(x.x4), coord(x.x5)));

        /// <summary>
        /// Emits the canonical 6-tuple display format
        /// </summary>
        /// <typeparam name="X1">The type of the first coordinate</typeparam>
        /// <typeparam name="X2">The type of the second coordinate</typeparam>
        /// <typeparam name="X3">The type of the third coordinate</typeparam>
        /// <typeparam name="X4">The type of the fourth coordinate</typeparam>
        /// <typeparam name="X5">The type of the fifth coordinate</typeparam>
        /// <typeparam name="X6">The type of the sixth coordinate</typeparam>
        /// <param name="x">The tuple to format</param>
        [MethodImpl(Inline)]
        public static string Format<X1, X2, X3, X4, X5, X6>(this (X1 x1, X2 x2, X3 x3, X4 x4, X5 x5, X6 x6) x, 
            TupleFormat style = TupleFormat.Coordinate)
                => boundaryFn(style)(string.Join(", ", coord(x.x1), coord(x.x2), coord(x.x3), coord(x.x4), coord(x.x5), coord(x.x6)));

        /// <summary>
        /// Splits a range into a left/right tuple index
        /// </summary>
        /// <param name="left">The index at which the selection begins</param>
        /// <param name="right">The index at which the selection ends</param>
        [MethodImpl(Inline)]
        public static (Index left, Index right) Split(this Range selection)
            => (selection.Start, selection.End);
    }

}