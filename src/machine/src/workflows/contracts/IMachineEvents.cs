//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMachineEvents
    {
        AppErrorEvent Error => default;
        
        LoadedParseReport LoadedParseReport => default;

        IndexedEncoded IndexedCode => default;

        DecodedHost DecodedHost => default;

        DecodedPart DecodedPart => default;

        DecodedMachine DecodedIndex => default;
    }
}