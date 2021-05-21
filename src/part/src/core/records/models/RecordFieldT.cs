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
    /// Describes a column in a table
    /// </summary>
    public struct RecordField<T>
        where T : struct
    {
        /// <summary>
        /// The defining field
        /// </summary>
        public ClrField Definition;

        /// <summary>
        /// The 0-based, declaration order of the field
        /// </summary>
        public ushort FieldIndex;

        /// <summary>
        /// The field name
        /// </summary>
        public string Name
        {
            [MethodImpl(Inline)]
            get => Definition.Name;
        }

        /// <summary>
        /// The field datatype
        /// </summary>
        public ClrType DataType
        {
            [MethodImpl(Inline)]
            get => Definition.FieldType;
        }

        /// <summary>
        /// The declaring record type
        /// </summary>
        public ClrType RecordType
        {
            [MethodImpl(Inline)]
            get => Definition.DeclaringType;
        }

        [MethodImpl(Inline)]
        public static implicit operator RecordField(RecordField<T> src)
            => new RecordField(src.FieldIndex, src.Definition);

        [MethodImpl(Inline)]
        public static implicit operator RecordField<T>(RecordField src)
        {
            var dst = new RecordField<T>();
            dst.Definition = src.Definition;
            dst.FieldIndex = src.FieldIndex;
            return dst;
        }

    }
}