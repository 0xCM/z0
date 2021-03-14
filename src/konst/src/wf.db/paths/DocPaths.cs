//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static DbNames;

    partial interface IEnvPaths
    {
        FS.FolderPath ListRoot()
            => DbRoot() + FS.folder(lists);

        FS.FilePath List(string name, FS.FileExt ext)
            => ListRoot() + FS.file(name, ext);

       FS.FolderPath IndexRoot()
            => TableRoot() + FS.folder(indices);

        FS.FilePath IndexFile(string id)
            => IndexRoot() + FS.file(id, Idx);

        FS.FilePath IndexFile(string subject, string id)
            => IndexDir(subject) + FS.file(id, Idx);

        FS.Files IndexFiles()
            => IndexRoot().Files(Idx);

        FS.FolderPath DocRoot()
            => DbRoot() + FS.folder(docs);

        FS.FilePath Doc(string name, FS.FileExt ext)
            => DocRoot() + FS.file(name, ext);

        FS.FilePath Doc<S>(S subject, string name, FS.FileExt ext)
            => DocRoot() + SubjectFolder(subject) + FS.file(name, ext);
    }
}