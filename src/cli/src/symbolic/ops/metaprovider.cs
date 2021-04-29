//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    partial struct AppSymbolics
    {
        [Op]
        public static ISymMetadataProvider metaprovider(in SymbolSource source)
            => new SymMetadataProvider(source);
    }
}