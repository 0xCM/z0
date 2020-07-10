//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;

    using static MachineEvents;
            
    public interface IMachineEvents
    {
        E Create<E>(ReadOnlySpan<byte> content, E model = default)
            where E : struct, IMachineEvent<E>
                => model.Define(content);

        AppErrorEvent Error => AppErrorEvent.Empty;   
        
        LoadedReport LoadedReport => LoadedReport.Empty;

        LoadedParseReport LoadedParseReport => LoadedParseReport.Empty;

        IndexedCode IndexedCode => IndexedCode.Empty;

        DecodedHost DecodedHost => DecodedHost.Empty;

        DecodedPart DecodedPart => DecodedPart.Empty;

        DecodedMachine DecodedIndex => DecodedMachine.Empty;
    }
}