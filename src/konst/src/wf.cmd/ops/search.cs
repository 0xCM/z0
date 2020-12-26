//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct Cmd
    {
        [Op]
        public static ICmdSpec[] search(Assembly src)
        {
            var types = src.Types().Tagged<CmdAttribute>();
            var specs = types.Select(t => (ICmdSpec)Activator.CreateInstance(t));
            return specs;
        }
    }
}