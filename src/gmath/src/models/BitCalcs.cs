//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost]
    public readonly struct BitCalcs
    {
        /// <summary>
        /// Computes the number of bytes required to cover a grid, predicated on row/col counts
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T tablesize<T>(T rows, T cols)
            where T : unmanaged
        {
            var points = gmath.mul(rows, cols);
            var mod = gmath.mod(points, NumericCast.force<T>(8));
            var rem = gmath.nonz(mod) ? one<T>() : zero<T>();
            return gmath.add(gmath.srl(points, 3), rem);
        }

        [MethodImpl(Inline), Op]
        public static ulong tablesize(ulong rows, ulong cols)
        {
            var points = rows*cols;
            var mod = math.mod(points, 8ul);
            var rem = math.nonz(mod) ? 1ul : 0ul;
            return math.add(math.srl(points, 3), rem);
        }
    }
}