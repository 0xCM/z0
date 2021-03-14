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

    using static Root;

    sealed class PdbSymbolStore : WfService<PdbSymbolStore,IPdbSymbolStore>, IPdbSymbolStore
    {
        public DirectorySymbolStore DirectoryStore(FS.FolderPath dir)
            => new DirectorySymbolStore(tracer(Wf), null, dir.Name);

        public SymbolStoreFile SymbolFile(FS.FilePath src)
            => new SymbolStoreFile(src.Stream(), src.FileName.Name);

        public KeyGenerator KeyGenerator(SymbolStoreFile src)
            => new PortablePDBFileKeyGenerator(tracer(Wf), src);

        public IEnumerable<SymbolStoreKey> Identities(KeyGenerator src)
            => src.GetKeys(KeyTypeFlags.IdentityKey);

        [MethodImpl(Inline)]
        static ITracer tracer(IWfShell wf)
            => new SymbolTracer(wf);

        public Index<FS.FilePath> SymbolPaths(FS.FolderPath src)
            => src.Files(FS.Extensions.Pdb, true);
    }
}