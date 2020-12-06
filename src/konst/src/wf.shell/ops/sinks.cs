//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial class WfShell
    {
        public static IWfSink[] sinks(IWfShell wf, params Assembly[] components)
        {
            var types = components.Length == 0 ? wf.Components.Types() : components.Types();
            var sinks = types.Concrete().Tagged<WfSinkAttribute>().Select(t => (IWfSink)Activator.CreateInstance(t));
            iter(sinks, r => r.Init(wf));
            return sinks;
        }
    }
}