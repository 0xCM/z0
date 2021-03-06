//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    partial class Nasm
    {
        public FS.FilePath ListPath(Identifier name)
            => Output(FS.file(name + ".bin", ListingExt));

        public FS.FilePath ListPath(FS.FolderPath dst, Identifier name)
            => dst + FS.file(name + ".bin", ListingExt);

        public FS.Files Listings()
            => OutDir.Files(ListingExt, true);

        public bool IsListing(FS.FilePath src)
            => src.Format().EndsWith(ListingExt.Format());

        public FS.FileExt ListingExt
            => FS.ext("list") + FS.Asm;
    }
}