//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    public enum Machine : ushort
    {
        Unknown = (ushort)0,

        I386 = (ushort)332,

        WceMipsV2 = (ushort)361,

        Alpha = (ushort)388,

        SH3 = (ushort)418,

        SH3Dsp = (ushort)419,

        SH3E = (ushort)420,

        SH4 = (ushort)422,

        SH5 = (ushort)424,

        Arm = (ushort)448,

        Thumb = (ushort)450,

        ArmThumb2 = (ushort)452,

        AM33 = (ushort)467,

        PowerPC = (ushort)496,

        PowerPCFP = (ushort)497,

        IA64 = (ushort)512,

        MIPS16 = (ushort)614,

        Alpha64 = (ushort)644,

        MipsFpu = (ushort)870,

        MipsFpu16 = (ushort)1126,

        Tricore = (ushort)1312,

        Ebc = (ushort)3772,

        Amd64 = (ushort)34404,

        M32R = (ushort)36929,

        Arm64 = (ushort)43620,
    }
}