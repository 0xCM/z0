//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using W = RecordFields;

    /// <summary>
    /// Defines the fields into which a literal table is partitioned
    /// </summary>
    public enum LiteralTableField : uint
    {   
        /// <summary>
        /// The defining type, such as an enum or a type that declares constant fields
        /// </summary>
        TypeName = 0 | (32 << W.WidthOffset),

        /// <summary>
        /// The declaration order of the literal relative to other literals in the same dataset
        /// </summary>
        Index = 1 | (12 << W.WidthOffset),

        /// <summary>
        /// The literal name
        /// </summary>
        Name = 2 | (32 << W.WidthOffset),

        /// <summary>
        /// The literal's value in base-16
        /// </summary>
        Hex = 3 | (10 << W.WidthOffset), 

        /// <summary>
        /// The literal's bitstring representation
        /// </summary>
        BitString = 4 | (32 << W.WidthOffset),

        /// <summary>
        ///  A description of the literal if it exist
        /// </summary>
        Description = 5 | (4 << W.WidthOffset)
    }
}