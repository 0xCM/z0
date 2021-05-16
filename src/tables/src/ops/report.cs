//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Tables
    {
        [MethodImpl(Inline)]
        public static Report<T> report<T>(Index<T> rows, FS.FilePath location)
            where T : struct, IRecord<T>
                => new Report<T>(rows,location);
    }
}