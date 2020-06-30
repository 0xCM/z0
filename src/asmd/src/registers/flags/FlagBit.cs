//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines 0-based flag register bit indices
    /// </summary>
    public enum FlagRegBit : byte
    {        
        /// <summary>
        /// The index of the <see cref='EFagBits.CF' bit/>
        ///</summary>
        CF = 0,

        /// <summary>
        /// The index of the <see cref='EFagBits.PF' bit/>
        ///</summary>
        PF = 2,
        
        /// <summary>
        /// The index of the <see cref='EFagBits.AF' bit/>
        ///</summary>
        AF = 4,

        /// <summary>
        /// The index of the <see cref='EFagBits.ZF' bit/>
        ///</summary>
        ZF = 6,

        /// <summary>
        /// The index of the <see cref='EFagBits.SF' bit/>
        ///</summary>
        SF = 7,

        /// <summary>
        /// The index of the <see cref='EFagBits.TF' bit/>
        ///</summary>
        TF = 8,

        /// <summary>
        /// The index of the <see cref='EFagBits.IF' bit/>
        ///</summary>
        IF = 9,

        /// <summary>
        /// The index of the <see cref='EFagBits.DF' bit/>
        ///</summary>
        DF = 10,

        /// <summary>
        /// The index of the <see cref='EFagBits.OF' bit/>
        ///</summary>
        OF = 11,

        /// <summary>
        /// The index of the <see cref='EFagBits.RF' bit/>
        ///</summary>
        RF = 16,

        /// <summary>
        /// The index of the <see cref='EFagBits.VM' bit/>
        ///</summary>
        VM = 17,

        /// <summary>
        /// The index of the <see cref='EFagBits.AC' bit/>
        ///</summary>
        AC = 18,

        /// <summary>
        /// The index of the <see cref='EFagBits.VIF' bit/>
        ///</summary>
        VIF = 19,

        /// <summary>
        /// The index of the <see cref='EFagBits.VIP' bit/>
        ///</summary>
        VIP = 10,

        /// <summary>
        /// The index of the <see cref='EFagBits.ID' bit/>
        ///</summary>
        ID = 21,
    }
}