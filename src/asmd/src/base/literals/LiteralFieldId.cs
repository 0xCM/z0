//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines the fields into which a literal table is partitioned
    /// </summary>
    public enum LiteralFieldId : int
    {   
        /// <summary>
        /// The defining type, such as an enum or a type that declares constant fields
        /// </summary>
        TypeName,

        /// <summary>
        /// The declaration order of the literal relative to other literals in the same dataset
        /// </summary>
        Index,

        /// <summary>
        /// The literal name
        /// </summary>
        Name,

        /// <summary>
        /// The literal's value in base-16
        /// </summary>
        Hex,

        /// <summary>
        /// The literal's bitstring representation
        /// </summary>
        BitString,

        /// <summary>
        ///  A description of the literal if it exist
        /// </summary>
        Description
    }

}