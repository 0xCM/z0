//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Collections.Immutable;

    /// <summary>
    /// Specified additional flags that can be applied to method signatures.
    /// Underlying values correspond to the representation in the leading signature
    /// byte represented by <see cref="SignatureHeader"/>.
    /// </summary>
    [Flags]
    public enum SignatureAttributes : byte
    {
        /// <summary>
        /// No flags.
        /// </summary>
        None = 0x00,

        /// <summary>
        /// Generic method.
        /// </summary>
        Generic = 0x10,

        /// <summary>
        /// Instance method.
        /// </summary>
        /// <remarks>Ecma 335 CLI Specification refers to this flag as HAS_THIS.</remarks>
        Instance = 0x20,

        /// <summary>
        /// The first explicitly declared parameter represents the instance pointer.
        /// </summary>
        ExplicitThis = 0x40,
    }        

}