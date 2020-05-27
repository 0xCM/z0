//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    using static Pow2Kind;

    [Flags]
    public enum RegisterSlot : ulong
    {
        /// <summary>
        /// Classifies no register index, nor anything else
        ///</summary>
        None = 0,

        /// <summary>
        /// Classifies a register that has been assigned index slot 0
        ///</summary>
        IX0 = P2ᐞ10,

        /// <summary>
        /// Classifies a register that has been assigned index slot 1
        ///</summary>
        IX1 = P2ᐞ11,

        /// <summary>
        /// Classifies a register that has been assigned index slot 2
        ///</summary>
        IX2 = P2ᐞ12,

        /// <summary>
        /// Classifies a register that has been assigned index slot 3
        ///</summary>
        IX3 = P2ᐞ13,

        /// <summary>
        /// Classifies a register that has been assigned index slot 4
        ///</summary>
        IX4 = P2ᐞ14,

        /// <summary>
        /// Classifies a register that has been assigned index slot 5
        ///</summary>
        IX5 = P2ᐞ15,

        /// <summary>
        /// Classifies a register that has been assigned index slot 6
        ///</summary>
        IX6 = P2ᐞ16,

        /// <summary>
        /// Classifies a register that has been assigned index slot 7
        ///</summary>
        IX7 = P2ᐞ17,

        /// <summary>
        /// Classifies a register that has been assigned index slot 8
        ///</summary>
        IX8 = P2ᐞ18,

        /// <summary>
        /// Classifies a register that has been assigned index slot 9
        ///</summary>
        IX9 = P2ᐞ19,

        /// <summary>
        /// Classifies a register that has been assigned index slot 10
        ///</summary>
        IX10 = P2ᐞ20,

        /// <summary>
        /// Classifies a register that has been assigned index slot 11
        ///</summary>
        IX11 = P2ᐞ21,

        /// <summary>
        /// Classifies a register that has been assigned index slot 12
        ///</summary>
        IX12 = P2ᐞ22,

        /// <summary>
        /// Classifies a register that has been assigned index slot 13
        ///</summary>
        IX13 = P2ᐞ23,

        /// <summary>
        /// Classifies a register that has been assigned index slot 14
        ///</summary>
        IX14 = P2ᐞ24,

        /// <summary>
        /// Classifies a register that has been assigned index slot 15
        ///</summary>
        IX15 = P2ᐞ25,

        /// <summary>
        /// Classifies a register that has been assigned index slot 16
        ///</summary>
        IX16 = P2ᐞ26,

        /// <summary>
        /// Classifies a register that has been assigned index slot 17
        ///</summary>
        IX17 = P2ᐞ27,

        /// <summary>
        /// Classifies a register that has been assigned index slot 18
        ///</summary>
        IX18 = P2ᐞ28,

        /// <summary>
        /// Classifies a register that has been assigned index slot 19
        ///</summary>
        IX19 = P2ᐞ29,

        /// <summary>
        /// Classifies a register that has been assigned index slot 20
        ///</summary>
        IX20 = P2ᐞ30,

        /// <summary>
        /// Classifies a register that has been assigned index slot 21
        ///</summary>
        IX21 = P2ᐞ31,

        /// <summary>
        /// Classifies a register that has been assigned index slot 22
        ///</summary>
        IX22 = P2ᐞ32,

        /// <summary>
        /// Classifies a register that has been assigned index slot 23
        ///</summary>
        IX23 = P2ᐞ33,

        /// <summary>
        /// Classifies a register that has been assigned index slot 24
        ///</summary>
        IX24 = P2ᐞ34,

        /// <summary>
        /// Classifies a register that has been assigned index slot 25
        ///</summary>
        IX25 = P2ᐞ35,

        /// <summary>
        /// Classifies a register that has been assigned index slot 26
        ///</summary>
        IX26 = P2ᐞ36,

        /// <summary>
        /// Classifies a register that has been assigned index slot 27
        ///</summary>
        IX27 = P2ᐞ37,

        /// <summary>
        /// Classifies a register that has been assigned index slot 28
        ///</summary>
        IX28 = P2ᐞ38,

        /// <summary>
        /// Classifies a register that has been assigned index slot 29
        ///</summary>
        IX29 = P2ᐞ39,

        /// <summary>
        /// Classifies a register that has been assigned index slot 30
        ///</summary>
        IX30 = P2ᐞ40,

        /// <summary>
        /// Classifies a register that has been assigned index slot 31
        ///</summary>
        IX31 = P2ᐞ41,

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