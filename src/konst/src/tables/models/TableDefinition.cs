//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;


    public readonly struct TableDefinition
    {
        public readonly Type TableType;

        readonly TableFieldIndex _Fields;

        [MethodImpl(Inline)]
        internal TableDefinition(Type type, TableFieldIndex fields)
        {
            TableType = type;
            _Fields = fields;
        }

        public Span<TableField> Fields
        {
            [MethodImpl(Inline)]
            get => _Fields.Edit;
        }

        public ref TableField this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref Field(index);
        }

        [MethodImpl(Inline)]
        public ref ushort RenderWidth(ushort field)
            => ref Field(field).RenderWidth;

        [MethodImpl(Inline)]
        public ref TableField Field(ushort index)
            => ref _Fields[index];

        public uint FieldCount
        {
            [MethodImpl(Inline)]
            get => _Fields.Count;
        }
    }
}