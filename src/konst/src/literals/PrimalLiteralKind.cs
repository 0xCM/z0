//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = PrimalKind;

    /// <summary>
    /// Classifies system types for which field literals can be defined
    /// </summary>    
    public enum PrimalLiteralKind : byte
    {
        None = 0,

        /// <summary>
        /// Specifies a boolean value
        /// </summary>
        U1 = K.U1,

        /// <summary>
        /// Specifies a signed 8-bit integer
        /// </summary>
        I8 = K.I8,

        /// <summary>
        /// Specifies an unsigned 8-bit integer
        /// </summary>
        U8 = K.U8,

        /// <summary>
        /// Specifies a signed 16-bit integer
        /// </summary>
        I16 = K.I16,

        /// <summary>
        /// Specifies a 16-bit unicode character
        /// </summary>
        C16 = K.C16,

        /// <summary>
        /// Specifies an unsigned 16-bit integer
        /// </summary>
        U16 = K.U16,

        /// <summary>
        /// Specifies a signed 32-bit integer
        /// </summary>
        I32 = K.I32,

        /// <summary>
        /// Specifies an unsigned 32-bit integer
        /// </summary>
        U32 = K.U32,

        /// <summary>
        /// Specifies an unsigned 64-bit integer
        /// </summary>
        U64  = K.U64,

        /// <summary>
        /// Specifies a signed 64-bit integer
        /// </summary>
        I64 = K.I64,

        /// <summary>
        /// Specifies a signed 32-bit floating-point number
        /// </summary>
        F32 = K.F32,

        /// <summary>
        /// Specifies a signed 64-bit floating-point number
        /// </summary>
        F64  = K.F64,
        
        /// <summary>
        /// Specifies a signed 64-bit floating-point number
        /// </summary>
        F128  = K.F128,

        /// <summary>
        /// Specifies a 16-bit unicode character
        /// </summary>
        String = K.String,
    }
}