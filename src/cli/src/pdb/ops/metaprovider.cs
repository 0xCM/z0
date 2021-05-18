//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static PdbModel;

    partial struct PdbServices
    {
        [Op]
        internal static SymMetadataProvider metaprovider(in PdbSymbolSource source)
            => new SymMetadataProvider(source);
    }
}