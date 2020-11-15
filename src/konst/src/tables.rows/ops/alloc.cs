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

    partial struct TableRows
    {
        [MethodImpl(Inline)]
        public static TableRow<T> alloc<T>(uint cells)
            where T : struct
                => new TableRow<T>(0,default(T), sys.alloc<object>(cells));

        [MethodImpl(Inline)]
        public static TableRows<T> alloc<T>(in TableFields fields, uint rowcount)
            where T : struct
                => first(recover<byte,TableRows<T>>(span<byte>(rowsize<T>(rowcount, fields.Count))));
    }
}