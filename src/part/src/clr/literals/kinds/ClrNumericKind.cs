//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using PK = ClrPrimalKind;

    /// <summary>
    /// Defines a <see cref='ClrPrimalKind'/> subset that corresponds to primal numeric kinds
    /// </summary>
    public enum ClrNumericKind : byte
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

        /// <summary>
        /// An alias for <see cref='ClrPrimalKind.F32'/>
        /// </summary>
        F32 = ClrPrimalKind.F32,

        /// <summary>
        /// An alias for <see cref='ClrPrimalKind.F64'/>
        /// </summary>
        F64 = ClrPrimalKind.F64,

        /// <summary>
        /// An alias for <see cref='ClrPrimalKind.F128'/>
        /// </summary>
        F128 = ClrPrimalKind.F128,
    }
}