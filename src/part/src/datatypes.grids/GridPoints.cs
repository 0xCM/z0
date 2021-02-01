//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct GridPoints
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static GridPoint point(uint row, uint col)
            => new GridPoint(row, col);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static GridPoint<T> point<T>(T row, T col)
            where T : unmanaged
                => new GridPoint<T>(row, col);

        [MethodImpl(Inline), Op]
        public static GridRegion region(GridPoint upper, GridPoint lower)
            => new GridRegion(upper, lower);

        [MethodImpl(Inline), Op]
        public static GridRegion<T> region<T>(GridPoint<T> upper, GridPoint<T> lower)
            where T : unmanaged
                => new GridRegion<T>(upper, lower);

        [MethodImpl(Inline), Op]
        public static GridRegion region(uint upper, uint left, uint lower, uint right)
            => new GridRegion(point(upper,left), point(lower,right));


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static GridRegion<T> region<T>(T upper, T left, T lower, T right)
            where T : unmanaged
                => new GridRegion<T>(point(upper,left), point(lower,right));
    }
}