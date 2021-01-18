//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct ListArchiveFilesCmd : ICmd<ListArchiveFilesCmd>
    {
        public const string CmdName = "list-archive-files";

        /// <summary>
        /// The archive classifier
        /// </summary>
        public ulong ArchiveKind {get;}

        /// <summary>
        /// The archive root
        /// </summary>
        public FS.FolderPath ArchiveRoot {get;}
    }
}