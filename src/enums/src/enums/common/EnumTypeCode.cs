//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using TC = System.TypeCode;

    /// <summary>
    /// Defines type-code equivalent identifiers for valid numeric enumeration types
    /// </summary>
    public enum EnumTypeCode : byte
    {
        None = 0,

        /// <summary>
        /// Specifies an enum type refines a signed 8-bit integer
        /// </summary>
        I8 = TC.SByte,

        /// <summary>
        /// Specifies an enum type refines an unsigned 8-bit integer
        /// </summary>
        U8 = TC.Byte,

        /// <summary>
        /// Specifies an enum type refines a signed 16-bit integer
        /// </summary>
        I16 = TC.Int16,

        /// <summary>
        /// Specifies an enum type refines an unsigned 16-bit integer
        /// </summary>
        U16 = TC.UInt16,

        /// <summary>
        /// Specifies an enum type refines a signed 32-bit integer
        /// </summary>
        I32 = TC.Int32,

        /// <summary>
        /// Specifies an enum type refines an unsigned 32-bit integer
        /// </summary>
        U32 = TC.UInt32,

        /// <summary>
        /// Specifies an enum type refines a signed 64-bit integer
        /// </summary>
        I64 = TC.Int64,

        /// <summary>
        /// Specifies an enum type refines an unsigned 64-bit integer
        /// </summary>
        U64 = TC.UInt64
    }
}