//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ByteSize rowsize<T>(uint cells)
            where T : struct
                => z.size<T>() + sizeof(uint) + z.size<object>() * cells;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ByteSize rowsize<T>(uint rows, uint cells)
            where T : struct
                => rowsize<T>(cells)*rows;
    }
}