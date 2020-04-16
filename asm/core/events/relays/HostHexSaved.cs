//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static AsmEvents;

    public interface IHostHexSavedRelay : IEventBroker<HostAsmHexSaved>
    {
        HostAsmHexSaved HexSaved => HostAsmHexSaved.Empty;        
    }
}