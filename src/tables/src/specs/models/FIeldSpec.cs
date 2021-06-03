//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a field
    /// </summary>
    public readonly struct FieldSpec
    {
        /// <summary>
        /// The field's name
        /// </summary>
        public Name FieldName {get;}

        /// <summary>
        /// The name of the field data type
        /// </summary>
        public Name DataType {get;}

        /// <summary>
        /// The field's declearation order within the declaring type
        /// </summary>
        public ushort Position {get;}

        /// <summary>
        /// The 0-based offset address of the field in the context of a type with explicit layout; otherwise ignored
        /// </summary>
        public ushort Offset {get;}

        [MethodImpl(Inline)]
        public FieldSpec(Name field, Name type, ushort pos, ushort offset = default)
        {
            FieldName = field;
            DataType = type;
            Position = pos;
            Offset = offset;
        }

        public string Format()
            => RecordBuilder.format(this);

        public override string ToString()
            => Format();
    }
}