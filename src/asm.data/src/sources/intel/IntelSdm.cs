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

    public readonly partial struct IntelSdm
    {
        [MethodImpl(Inline)]
        public static TableNumber table(char major, byte minor)
            => new TableNumber(major,minor);
    }
}