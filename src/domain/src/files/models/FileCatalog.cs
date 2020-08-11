//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FileCatalog
    {
        public readonly FileCatalogEntry[] Entries;

        [MethodImpl(Inline)]
        public FileCatalog(FileCatalogEntry[] src)
        {
            Entries = src;
        }
    }
}