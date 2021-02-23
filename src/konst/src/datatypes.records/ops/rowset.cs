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
        public static Rowset<T> rowset<T>(FS.FilePath location, T[] rows)
            where T : struct, IRecord<T>
                => new Rowset<T>(location,rows);
    }
}