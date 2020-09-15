//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

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

        public static IEnumerable<F> Create<F,W,T>(IPolyrand random, F f = default, T t = default)
            where F : unmanaged, IDataCell
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CellStreamProvider<F,W,T>(random, random.Domain<T>()).Stream;

        public static IEnumerable<F> Create<F,W,T>(IPolyrand random, Interval<T> celldomain)
            where F : unmanaged, IDataCell
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CellStreamProvider<F,W,T>(random, celldomain).Stream;
    }
}