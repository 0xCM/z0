//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = CilTables;

    /// <summary>
    /// Defines a field
    /// </summary>
    public readonly struct CilFieldSpec
    {
        /// <summary>
        /// The field's name
        /// </summary>
        public readonly ClrMemberName FieldName;

        /// <summary>
        /// The assembly-qualified name of the field data type
        /// </summary>
        public readonly ClrTypeName TypeName;

        /// <summary>
        /// The field's declearation order within the declaring type
        /// </summary>
        public readonly ushort Position;

        /// <summary>
        /// The 0-based offset address of the field in the context of a type with explicit layout; otherwise ignored
        /// </summary>
        public readonly Address16 Offset;

        [MethodImpl(Inline)]
        public CilFieldSpec(ClrMemberName name, ClrTypeName type, ushort pos, Address16 offset = default)
        {
            TypeName = type;
            FieldName = name;
            Position = pos;
            Offset = offset;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}