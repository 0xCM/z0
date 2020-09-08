//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        public readonly struct Catalog
        {
            public readonly CatalogEntry[] Entries;

            [MethodImpl(Inline)]
            public Catalog(CatalogEntry[] src)
            {
                Entries = src;
            }
        }
    }
}