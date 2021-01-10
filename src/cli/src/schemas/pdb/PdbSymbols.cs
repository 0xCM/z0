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

    using static memory;
    using static Part;

    sealed class PdbSymbolStoreSvc : WfService<PdbSymbolStoreSvc,IPdbSymbolStore>, IPdbSymbolStore
    {
        public DirectorySymbolStore DirectoryStore(FS.FolderPath dir)
            => new DirectorySymbolStore(tracer(Wf), null, dir.Name);

        [Op]
        public SymbolStoreFile SymbolFile(FS.FilePath src)
            => new SymbolStoreFile(src.Stream(), src.FileName.Name);

        [Op]
        public KeyGenerator KeyGenerator(SymbolStoreFile src)
            => new PortablePDBFileKeyGenerator(tracer(Wf), src);

        [Op]
        public IEnumerable<SymbolStoreKey> Identities(KeyGenerator src)
            => src.GetKeys(KeyTypeFlags.IdentityKey);

        [MethodImpl(Inline)]
        static ITracer tracer(IWfShell wf)
            => new SymbolTracer(wf);
    }
}