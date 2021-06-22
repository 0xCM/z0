//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Svc = Z0;

    [ApiHost]
    public static partial class XSvc
    {
        [Op]
        public static GlobalCommands GlobalCommands(this IWfRuntime wf)
            => Svc.GlobalCommands.create(wf);
    }
}