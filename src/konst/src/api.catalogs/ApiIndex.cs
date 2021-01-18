//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct ApiIndex
    {
        public static IApiIndex service(IWfShell wf)
            => ApiIndexService.init(wf);
    }
}