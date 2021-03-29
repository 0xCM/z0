//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    [ApiHost]
    public sealed partial class Nasm : ToolService<Nasm>
    {
        readonly BitFormatter<byte> BitFormat;

        public Nasm()
        {
            Id = Toolsets.nasm;
            BitFormat = BitFormatter.create<byte>(4);
        }

        public FS.FileExt ListingExt
            => FS.ext("list") + FS.Asm;

        public FS.Files Listings()
            => OutDir.Files(ListingExt, true);

        public bool IsListing(FS.FilePath src)
            => src.Format().EndsWith(ListingExt.Format());
   }
}