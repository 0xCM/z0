//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static z;

    partial class WfShell
    {
        [Op]
        public static ICmdReactor[] reactors(IWfShell wf, params Assembly[] components)
        {
            var types = components.Length == 0 ? wf.Components.Types() : components.Types();
            var reactors = types.Concrete().Tagged<CmdReactorAttribute>().Select(t => (ICmdReactor)Activator.CreateInstance(t));
            iter(reactors, r => r.Init(wf));
            return reactors;
        }
    }
}