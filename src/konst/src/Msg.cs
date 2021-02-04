//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    [ApiDeep]
    readonly partial struct Msg
    {
        public static RenderPattern<ToolId> ToolHelpNotFound => "Tool {0} help not found";

        public static RenderPattern<FS.FilePath> FileDoesNotExist => "The file {0} does not exist";

        public static RenderPattern<Assembly,utf8> NoMatchingResources => "No {0} resources found that match {1}";

        public static RenderPattern<ApiHostUri,uint,uint> IndexedHost => "{0,-30} | {1}/{2}";

        public static RenderPattern<uint> IndexingHosts => "Indexing {0} hosts";

        public static RenderPattern<T> Dispatching<T>()
            where T : struct, ICmd<T> => "Dispatching {0}";
    }
}
