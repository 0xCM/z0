//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using W = LiteralFieldWidth;
    using I = LiteralFieldId;

    /// <summary>
    /// Defines the fields into which a literal table is partitioned
    /// </summary>
    public enum LiteralTableField : int
    {   
        /// <summary>
        /// The defining type, such as an enum or a type that declares constant fields
        /// </summary>
        TypeName = I.TypeName | (W.TypeName << W.Offset),

        /// <summary>
        /// The declaration order of the literal relative to other literals in the same dataset
        /// </summary>
        Index = I.Index | (W.Index << W.Offset),

        /// <summary>
        /// The literal name
        /// </summary>
        Name = I.Name | (W.Name << W.Offset),

        /// <summary>
        /// The literal's value in base-16
        /// </summary>
        Hex = I.Hex | (W.Hex << W.Offset), 

        /// <summary>
        /// The literal's bitstring representation
        /// </summary>
        BitString = I.BitString | (W.BitString << W.Offset),

        /// <summary>
        ///  A description of the literal if it exist
        /// </summary>
        Description = I.Description | (W.Description << W.Offset)
    }
}