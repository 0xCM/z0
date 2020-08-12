//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline), Op]
        public static RowValue value(byte[] src)
            => new RowValue(src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RowValue<T> value<T>(T src)
            where T : struct
                => new RowValue<T>(src);
    }
}