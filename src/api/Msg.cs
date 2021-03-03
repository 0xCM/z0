//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    [ApiComplete]
    readonly partial struct Msg
    {
        public static MsgPattern<ApiHostUri,uint,uint> IndexedHost => "{0,-30} | {1}/{2}";

        public static MsgPattern<uint> IndexingHosts => "Indexing {0} hosts";

        public static MsgPattern<ApiHostUri> CreatingHostCatalog => "Creating {0} catalog";

        public static MsgPattern<ApiHostUri,Count> CreatedHostCatalog => "Created {0} catalog with {1} members";

        public static MsgPattern<ApiHostUri,FS.FilePath> HostFileMissing => "The {0} file {1} does not exist";
    }
}