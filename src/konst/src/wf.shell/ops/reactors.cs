//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class WfRuntime
    {
        public static IRuntimeArchive RuntimeArchive(IWfRuntime wf)
            => Z0.RuntimeArchive.create(wf.Controller.ImageDir);

        [Op]
        public static Index<ICmdReactor> reactors(IWfRuntime wf)
        {
            var types = wf.Components.Types();
            var reactors = types.Concrete().Tagged<CmdReactorAttribute>().Select(t => (ICmdReactor)Activator.CreateInstance(t));
            root.iter(reactors, r => r.Init(wf));
            return reactors;
        }
    }
}