//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Records
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ByteSize rowsize<T>(uint cells)
            where T : struct
                => size<T>() + sizeof(uint) + size<object>() * cells;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ByteSize rowsize<T>(uint rows, uint cells)
            where T : struct
                => rowsize<T>(cells)*rows;
    }
}