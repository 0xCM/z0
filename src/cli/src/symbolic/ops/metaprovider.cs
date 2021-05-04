//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct PdbServices
    {
        [Op]
        internal static SymMetadataProvider metaprovider(in SymbolSource source)
            => new SymMetadataProvider(source);
    }
}