//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Data;

    using static Konst;

    public readonly struct TableStore<F,R> : ITableStore<F,R>
        where F : unmanaged, Enum
        where R : ITable
    {
        public static TableStore<F,R> Service => default;

        public Option<FilePath> Save(R[] data, FilePath dst, FileWriteMode mode = Overwrite)
            => default;
    }
}