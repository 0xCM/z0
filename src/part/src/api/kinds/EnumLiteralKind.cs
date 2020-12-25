//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using PK = PrimalKind;

    /// <summary>
    /// Restricts the numeric kind classifier to reflect the numeric kinds
    /// that an Enum type may refine
    /// </summary>
    public enum EnumLiteralKind : byte
    {
        None = 0,

        /// <summary>
        /// An alias for <see cref='PK.U8'/>
        /// </summary>
        U8 = PK.U8,

        /// <summary>
        /// An alias for <see cref='PK.U16'/>
        /// </summary>
        U16 = PK.U16,

        /// <summary>
        /// An alias for <see cref='PK.U32'/>
        /// </summary>
        U32 = PK.U32,

        /// <summary>
        /// An alias for <see cref='PK.U64'/>
        /// </summary>
        U64 = PK.U64,

        /// <summary>
        /// An alias for <see cref='PK.I8'/>
        /// </summary>
        I8 = PK.I8,

        /// <summary>
        /// An alias for <see cref='PK.I16'/>
        /// </summary>
        I16 = PK.I16,

        /// <summary>
        /// An alias for <see cref='PK.I32'/>
        /// </summary>
        I32 =  PK.I32,

        /// <summary>
        /// An alias for <see cref='PK.I64'/>
        /// </summary>
        I64 = PK.I64,
    }
}