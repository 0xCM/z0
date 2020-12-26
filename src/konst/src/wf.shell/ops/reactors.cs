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
        public static ICmdReactor[] reactors(IWfShell wf)
        {
            var types = wf.Components.Types();
            wf.Status($"Searching {types.Length} types for reactors");
            var reactors = types.Concrete().Tagged<CmdReactorAttribute>().Select(t => (ICmdReactor)Activator.CreateInstance(t));
            iter(reactors, r => r.Init(wf));
            wf.Status($"Found {reactors.Length} reactors");
            return reactors;
        }
    }
}