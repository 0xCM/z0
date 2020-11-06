//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct WfEvents
    {
        [MethodImpl(Inline)]
        public static RowEvent<T> row<T>(T data)
            => new RowEvent<T>(data);

        [MethodImpl(Inline)]
        public static RowsEvent<T> rows<T>(T content)
            where T : ITextual
                => new RowsEvent<T>(content);

        [MethodImpl(Inline)]
        public static RowsEvent<T,K> rows<T,K>(K kind, T content)
            where T : ITextual
             where K : unmanaged
                => new RowsEvent<T,K>(content, kind);
    }
}