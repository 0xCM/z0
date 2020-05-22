//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    using static Pow2Kind32;

    public enum RegisterSlotIndex : byte
    {
        /// <summary>
        /// Slot 0
        ///</summary>
        S00 = (byte)(Max1 & ~Max1),

        /// <summary>
        /// Slot 1
        ///</summary>
        S01 = (byte)Max1,

        /// <summary>
        /// Slot 2
        ///</summary>
        S02 = (byte)(Max2 & ~S01),

        /// <summary>
        /// Slot 3
        ///</summary>
        S03 = (byte)Max2,

        /// <summary>
        /// Slot 4
        ///</summary>
        S04 = (byte)(Max3 & ~S03),

        /// <summary>
        /// Slot 5
        ///</summary>
        S05 = (byte)(Max3 & ~S02),

        /// <summary>
        /// Slot 6
        ///</summary>
        S06 = (byte)(Max3 & ~S01),
        
        /// <summary>
        /// Slot 7
        ///</summary>
        S07 = (byte)Max3,

        /// <summary>
        /// Slot 8
        ///</summary>
        S08 = (byte)(Max4 & ~S07),

        /// <summary>
        /// Slot 9
        ///</summary>
        S09 = (byte)(Max4 & ~S06),

        /// <summary>
        /// Slot 10
        ///</summary>
        S10 = (byte)(Max4 & ~S05),

        /// <summary>
        /// Slot 11
        ///</summary>
        S11 = (byte)(Max4 & ~S04),

        /// <summary>
        /// Slot 12
        ///</summary>
        S12 = (byte)(Max4 & ~S03),

        /// <summary>
        /// Slot 13
        ///</summary>
        S13 = (byte)(Max4 & ~S02),

        /// <summary>
        /// Slot 14
        ///</summary>
        S14 = (byte)(Max4 & ~S01),

        /// <summary>
        /// Slot 15
        ///</summary>
        S15 = (byte)Max4,

        /// <summary>
        /// Slot 16
        ///</summary>
        S16 = (byte)(Max5 & ~S15),

        /// <summary>
        /// Slot 17
        ///</summary>
        S17 = (byte)(Max5 & ~S14),

        /// <summary>
        /// Slot 18
        ///</summary>
        S18 = (byte)(Max5 & ~S13),

        /// <summary>
        /// Slot 19
        ///</summary>
        S19 = (byte)(Max5 & ~S12),

        /// <summary>
        /// Slot 20
        ///</summary>
        S20 = (byte)(Max5 & ~S11),

        /// <summary>
        /// Slot 21
        ///</summary>
        S21 = (byte)(Max5 & ~S10),

        /// <summary>
        /// Slot 22
        ///</summary>
        S22 = (byte)(Max5 & ~S09),

        /// <summary>
        /// Slot 23
        ///</summary>
        S23 = (byte)(Max5 & ~S08),

        /// <summary>
        /// Slot 24
        ///</summary>
        S24 = (byte)(Max5 & ~S07),

        /// <summary>
        /// Slot 25
        ///</summary>
        S25 = (byte)(Max5 & ~S06),

        /// <summary>
        /// Slot 26
        ///</summary>
        S26 = (byte)(Max5 & ~S05),

        /// <summary>
        /// Slot 27
        ///</summary>
        S27 = (byte)(Max5 & ~S04),

        /// <summary>
        /// Slot 28
        ///</summary>
        S28 = (byte)(Max5 & ~S03),

        /// <summary>
        /// Slot 29
        ///</summary>
        S29 = (byte)(Max5 & ~S02),

        /// <summary>
        /// Slot 30
        ///</summary>
        S30 = (byte)(Max5 & ~S01),

        /// <summary>
        /// Slot 31
        ///</summary>
        S31 = (byte)(Max5 & ~S00),       
    }
}