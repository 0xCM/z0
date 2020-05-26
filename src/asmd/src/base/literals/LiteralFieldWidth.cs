//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum LiteralFieldWidth
    {
        /// <summary>
        /// The defining type, such as an enum or a type that declares constant fields
        /// </summary>
        TypeName = 32,

        /// <summary>
        /// The declaration order of the literal relative to other literals in the same dataset
        /// </summary>
        Index = 8,

        /// <summary>
        /// The literal name
        /// </summary>
        Name = 32,

        /// <summary>
        /// The literal's value in base-16
        /// </summary>
        Hex = 10,

        /// <summary>
        /// The literal's bitstring representation
        /// </summary>
        BitString = 32,

        /// <summary>
        ///  A description of the literal if it exist
        /// </summary>
        Description = 4,

        Offset = 16,
    }
}