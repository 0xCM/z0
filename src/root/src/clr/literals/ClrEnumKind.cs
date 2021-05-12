//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using PK = ClrPrimalKind;

    /// <summary>
    /// Restricts the numeric kind classifier to reflect the numeric kinds
    /// that an Enum type may refine
    /// </summary>
    public enum ClrEnumKind : byte
    {
        None = 0,

        /// <summary>
        /// An alias for <see cref='ClrPrimalKind.U8'/>
        /// </summary>
        U8 = ClrPrimalKind.U8,

        /// <summary>
        /// An alias for <see cref='ClrPrimalKind.U16'/>
        /// </summary>
        U16 = ClrPrimalKind.U16,

        /// <summary>
        /// An alias for <see cref='ClrPrimalKind.U32'/>
        /// </summary>
        U32 = ClrPrimalKind.U32,

        /// <summary>
        /// An alias for <see cref='ClrPrimalKind.U64'/>
        /// </summary>
        U64 = ClrPrimalKind.U64,

        /// <summary>
        /// An alias for <see cref='ClrPrimalKind.I8'/>
        /// </summary>
        I8 = ClrPrimalKind.I8,

        /// <summary>
        /// An alias for <see cref='ClrPrimalKind.I16'/>
        /// </summary>
        I16 = ClrPrimalKind.I16,

        /// <summary>
        /// An alias for <see cref='ClrPrimalKind.I32'/>
        /// </summary>
        I32 = ClrPrimalKind.I32,

        /// <summary>
        /// An alias for <see cref='ClrPrimalKind.I64'/>
        /// </summary>
        I64 = ClrPrimalKind.I64,
    }
}