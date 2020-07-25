//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
 
    public readonly partial struct MdR
    {        
        [Flags]
        public enum Characteristics : ushort
        {
            RelocsStripped = (ushort)1,

            ExecutableImage = (ushort)2,

            LineNumsStripped = (ushort)4,

            LocalSymsStripped = (ushort)8,

            AggressiveWSTrim = (ushort)16,

            LargeAddressAware = (ushort)32,

            BytesReversedLo = (ushort)128,

            Bit32Machine = (ushort)256,

            DebugStripped = (ushort)512,

            RemovableRunFromSwap = (ushort)1024,

            NetRunFromSwap = (ushort)2048,

            System = (ushort)4096,

            Dll = (ushort)8192,

            UpSystemOnly = (ushort)16384,

            BytesReversedHi = (ushort)32768,
        }
    }
}