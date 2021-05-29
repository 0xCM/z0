//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    public readonly struct VendorDocArchive : IFileArchive
    {
        public static VendorDocArchive create()
            => new VendorDocArchive(Env.load().VendorDocs.Value);

        public static VendorDocArchive create(Env env)
            => new VendorDocArchive(env.VendorDocs.Value);

        public FS.FolderPath Root {get;}

        public VendorDocArchive(FS.FolderPath root)
        {
            Root = root;
        }

        public FS.FolderPath VendorManualRoot()
            => Root + FS.folder(manuals);

        public FS.FolderPath VendorManualDir(string vendor)
            => VendorManualRoot() + FS.folder(vendor);

        public FS.Files VendorManuals(string vendor, FS.FileExt ext)
            => VendorManualDir(vendor).Files(ext, true);
    }
}