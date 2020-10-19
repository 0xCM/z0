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

    /// <summary>
    /// Describes a column in a table
    /// </summary>
    public struct TableField : ITableField
    {
        /// <summary>
        /// The defining type
        /// </summary>
        public Type TableType;

        /// <summary>
        /// The 0-based, declaration order of the field
        /// </summary>
        public ushort Index;

        public Address16 Id;

        public Address64 Offset;

        public Type DataType;

        public ByteSize Size;

        public ushort RenderWidth;

        public FieldInfo Definition;

        public string Name
        {
            [MethodImpl(Inline)]
            get => Definition.Name;
        }

        Type ITableField.TableType
            => TableType;

        string ITableField.FieldName
            => Name;

        Type ITableField.DataType
            => DataType;

        ByteSize ITableField.FieldSize
            => Size;

        RenderWidth<ushort> ITableField.RenderWidth
            => RenderWidth;
    }
}