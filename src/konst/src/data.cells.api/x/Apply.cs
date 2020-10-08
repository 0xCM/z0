//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;

    using static CellSource;
    using static Konst;

    partial class XCell
    {
        /// <summary>
        /// Creates a stream of fixed values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static IEnumerable<F> CellStream<F>(this IPolyrand random)
            where F: unmanaged, IDataCell
                => Cells.stream(create<F>(random));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector512<T> Apply<T>(this UnaryOp512 f, Vector512<T> x)
           where T : unmanaged
                => f(x.ToCell<T>()).ToVector<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector512<T> Apply<T>(this BinaryOp512 f, Vector512<T> x, Vector512<T> y)
            where T : unmanaged
        {
            var zf = f(Unsafe.As<Vector512<T>,Cell512>(ref x), Unsafe.As<Vector512<T>,Cell512>(ref y));
            return Unsafe.As<Cell512,Vector512<T>>(ref zf);
        }
    }
}