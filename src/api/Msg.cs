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
        public static RenderPattern<ApiHostUri,uint,uint> IndexedHost => "{0,-30} | {1}/{2}";

        public static RenderPattern<uint> IndexingHosts => "Indexing {0} hosts";
    }
}