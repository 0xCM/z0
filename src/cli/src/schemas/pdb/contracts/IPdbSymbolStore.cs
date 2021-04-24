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

    public interface IPdbSymbolStore
    {
        DirectorySymbolStore DirectoryStore(FS.FolderPath dir);

        SymbolStoreFile SymbolFile(FS.FilePath src);

        KeyGenerator KeyGenerator(SymbolStoreFile src);

        Index<SymbolStoreKey> Identities(KeyGenerator src);

        FS.Files SymbolPaths(FS.FolderPath src);

        Index<SymbolStoreKey> Identities(SymbolStoreFile src);

        Index<SymbolStoreKey> SymbolKeys(SymbolStoreFile src);
    }
}