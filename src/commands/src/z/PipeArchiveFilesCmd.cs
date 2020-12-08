//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(Name)]
    public struct PipeArchiveFilesCmd : ICmdSpec<PipeArchiveFilesCmd>
    {
        public const string Name = "pipe-archive-files";

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