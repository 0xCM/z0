//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    [ApiHost]
    public readonly struct AsmBrokers
    {
        [MethodImpl(Inline), Op]
        public static BitBroker<AsmHandlerKind,ApiHostRoutines> broker(AsmHandlerKind kind = default)
            => BitBrokers.broker64<AsmHandlerKind,ApiHostRoutines>(kind);

        [MethodImpl(Inline), Op]
        public static BitBroker<AsmHandlerKind,ApiHostRoutines> broker(DataHandler<ApiHostRoutines>[] buffer, AsmHandlerKind kind = default)
            => BitBrokers.broker64<AsmHandlerKind,ApiHostRoutines>(buffer, kind);

        [MethodImpl(Inline), Op]
        public static BitBroker<JccKind,ApiInstruction> jmp()
            => BitBrokers.broker64<JccKind,ApiInstruction>();

        [MethodImpl(Inline), Op]
        public static BitBroker<JccKind,ApiInstruction> jmp(DataHandler<ApiInstruction>[] buffer, JccKind kind = default)
            => BitBrokers.broker64<JccKind,ApiInstruction>(buffer, kind);
    }
}