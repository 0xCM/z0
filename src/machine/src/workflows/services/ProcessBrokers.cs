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
    public readonly struct ProcessBrokers
    {
        [MethodImpl(Inline), Op]
        public static BitBroker<HostHandlerKind,HostAsmFx> host(HostHandlerKind kind = default)
            => DataBrokers.broker64<HostHandlerKind,HostAsmFx>(kind);

        [MethodImpl(Inline), Op]
        public static BitBroker<HostHandlerKind,HostAsmFx> host(DataHandler<HostAsmFx>[] buffer, HostHandlerKind kind = default)
            => DataBrokers.broker64<HostHandlerKind,HostAsmFx>(buffer, kind);

        [MethodImpl(Inline), Op]
        public static BitBroker<JmpKind,BasedAsmFx> jmp(JmpKind kind = default)        
            => DataBrokers.broker64<JmpKind,BasedAsmFx>(kind);
        
        [MethodImpl(Inline), Op]
        public static BitBroker<JmpKind,BasedAsmFx> jmp(DataHandler<BasedAsmFx>[] buffer, JmpKind kind = default)        
            => DataBrokers.broker64<JmpKind,BasedAsmFx>(buffer, kind);
    }
}