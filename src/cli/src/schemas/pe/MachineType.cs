//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Pe
{
    /// <summary>
    /// Spcifies a CPU type. An image file can be run only on the specified machine or on a system that emulates the specified machine.
    /// </summary>
    public enum MachineType : ushort
    {
        Unknown = 0x0000,

        I386 = 0x014C,

        WceMipsV2 = 0x0169,

        Alpha = 0x0184,

        SH3 = 0x01a2,

        SH3Dsp = 0x01a3,

        SH3E = 0x01a4,

        SH4 = 0x01a6,

        SH5 = 0x01a8,

        Arm = 0x01c0,

        Thumb = 0x01c2,

        ArmThumb2 = 0x01c4,

        AM33 = 0x01d3,

        PowerPC = 0x01F0,

        PowerPCFP = 0x01f1,

        IA64 = 0x0200,

        MIPS16 = 0x0266,

        Alpha64 = 0x0284,

        MipsFpu = 0x0366,

        MipsFpu16 = 0x0466,

        Tricore = 0x0520,

        Ebc = 0x0EBC,

        Amd64 = 0x8664,

        M32R = 0x9041,

        Arm64 = 0xAA64,
    }
}