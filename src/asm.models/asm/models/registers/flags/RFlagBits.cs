//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using F = EFlagBits;

    /// <summary>
    /// Defines literals corresponding the bits in the RFLAGS register
    /// </summary>
    public enum RFlagBits : ulong
    {
        CF = F.CF,

        PF = F.PF,
        
        AF = F.AF,

        ZF = F.ZF,

        SF = F.SF,

        TF = F.TF,

        IF = F.IF,

        DF = F.DF,

        OF = F.OF,

        RF = F.RF,

        VM = F.VM,

        AC = F.AC,

        VIF = F.VIF,

        VIP = F.VIP,

        ID = F.ID,
    }
}