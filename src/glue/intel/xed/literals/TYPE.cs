//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        /// <summary>
        /// datafiles/xed-operand-element-type-enum-base.txt
        /// </summary>
        public enum TYPE : byte
        {
            /// <summary>
            /// Unspecified/unknown
            /// </summary>
            INVALID,

            /// <summary>
            /// Unsigned integer
            /// </summary>
            UINT,

            /// <summary>
            /// Signed integer
            /// </summary>
            INT,

            /// <summary>
            /// 32b FP single precision
            /// </summary>
            SINGLE,

            /// <summary>
            /// 64b FP double precision
            /// </summary>
            DOUBLE,

            /// <summary>
            /// 80b FP x87
            /// </summary>
            LONGDOUBLE,

            /// <summary>
            /// 80b decimal BCD
            /// </summary>
            LONGBCD,

            /// <summary>
            /// a structure of various fields
            /// </summary>
            STRUCT,

            /// <summary>
            /// depends on other fields in the instruction
            /// </summary>
            VARIABLE,
        }
    }
}