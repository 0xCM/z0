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
        public static BitBroker<JmpKind,ApiInstruction> jmp()
            => BitBrokers.broker64<JmpKind,ApiInstruction>();

        [MethodImpl(Inline), Op]
        public static BitBroker<JmpKind,ApiInstruction> jmp(DataHandler<ApiInstruction>[] buffer, JmpKind kind = default)
            => BitBrokers.broker64<JmpKind,ApiInstruction>(buffer, kind);
    }
}