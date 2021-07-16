//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Rules
    {
        /// <summary>
        /// Defines the basic cell kind
        /// </summary>
        public enum BasicTypeKind : sbyte
        {
            /// <summary>
            /// Indicates a type represents a signed integral value
            /// </summary>
            Signed = -1,

            /// <summary>
            /// Mystery kind
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// Indicates a type represents an unsigned integral value
            /// </summary>
            Unsigned = 1,

            /// <summary>
            /// Indicates a type represents a floating-point value
            /// </summary>
            Float = 2,
        }
    }
}