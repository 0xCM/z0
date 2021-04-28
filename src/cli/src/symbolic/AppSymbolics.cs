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
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct AppSymbolics
    {
        [MethodImpl(Inline), Op]
        internal static Method method(ISymUnmanagedMethod src)
            => new Method(src);

        public static AppMetadataProvider provider(in SymbolSource source)
            => new AppMetadataProvider(source);

        static object importer(in SymbolSource src)
            => SymUnmanagedReaderFactory.CreateSymReaderMetadataImport(provider(src));

        public static ISymUnmanagedReader5 portable(in SymbolSource src)
            => (ISymUnmanagedReader5)new SymBinder().GetReaderFromStream(src.PdbStream, importer(src));

        public static ISymUnmanagedReader5 legacy(in SymbolSource src)
            => SymUnmanagedReaderFactory.CreateReader<ISymUnmanagedReader5>(src.PdbStream, provider(src));

        public static SymbolSource source(FS.FilePath pe, FS.FilePath pdb)
            => new SymbolSource(pe, pdb);

        [Op]
        public static SymbolSource source(FS.FilePath pe)
            => new SymbolSource(pe, pe.ChangeExtension(FS.Pdb));

        public static SymbolSource source(BinaryCode pe, BinaryCode pdb)
            => new SymbolSource(pe,pdb);

        public static AppSymReader reader(SymbolSource src)
            => src.IsPortable ? new AppSymReader(src, portable(src)) : new AppSymReader(src, legacy(src));

        public static AppSymReader reader(FS.FilePath pe, FS.FilePath pdb)
        {
            if(!pe.Exists)
                root.@throw(FS.Msg.DoesNotExist.Format(pe));
            if(!pdb.Exists)
                root.@throw(FS.Msg.DoesNotExist.Format(pdb));
            return reader(source(pe, pdb));
        }
    }
}