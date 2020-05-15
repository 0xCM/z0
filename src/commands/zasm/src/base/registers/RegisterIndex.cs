//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Pow2Kind;

    [Flags]
    public enum RegisterIndex : ulong
    {
        /// <summary>
        /// Classifies no register index, nor anything else
        ///</summary>
        None = 0,

        /// <summary>
        /// Classifies a register that has been assigned index slot 0
        ///</summary>
        IX0 = T10 << 0,

        /// <summary>
        /// Classifies a register that has been assigned index slot 1
        ///</summary>
        IX1 = IX0 << 1,

        /// <summary>
        /// Classifies a register that has been assigned index slot 2
        ///</summary>
        IX2 = IX0 << 2,

        /// <summary>
        /// Classifies a register that has been assigned index slot 3
        ///</summary>
        IX3 = IX0 << 3,

        /// <summary>
        /// Classifies a register that has been assigned index slot 4
        ///</summary>
        IX4 = IX0 << 4,

        /// <summary>
        /// Classifies a register that has been assigned index slot 5
        ///</summary>
        IX5 = IX0 << 5,

        /// <summary>
        /// Classifies a register that has been assigned index slot 6
        ///</summary>
        IX6 = IX0 << 6,

        /// <summary>
        /// Classifies a register that has been assigned index slot 7
        ///</summary>
        IX7 = IX0 << 7,

        /// <summary>
        /// Classifies a register that has been assigned index slot 8
        ///</summary>
        IX8 = IX0 << 8,

        /// <summary>
        /// Classifies a register that has been assigned index slot 9
        ///</summary>
        IX9 = IX0 << 9,

        /// <summary>
        /// Classifies a register that has been assigned index slot 10
        ///</summary>
        IX10 = IX0 << 10,

        /// <summary>
        /// Classifies a register that has been assigned index slot 11
        ///</summary>
        IX11 = IX0 << 11,

        /// <summary>
        /// Classifies a register that has been assigned index slot 12
        ///</summary>
        IX12 = IX0 << 12,

        /// <summary>
        /// Classifies a register that has been assigned index slot 13
        ///</summary>
        IX13 = IX0 << 13,

        /// <summary>
        /// Classifies a register that has been assigned index slot 14
        ///</summary>
        IX14 = IX0 << 14,

        /// <summary>
        /// Classifies a register that has been assigned index slot 15
        ///</summary>
        IX15 = IX0 << 15,

        /// <summary>
        /// Classifies a register that has been assigned index slot 16
        ///</summary>
        IX16 = IX0 << 16,

        /// <summary>
        /// Classifies a register that has been assigned index slot 17
        ///</summary>
        IX17 = IX0 << 17,

        /// <summary>
        /// Classifies a register that has been assigned index slot 18
        ///</summary>
        IX18 = IX0 << 18,

        /// <summary>
        /// Classifies a register that has been assigned index slot 19
        ///</summary>
        IX19 = IX0 << 19,

        /// <summary>
        /// Classifies a register that has been assigned index slot 20
        ///</summary>
        IX20 = IX0 << 20,

        /// <summary>
        /// Classifies a register that has been assigned index slot 21
        ///</summary>
        IX21 = IX0 << 21,

        /// <summary>
        /// Classifies a register that has been assigned index slot 22
        ///</summary>
        IX22 = IX0 << 22,

        /// <summary>
        /// Classifies a register that has been assigned index slot 23
        ///</summary>
        IX23 = IX0 << 23,

        /// <summary>
        /// Classifies a register that has been assigned index slot 24
        ///</summary>
        IX24 = IX0 << 24,

        /// <summary>
        /// Classifies a register that has been assigned index slot 25
        ///</summary>
        IX25 = IX0 << 25,

        /// <summary>
        /// Classifies a register that has been assigned index slot 26
        ///</summary>
        IX26 = IX0 << 26,

        /// <summary>
        /// Classifies a register that has been assigned index slot 27
        ///</summary>
        IX27 = IX0 << 27,

        /// <summary>
        /// Classifies a register that has been assigned index slot 28
        ///</summary>
        IX28 = IX0 << 28,

        /// <summary>
        /// Classifies a register that has been assigned index slot 29
        ///</summary>
        IX29 = IX0 << 29,

        /// <summary>
        /// Classifies a register that has been assigned index slot 30
        ///</summary>
        IX30 = IX0 << 30,

        /// <summary>
        /// Classifies a register that has been assigned index slot 31
        ///</summary>
        IX31 = IX0 << 31,

        /// <summary>
        /// The minimum power of two employed to define an index classifier
        ///</summary>
        MinPower = 10,

        /// <summary>
        /// The minimum index classifier value
        ///</summary>
        Min = IX0,

        /// <summary>
        /// The maximum index classifier value
        ///</summary>
        Max = IX31,

        /// <summary>
        /// The join of all index classifiers
        ///</summary>
        All = IX0 | IX1 | IX2 | IX3 | IX4 | IX5 | IX6 | IX7 | IX8 | IX9 |
            IX10 | IX11 | IX12 | IX13 | IX14 | IX15 | IX16 | IX17 | IX18 | IX19 |
            IX20 | IX21 | IX22 | IX23 | IX24 | IX25 | IX26 | IX27 | IX28 | IX29 |
            IX30 | IX31,
    }
}