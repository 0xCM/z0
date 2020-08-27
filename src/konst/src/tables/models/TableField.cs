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

    public struct TableField : ITableField
    {
        public ushort Index;

        public Type TableType;

        public StringRef FieldName;

        public Address64 FieldOffset;

        public Address16 FieldId;

        public Type DataType;

        public ByteSize FieldSize;

        public RenderWidth<ushort> RenderWidth;

        public string Name
        {
            [MethodImpl(Inline)]
            get => FieldName;
        }

        public FieldInfo Definition;

        Type ITableField.TableType
            => TableType;

        StringRef ITableField.FieldName
            => FieldName;

        Type ITableField.DataType
            => DataType;

        ByteSize ITableField.FieldSize
            => FieldSize;

        RenderWidth<ushort> ITableField.RenderWidth
            => RenderWidth;
    }
}