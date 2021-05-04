//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Part;
    using static memory;

    partial struct root
    {
        [MethodImpl(Inline), Op]
        public static Process process()
            => Process.GetCurrentProcess();


        [MethodImpl(Inline), Op]
        public static Process process(int id)
            => Process.GetProcessById(id);
    }
}