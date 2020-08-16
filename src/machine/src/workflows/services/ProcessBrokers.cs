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
        public static BitBroker<HostHandlerKind,HostInstructions> host(HostHandlerKind kind = default)
            => DataBrokers.broker64<HostHandlerKind,HostInstructions>(kind);

        [MethodImpl(Inline), Op]
        public static BitBroker<HostHandlerKind,HostInstructions> host(DataHandler<HostInstructions>[] buffer, HostHandlerKind kind = default)
            => DataBrokers.broker64<HostHandlerKind,HostInstructions>(buffer, kind);

        [MethodImpl(Inline), Op]
        public static BitBroker<JmpKind,LocatedAsmFx> jmp(JmpKind kind = default)        
            => DataBrokers.broker64<JmpKind,LocatedAsmFx>(kind);
        
        [MethodImpl(Inline), Op]
        public static BitBroker<JmpKind,LocatedAsmFx> jmp(DataHandler<LocatedAsmFx>[] buffer, JmpKind kind = default)        
            => DataBrokers.broker64<JmpKind,LocatedAsmFx>(buffer, kind);
    }
}