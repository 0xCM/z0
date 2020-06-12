//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    using Z0.Asm.Data;

    using static Seed;
    using static Memories;

    [ApiHost]
    public readonly struct ProcessBrokers : IApiHost<ProcessBrokers>
    {
        [MethodImpl(Inline), Op]
        public static DataBroker64<HostHandlerKind,HostInstructions> host(HostHandlerKind kind = default)
            => DataBrokers.broker64<HostHandlerKind,HostInstructions>(kind);

        [MethodImpl(Inline), Op]
        public static DataBroker64<HostHandlerKind,HostInstructions> host(DataHandler<HostInstructions>[] buffer, HostHandlerKind kind = default)
            => DataBrokers.broker64<HostHandlerKind,HostInstructions>(buffer, kind);

        [MethodImpl(Inline), Op]
        public static DataBroker64<JmpKind,LocatedInstruction> jmp(JmpKind kind = default)        
            => DataBrokers.broker64<JmpKind,LocatedInstruction>(kind);
        
        [MethodImpl(Inline), Op]
        public static DataBroker64<JmpKind,LocatedInstruction> jmp(DataHandler<LocatedInstruction>[] buffer, JmpKind kind = default)        
            => DataBrokers.broker64<JmpKind,LocatedInstruction>(buffer, kind);
    }
}