//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    public enum SignatureTypeKind : byte
    {
        /// <summary>
        /// It is not known in the current context if the type reference or definition is a class or value type.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The type definition or reference refers to a class.
        /// </summary>
        Class = CorElementType.ELEMENT_TYPE_CLASS,

        /// <summary>
        /// The type definition or reference refers to a value type.
        /// </summary>
        ValueType = CorElementType.ELEMENT_TYPE_VALUETYPE,
    }
}