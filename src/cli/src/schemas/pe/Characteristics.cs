//-----------------------------------------------------------------------------
// Copyright   :  Licensed to the .NET Foundation under one or more agreements.
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Pe
{
    using System;

    [Flags]
    public enum Characteristics : ushort
    {
        RelocsStripped = 0x0001,         // Relocation info stripped from file.

        ExecutableImage = 0x0002,        // File is executable  (i.e. no unresolved external references).

        LineNumsStripped = 0x0004,       // Line numbers stripped from file.

        LocalSymsStripped = 0x0008,      // Local symbols stripped from file.

        AggressiveWSTrim = 0x0010,       // Aggressively trim working set

        LargeAddressAware = 0x0020,      // App can handle >2gb addresses

        BytesReversedLo = 0x0080,        // Bytes of machine word are reversed.

        Bit32Machine = 0x0100,           // 32 bit word machine.

        DebugStripped = 0x0200,          // Debugging info stripped from file in .DBG file

        RemovableRunFromSwap = 0x0400,   // If Image is on removable media, copy and run from the swap file.

        NetRunFromSwap = 0x0800,         // If Image is on Net, copy and run from the swap file.

        System = 0x1000,                 // System File.

        Dll = 0x2000,                    // File is a DLL.

        UpSystemOnly = 0x4000,           // File should only be run on a UP machine

        BytesReversedHi = 0x8000,        // Bytes of machine word are reversed.
    }
}