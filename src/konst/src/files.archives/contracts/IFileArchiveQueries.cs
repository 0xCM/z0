//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFileArchiveQueries : IFileArchivePaths
    {
        IEnumerable<FS.FilePath> Files(bool recurse, params FS.FileExt[] ext)
            => Root.EnumerateFiles(recurse, ext);

        IEnumerable<FS.FilePath> Files(string pattern, bool recurse)
            => Root.EnumerateFiles(pattern,recurse);

        IEnumerable<FS.FilePath> Files()
            => Root.EnumerateFiles(true);

        IEnumerable<FS.FilePath> Files(FS.FileExt ext)
            => Root.EnumerateFiles(ext, true);

        IEnumerable<FS.FilePath> DllFiles()
            => Files(Dll);

        IEnumerable<FS.FilePath> PdbFiles()
            => Files(Pdb);

        IEnumerable<FS.FilePath> LibFiles()
            => Files(Lib);

        IEnumerable<FS.FilePath> XmlFiles()
            => Files(Xml);

        IEnumerable<FS.FilePath> ExeFiles()
            => Files(Exe);

        IEnumerable<FS.FilePath> CsvFiles()
            => Files(Csv);

        IEnumerable<FS.FilePath> IlFiles()
            => Files(Il);

        IEnumerable<FS.FilePath> JsonFiles()
            => Files(Json);

        IEnumerable<FS.FilePath> AsmFiles()
            => Files(Asm);

        IEnumerable<FS.FilePath> CsFiles()
            => Files(Cs);

        IEnumerable<FS.FilePath> IndexFiles()
            => Files(Idx);

        IEnumerable<FS.FilePath> JsonDepsFiles()
            => Files(JsonDeps);

    }
}