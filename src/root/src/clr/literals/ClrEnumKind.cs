//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Restricts the numeric kind classifier to reflect the numeric kinds
    /// that an Enum type may refine
    /// </summary>
    public enum ClrEnumKind : byte
    {
        None = 0,

        /// <summary>
        /// An alias for <see cref='PrimitiveKind.U8'/>
        /// </summary>
        U8 = PrimitiveKind.U8,

        /// <summary>
        /// An alias for <see cref='PrimitiveKind.U16'/>
        /// </summary>
        U16 = PrimitiveKind.U16,

        /// <summary>
        /// An alias for <see cref='PrimitiveKind.U32'/>
        /// </summary>
        U32 = PrimitiveKind.U32,

        /// <summary>
        /// An alias for <see cref='PrimitiveKind.U64'/>
        /// </summary>
        U64 = PrimitiveKind.U64,

        /// <summary>
        /// An alias for <see cref='PrimitiveKind.I8'/>
        /// </summary>
        I8 = PrimitiveKind.I8,

        /// <summary>
        /// An alias for <see cref='PrimitiveKind.I16'/>
        /// </summary>
        I16 = PrimitiveKind.I16,

        /// <summary>
        /// An alias for <see cref='PrimitiveKind.I32'/>
        /// </summary>
        I32 = PrimitiveKind.I32,

        /// <summary>
        /// An alias for <see cref='PrimitiveKind.I64'/>
        /// </summary>
        I64 = PrimitiveKind.I64,
    }
}