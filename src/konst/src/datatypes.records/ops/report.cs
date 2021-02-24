//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Records
    {
        [MethodImpl(Inline)]
        public static Report<T> report<T>(Index<T> rows, FS.FilePath location)
            where T : struct, IRecord<T>
                => new Report<T>(rows,location);
    }
}