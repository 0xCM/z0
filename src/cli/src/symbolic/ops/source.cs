//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct PdbServices
    {
        [Op]
        public static SymbolSource source(FS.FilePath pe, FS.FilePath pdb)
            => new SymbolSource(pe, pdb);

        [Op]
        public static SymbolSource source(FS.FilePath pe)
            => new SymbolSource(pe, pe.ChangeExtension(FS.Pdb));

        [Op]
        public static SymbolSource source(BinaryCode pe, BinaryCode pdb)
            => new SymbolSource(pe,pdb);
    }
}