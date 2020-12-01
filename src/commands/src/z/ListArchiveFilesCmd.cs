//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(Name)]
    public struct ListArchiveFilesCmd : ICmdSpec<ListArchiveFilesCmd>
    {
        public const string Name = "list-files";

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