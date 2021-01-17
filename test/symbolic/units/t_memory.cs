//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    public class t_memory : t_symbolic<t_memory>
    {
        public void trace()
        {
            var located = Process.GetCurrentProcess().Modules.Cast<ProcessModule>().Map(ImageMaps.locate).OrderBy(x => x.BaseAddress);
        }
    }
}