//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ArchivedTable<T>
        where T : struct
    {
        public readonly FilePath Location;

        [MethodImpl(Inline)]
        public ArchivedTable(FilePath path)
        {
            Location = path;
        }
    }
}
