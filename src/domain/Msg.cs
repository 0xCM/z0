//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    [ApiDataType]
    struct Msg
    {
        public static RenderPattern<Assembly,utf8> NoMatchingResources => "No {0} resources found that match {1}";

        public static RenderPattern<uint,ApiHostUri,uint> IndexedHost => "{2} | {0} | {1} | Api summary accumulation";

        public static RenderPattern<uint> IndexingHosts => "Indexing {0} hosts";

        public static RenderPattern<Assembly,uint> EmittingResources => "Emitting {1} {0} resources";

        public static RenderPattern<uint,FS.FilePath> EmittedOpIndex => "Emitted operation index for {0} hosts to {1}";
    }
}