//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FileCatalogEntries : ITableSpan<FileCatalogEntry>
    {
        readonly TableSpan<FileCatalogEntry> Data;

        public FileCatalogEntry[] Storage
        {
            [MethodImpl(Inline)]
            get => throw new NotImplementedException();
        }

        [MethodImpl(Inline)]
        public static implicit operator FileCatalogEntries(FileCatalogEntry[] src)
            => new FileCatalogEntries(src);

        [MethodImpl(Inline)]
        public FileCatalogEntries(FileCatalogEntry[] src)
            => Data = src;
    }
}