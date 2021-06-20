//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct Cmd
    {
        public static CmdRunnerLookup lookup(Type host)
        {
            var methods = host.PublicInstanceMethods().Tagged<CmdOpAttribute>().Select(x => (x.Name, x)).ToDictionary();
            var lookup = CmdRunnerLookup.create();
            foreach(var (name,method) in methods)
            {
                var cmd = method.Tag<CmdOpAttribute>().MapValueOrDefault(m => m.CommandName, method.Name);
                lookup.Add(cmd,method);
            }
            return lookup.Seal();
        }
    }
}