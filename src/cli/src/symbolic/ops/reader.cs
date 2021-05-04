//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Microsoft.DiaSymReader;
    using Microsoft.DiaSymReader.PortablePdb;

    partial struct PdbServices
    {
        public static PdbReader reader(IWfRuntime wf, in SymbolSource src)
        {
            var flow = wf.Running(Msg.CreatingPdbReader.Format(src.PdbPath));
            var reader = default(PdbReader);
            if(src.IsPortable)
            {
                reader = new PdbReader(wf, src, portable(src));
            }
            else
            {
                reader = new PdbReader(wf, src, legacy(src));
            }
            wf.Ran(flow, Msg.CreatedPdbReader.Format(src.PdbPath));
            return reader;
        }

        public static PdbReader reader(IWfRuntime wf, FS.FilePath pe, FS.FilePath pdb)
        {
            if(!pe.Exists)
                root.@throw(FS.Msg.DoesNotExist.Format(pe));
            if(!pdb.Exists)
                root.@throw(FS.Msg.DoesNotExist.Format(pdb));
            return reader(wf, source(pe, pdb));
        }

        static object importer(in SymbolSource src)
            => SymUnmanagedReaderFactory.CreateSymReaderMetadataImport(metaprovider(src));

        internal static ISymUnmanagedReader5 portable(in SymbolSource src)
            => (ISymUnmanagedReader5)new SymBinder().GetReaderFromStream(src.PdbStream, importer(src));

        internal static ISymUnmanagedReader5 legacy(in SymbolSource src)
            => SymUnmanagedReaderFactory.CreateReader<ISymUnmanagedReader5>(src.PdbStream, metaprovider(src));
    }
}