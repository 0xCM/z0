//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class WfShell
    {
        [Op]
        public static Index<ICmdReactor> reactors(IWfShell wf)
        {
            var types = wf.Components.Types();
            var reactors = types.Concrete().Tagged<CmdReactorAttribute>().Select(t => (ICmdReactor)Activator.CreateInstance(t));
            root.iter(reactors, r => r.Init(wf));
            return reactors;
        }
    }
}