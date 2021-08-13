//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct AsmEncoder
    {
        [ApiHost("encoder.calls")]
        public readonly partial struct Calls
        {
            [MethodImpl(Inline), Op]
            public static CallRel32 rel32(MemoryAddress client, uint dx)
                => new CallRel32(client, dx);
        }
    }
}