//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines a <see cref='PrimitiveKind'/> subset that corresponds to primal types that can be used as compile-time literals
    /// </summary>
    public enum LiteralKind : byte
    {
        None = 0,

        /// <summary>
        /// An alias for <see cref='PrimitiveKind.U1'/>
        /// </summary>
        U1 = PrimitiveKind.U1,

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

        /// <summary>
        /// An alias for <see cref='PrimitiveKind.F32'/>
        /// </summary>
        F32 = PrimitiveKind.F32,

        /// <summary>
        /// An alias for <see cref='PrimitiveKind.F64'/>
        /// </summary>
        F64 = PrimitiveKind.F64,

        /// <summary>
        /// An alias for <see cref='PrimitiveKind.F128'/>
        /// </summary>
        F128 = PrimitiveKind.F128,

        /// <summary>
        /// An alias for <see cref='PrimitiveKind.C16'/>
        /// </summary>
        C16 = PrimitiveKind.C16,

        /// <summary>
        /// An alias for <see cref='PrimitiveKind.String'/>
        /// </summary>
        String = PrimitiveKind.String,
    }
}