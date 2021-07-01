//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial struct IntelSdm
    {
        [MethodImpl(Inline), Op]
        internal static PageFooter footer(string l0, string l1, string r0, string r1)
            => new PageFooter(l0,l1,r0,r1);
    }
}