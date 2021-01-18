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
        public static ICmdExecSpec[] search(Assembly src)
        {
            var types = src.Types().Tagged<CmdAttribute>();
            var specs = types.Select(t => (ICmdExecSpec)Activator.CreateInstance(t));
            return specs;
        }
    }
}