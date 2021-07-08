//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    partial struct Cmd
    {
        [Op]
        public static CmdMethodLookup lookup(object host)
        {
            var type = host.GetType();
            var methods = type.InstanceMethods().Tagged<CmdOpAttribute>().Select(x => (x.Name, x)).ToDictionary();
            var lookup = CmdMethodLookup.create();
            foreach(var (name,method) in methods)
            {
                var cmd = method.Tag<CmdOpAttribute>().MapValueOrDefault(m => m.CommandName, method.Name);
                lookup.Add(cmd,method);
            }
            return lookup.Seal();
        }

    }
}