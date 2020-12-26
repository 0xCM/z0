//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;
    using static z;

    public readonly struct ApiIndex
    {
        public static ApiIndexService service(IWfShell wf)
            => ApiIndexService.init(wf);
    }
}