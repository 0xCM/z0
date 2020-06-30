//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using F = FlagRegBits;

    using static Pow2x32;

    /// <summary>
    /// Defines literals corresponding the bits in the EFLAGS register
    /// </summary>
    public enum EFlagBits : uint
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

        /// <summary>
        /// Resume Flag
        ///</summary>
        RF = P2ᐞ16,

        /// <summary>
        /// Virtual 8086 Mode
        ///</summary>
        VM = P2ᐞ17,

        /// <summary>
        /// Alignment Check
        ///</summary>
        AC = P2ᐞ18,

        /// <summary>
        /// Virtual Interrupt Flag
        ///</summary>
        VIF = P2ᐞ19,

        /// <summary>
        /// Virtual Interrupt Pending
        ///</summary>
        VIP = P2ᐞ20,

        /// <summary>
        /// CPUID-capability
        ///</summary>
        ID = P2ᐞ21,
    }
}