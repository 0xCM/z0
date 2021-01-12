//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Microsoft.SymbolStore;
    using Microsoft.SymbolStore.KeyGenerators;
    using SOS;
    using System.Collections.Generic;

    public interface IPdbSymbolStore : IDataStore
    {
        DirectorySymbolStore DirectoryStore(FS.FolderPath dir);

        SymbolStoreFile SymbolFile(FS.FilePath src);

        KeyGenerator KeyGenerator(SymbolStoreFile src);

        IEnumerable<SymbolStoreKey> Identities(KeyGenerator src);
    }
}