//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static ByteSize rowsize<T>(uint cells)
            where T : struct
                => z.size<T>() + sizeof(uint) + z.size<object>() * cells;

        [MethodImpl(Inline)]
        public static ByteSize rowsize<T>(uint rows, uint cells)
            where T : struct
                => rowsize<T>(cells)*rows;

        [MethodImpl(Inline)]
        public static TableRow<T> rowalloc<T>(uint cells)
            where T : struct
                => new TableRow<T>(0,default(T), sys.alloc<object>(cells));

        [MethodImpl(Inline)]
        public static TableRows<T> rowalloc<T>(in TableFields fields, uint rowcount)
            where T : struct
                => z.first(z.recover<byte,TableRows<T>>(z.span<byte>(rowsize<T>(rowcount, fields.Count))));
    }
}