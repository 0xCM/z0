//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a field
    /// </summary>
    public readonly struct FieldSpec
    {
        /// <summary>
        /// The field's name
        /// </summary>
        public readonly Name FieldName;

        /// <summary>
        /// The assembly-qualified name of the field data type
        /// </summary>
        public readonly ClrTypeName TypeName;

        /// <summary>
        /// The position of the field within the declaring type
        /// </summary>
        public readonly ushort Position;

        /// <summary>
        /// The 0-based offset address of the field
        /// </summary>
        public readonly Address16? Offset;

        [MethodImpl(Inline)]
        public FieldSpec(Name name, ClrTypeName type, ushort pos, Address16? offset = null)
        {
            TypeName = type;
            FieldName = name;
            Position = pos;
            Offset = offset;
        }
    }
}