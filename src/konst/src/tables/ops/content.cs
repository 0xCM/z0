//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static FieldIndex<F> index<F>()
            where F : unmanaged, Enum
                => new FieldIndex<F>(0);

        [MethodImpl(Inline)]
        public static TableGrid<F,T> content<F,T>(T[] src, F f = default)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
                => new TableGrid<F,T>(src);

        [MethodImpl(Inline)]
        public static TableGrid<F,T,D> content<F,T,D>(T[] src, F f = default, D d = default)
            where F : unmanaged, Enum
            where D :  unmanaged, Enum
            where T : struct, ITable<F,T,D>
                => new TableGrid<F,T,D>(src);

        [MethodImpl(Inline)]
        public static TableIndex<F,T,I> index<F,T,I>(T[] data, F f = default, I i = default)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
            where I : unmanaged
                => new TableIndex<F,T,I>(content(data,f));

        [MethodImpl(Inline)]
        public static TableIndex<F,T,D,I> index<F,T,D,I>(T[] data, F f = default, D d = default, I i = default)
            where F : unmanaged, Enum
            where D :  unmanaged, Enum
            where I : unmanaged
            where T : struct, ITable<F,T,D>
                    => new TableIndex<F,T,D,I>(content(data,f,d));
    }
}