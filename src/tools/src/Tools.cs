//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    [ApiHost]
    public readonly struct Tools
    {
        [Op]
        public static ToolCatalog catalog(IWfShell wf)
            => ToolCatalog.create(wf);
    }
}