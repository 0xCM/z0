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
        public static BitBroker<AsmHandlerKind,HostAsmFx> broker(AsmHandlerKind kind = default)
            => BitBrokers.broker64<AsmHandlerKind,HostAsmFx>(kind);

        [MethodImpl(Inline), Op]
        public static BitBroker<AsmHandlerKind,HostAsmFx> broker(WfDataHandler<HostAsmFx>[] buffer, AsmHandlerKind kind = default)
            => BitBrokers.broker64<AsmHandlerKind,HostAsmFx>(buffer, kind);

        [MethodImpl(Inline), Op]
        public static BitBroker<JmpKind,ApiInstruction> jmp()
            => BitBrokers.broker64<JmpKind,ApiInstruction>();

        [MethodImpl(Inline), Op]
        public static BitBroker<JmpKind,ApiInstruction> jmp(WfDataHandler<ApiInstruction>[] buffer, JmpKind kind = default)
            => BitBrokers.broker64<JmpKind,ApiInstruction>(buffer, kind);
    }
}