//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Services)]

namespace Z0.Parts
{
    using System;

    public sealed class Services : Part<Services>
    {

    }
}

namespace Z0
{
    using Svc = Z0;
    public static partial class XTend
    {


    }

    struct Msg
    {
        public static MsgPattern<FS.FileUri> LoadingSpanAccessors => "Loading respack accessors from {0}";

        public static MsgPattern<Count,FS.FileUri> LoadedSpanAccessors => "Loaded {0} respack accessors from {1}";
    }

    public static class XSvc
    {
        [Op]
        public static ApiResProvider ApiResProvider(this IWfRuntime wf)
            => Svc.ApiResProvider.create(wf);
    }
}