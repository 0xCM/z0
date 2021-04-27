//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Part;

    partial class XCmd
    {
        public static IEnumerable<ICmd> FindCommands(this IWfRuntime wf)
        {
            foreach(var a in wf.Components)
            {
                foreach(var c in Cmd.search(a))
                {
                    yield return c;
                }
            }
        }

        public static string Format<C>(this C src)
            where C : struct, ICmd<C>
                => CmdFormat.format(src);
    }
}