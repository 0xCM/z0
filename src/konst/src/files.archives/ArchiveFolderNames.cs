//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [LiteralProvider]
    public readonly struct ArchiveFolderNames
    {
        public const string AppsFolder = "apps";

        public const string Hex = "hex";

        public const string Respack = "respack";

        public const string ContentFolder = "content";

        public const string Asm = "asm";

        public const string ErrorLog = "errors";

        public const string StatusLog = "status";

        public const string Capture = "capture";

        public const string RespackContent = Respack + "/" + ContentFolder;
    }
}
