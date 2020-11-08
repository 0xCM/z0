//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    struct Warnings
    {
        public static RenderPattern<Assembly,utf8>  NoMatchingResources => "No {0} resources found that match {1}";
    }

    [ApiDataType]
    struct Status
    {
        public static RenderPattern<uint,ApiHostUri,uint> IndexedHost => "{2} | {0} | {1} | Api summary accumulation";

        public static RenderPattern<uint> IndexingHosts => "Indexing {0} hosts";

        public static RenderPattern<T> Dispatching<T>()
            where T : struct, ICmdSpec<T> => "Dispatching {0}";

        public static RenderPattern<Assembly,uint>  EmittingResources => "Emitting {1} {0} resources";

    }
}