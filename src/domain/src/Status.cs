//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiDataType]
    struct Status
    {
        public static FormatPattern<uint,ApiHostUri,uint> IndexedHost => "{2} | {0} | {1} | Api summary accumulation";

        public static FormatPattern<ApiHostUri> HostHasNoMemers => "{0} has no members";

        public static FormatPattern<uint> IndexingHosts => "Indexing {0} hosts";
    }
}