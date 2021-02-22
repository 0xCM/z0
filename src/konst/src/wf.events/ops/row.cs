//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct WfEvents
    {
        [MethodImpl(Inline)]
        public static RowEvent<T> row<T>(T data)
            => new RowEvent<T>(data);

        [MethodImpl(Inline)]
        public static RowsEvent<T> rows<T>(T data)
            => new RowsEvent<T>(data);
    }
}