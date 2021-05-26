//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct PdbServices
    {
        [Op]
        public static PdbSymbolSource source(FS.FilePath pe, FS.FilePath pdb)
            => new PdbSymbolSource(pe, pdb);

        [Op]
        public static PdbSymbolSource source(FS.FilePath pe)
            => new PdbSymbolSource(pe, pe.ChangeExtension(FS.Pdb));

        [Op]
        public static PdbSymbolSource source(BinaryCode pe, BinaryCode pdb)
            => new PdbSymbolSource(pe,pdb);
    }
}