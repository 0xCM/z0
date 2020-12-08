//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(Name)]
    public struct PipeImageFilesCmd : ICmdSpec<PipeImageFilesCmd>
    {
        public const string Name = "pipe-image-files";

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