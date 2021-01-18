//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;

    [ApiHost]
    public readonly struct AsmBrokers
    {
        [MethodImpl(Inline), Op]
        public static BitBroker<JccKind,ApiInstruction> jmp()
            => BitFields.broker64<JccKind,ApiInstruction>();
    }
}