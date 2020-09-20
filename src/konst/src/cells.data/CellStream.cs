//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    [ApiHost]
    public readonly struct CellStream
    {
        public static IEnumerable<F> create<F>(ICellSource<F> source)
            where F : struct, IDataCell
        {
            while(true)
            {
                yield return source.Next();
            }
        }

        [Op,Closures(UnsignedInts)]
        public static IEnumerable<Cell128> Create<T>(IPolyrand random, W128 w, in Interval<T> domain)
            where T : unmanaged
                => new CellStreamProvider<Cell128,W128,T>(random, domain).Stream;

        public static IEnumerable<F> Create<F,W,T>(IPolyrand random, F f = default, T t = default)
            where F : unmanaged, IDataCell
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CellStreamProvider<F,W,T>(random, random.Domain<T>()).Stream;

        public static IEnumerable<F> Create<F,W,T>(IPolyrand random, Interval<T> domain)
            where F : unmanaged, IDataCell
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CellStreamProvider<F,W,T>(random, domain).Stream;
    }
}