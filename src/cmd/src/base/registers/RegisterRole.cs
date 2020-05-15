//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using I = RegisterIndex;

    [Flags]
    public enum RegisterRole : ulong
    {
        /// <summary>
        /// Classifies a null register
        ///</summary>
        None = 0,

        /// <summary>
        /// Classifies a general-purpose register
        ///</summary>
        GP = I.Max << 1,

        /// <summary>
        /// Classifies a segment register
        ///</summary>
        Seg = I.Max << 2,

        /// <summary>
        /// Classifies a vector register
        ///</summary>
        Vec  = I.Max << 3,

        /// <summary>
        /// The join of all role classifiers
        ///</summary>
        All = GP | Seg | Vec,
    }
}