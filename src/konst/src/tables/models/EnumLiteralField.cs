//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using static Konst;

    /// <summary>
    /// Defines the fields into which a literal table is partitioned
    /// </summary>
    public enum EnumLiteralField : uint
    {   
        /// <summary>
        /// The defining type, such as an enum or a type that declares constant fields
        /// </summary>
        TypeName = 0 | (32 << WidthOffset),

        /// <summary>
        /// The declaration order of the literal relative to other literals in the same dataset
        /// </summary>
        Index = 1 | (12 << WidthOffset),

        /// <summary>
        /// The literal name
        /// </summary>
        Name = 2 | (32 << WidthOffset),

        /// <summary>
        /// The literal's value in base-16
        /// </summary>
        Hex = 3 | (10 << WidthOffset), 

        /// <summary>
        /// The literal's bitstring representation
        /// </summary>
        BitString = 4 | (32 << WidthOffset),

        /// <summary>
        ///  A description of the literal if it exist
        /// </summary>
        Description = 5 | (4 << WidthOffset)
    }
}