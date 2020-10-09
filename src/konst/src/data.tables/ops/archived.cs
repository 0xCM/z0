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
        public static ArchivedTable<T> archived<T>(FS.FilePath src)
            where T : struct
                => new ArchivedTable<T>(src);

        [MethodImpl(Inline)]
        public static DataFlow<Rowset<T>, ArchivedTable<T>> archived<T>(Rowset<T> src, FS.FilePath dst)
            where T : struct
                => (src, new ArchivedTable<T>(dst));
    }
}