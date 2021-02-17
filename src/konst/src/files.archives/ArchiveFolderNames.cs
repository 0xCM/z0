//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [LiteralProvider]
    public readonly struct ArchiveFolders
    {
        public const string AppsFolder = "apps";

        public const string HexFolder = "hex";

        public const string RespackFolder = "respack";

        public const string ContentFolder = "content";

        public const string AsmFolder = "asm";

        public const string ErrorFolder = "errors";

        public const string StatusFolder = "status";

        public const string CaptureFolder = "capture";

        public const string RespackContent = RespackFolder + "/" + ContentFolder;
    }
}
