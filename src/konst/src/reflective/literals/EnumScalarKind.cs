//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using PN = PrimalNumericKind;

    /// <summary>
    /// Restricts the numeric kind classifier to reflect the numeric kinds
    /// that an Enum type may refine
    /// </summary>
    public enum EnumScalarKind : byte
    {
        None = 0,

        /// <summary>
        /// Specifies an enum type refines an unsigned 8-bit integer
        /// </summary>
        U8 = PN.U8,

        /// <summary>
        /// Specifies an enum type refines an unsigned 16-bit integer
        /// </summary>
        U16 = PN.U16,

        /// <summary>
        /// Specifies an enum type refines an unsigned 32-bit integer
        /// </summary>
        U32 = PN.U32,

        /// <summary>
        /// Specifies an enum type refines an unsigned 64-bit integer
        /// </summary>
        U64 = PN.U64,

        /// <summary>
        /// Specifies an enum type refines a signed 8-bit integer
        /// </summary>
        I8 = PN.I8,

        /// <summary>
        /// Specifies an enum type refines a signed 16-bit integer
        /// </summary>
        I16 = PN.I16,

        /// <summary>
        /// Specifies an enum type refines a signed 32-bit integer
        /// </summary>
        I32 = PN.I32,

        /// <summary>
        /// Specifies an enum type refines a signed 64-bit integer
        /// </summary>
        I64 = PN.I64,

        WidthMask = PN.WidthMask,

        SignMask = PN.SignMask,
    }
}