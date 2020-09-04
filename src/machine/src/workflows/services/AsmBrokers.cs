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
        public static BitBroker<JmpKind,BasedAsmFx> jmp()
            => BitBrokers.broker64<JmpKind,BasedAsmFx>();

        [MethodImpl(Inline), Op]
        public static BitBroker<JmpKind,BasedAsmFx> jmp(WfDataHandler<BasedAsmFx>[] buffer, JmpKind kind = default)
            => BitBrokers.broker64<JmpKind,BasedAsmFx>(buffer, kind);
    }
}