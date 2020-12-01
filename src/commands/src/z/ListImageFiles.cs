//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(Name)]
    public struct ListImageFilesCmd : ICmdSpec<ListImageFilesCmd>
    {
        public const string Verb = "list-files";

        public const string Name = Verb + "--images";

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