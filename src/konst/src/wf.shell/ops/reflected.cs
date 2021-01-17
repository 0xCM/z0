//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class WfShell
    {
        [MethodImpl(Inline), Op]
        public static Reflected reflected(IWfShell wf)
            => new Reflected(wf);
    }
}