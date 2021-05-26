//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath ListRoot()
            => DbRoot() + FS.folder(lists);

        FS.FolderPath VendorDocs()
            => Env.VendorDocs;

        FS.FolderPath VendorDocs(FS.FolderPath root)
            => root;

        FS.FolderPath VendorManualRoot()
            => VendorDocs() + FS.folder(manuals);

        FS.FolderPath VendorManualDir(FS.FolderPath root)
            => VendorDocs(root) + FS.folder(manuals);

        FS.FolderPath VendorManualDir(string vendor)
            => VendorManualRoot() + FS.folder(vendor);

        FS.FolderPath VendorManualDir(FS.FolderPath root, string vendor)
            => VendorManualDir(root) + FS.folder(vendor);

        FS.Files VendorManuals(string vendor, FS.FileExt ext)
            => VendorManualDir(vendor).Files(ext, true);

        FS.Files VendorManuals(FS.FolderPath root, string vendor, FS.FileExt ext)
            => VendorManualDir(root, vendor).Files(ext, true);

        FS.FilePath List(string name, FS.FileExt ext)
            => ListRoot() + FS.file(name, ext);

        FS.FolderPath DocRoot()
            => DbRoot() + FS.folder(docs);

        FS.FolderPath DocDir<S>(S subject)
            => DocRoot() + SubjectFolder(subject);

        FS.FilePath Doc(string name, FS.FileExt ext)
            => DocRoot() + FS.file(name, ext);

        FS.FilePath Doc<S>(S subject, string name, FS.FileExt ext)
            => DocRoot() + SubjectFolder(subject) + FS.file(name, ext);
    }
}