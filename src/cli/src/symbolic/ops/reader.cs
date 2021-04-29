//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using Microsoft.DiaSymReader;
    using Microsoft.DiaSymReader.PortablePdb;

    using static Part;
    using static memory;

    partial struct AppSymbolics
    {
        public static AppSymReader reader(in SymbolSource src)
            => src.IsPortable
            ? new AppSymReader(src, PortableReader(src))
            : new AppSymReader(src, LegacyReader(src));

        public static AppSymReader reader(FS.FilePath pe, FS.FilePath pdb)
        {
            if(!pe.Exists)
                root.@throw(FS.Msg.DoesNotExist.Format(pe));
            if(!pdb.Exists)
                root.@throw(FS.Msg.DoesNotExist.Format(pdb));
            return reader(source(pe, pdb));
        }

        static object importer(in SymbolSource src)
            => SymUnmanagedReaderFactory.CreateSymReaderMetadataImport(metaprovider(src));

        static ISymUnmanagedReader5 PortableReader(in SymbolSource src)
            => (ISymUnmanagedReader5)new SymBinder().GetReaderFromStream(src.PdbStream, importer(src));

        static ISymUnmanagedReader5 LegacyReader(in SymbolSource src)
            => SymUnmanagedReaderFactory.CreateReader<ISymUnmanagedReader5>(src.PdbStream, metaprovider(src));
    }
}