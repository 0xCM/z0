//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;
    using static Tabular;

    /// <summary>
    /// Defines the fields into which a literal table is partitioned
    /// </summary>
    public enum LiteralTableField : ulong
    {   
        /// <summary>
        /// The defining type, such as an enum or a type that declares constant fields
        /// </summary>
        TypeName = 0 | (32ul << WidthOffset),

        /// <summary>
        /// The declaration order of the literal relative to other literals in the same dataset
        /// </summary>
        Index = 1 | (8ul << WidthOffset),

        /// <summary>
        /// The literal name
        /// </summary>
        Name = 2 | (16ul << WidthOffset),

        /// <summary>
        /// The literal value
        /// </summary>
        Value = 3 | (8ul << WidthOffset),

        /// <summary>
        ///  A description of the literal if it exist
        /// </summary>
        Description = 4
    }
}