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
        public static BitBroker<HostHandlerKind,HostAsmFx> host(HostHandlerKind kind = default)
            => DataBrokers.broker64<HostHandlerKind,HostAsmFx>(kind);

        [MethodImpl(Inline), Op]
        public static BitBroker<HostHandlerKind,HostAsmFx> host(WfDataHandler<HostAsmFx>[] buffer, HostHandlerKind kind = default)
            => DataBrokers.broker64<HostHandlerKind,HostAsmFx>(buffer, kind);

        [MethodImpl(Inline), Op]
        public static BitBroker<JmpKind,BasedAsmFx> jmp(JmpKind kind = default)
            => DataBrokers.broker64<JmpKind,BasedAsmFx>(kind);

        [MethodImpl(Inline), Op]
        public static BitBroker<JmpKind,BasedAsmFx> jmp(WfDataHandler<BasedAsmFx>[] buffer, JmpKind kind = default)
            => DataBrokers.broker64<JmpKind,BasedAsmFx>(buffer, kind);
    }
}