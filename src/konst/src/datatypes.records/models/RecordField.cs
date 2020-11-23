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
    public struct RecordField : IRecordField
    {
        /// <summary>
        /// The defining type
        /// </summary>
        public Type RecordType;

        /// <summary>
        /// The 0-based, declaration order of the field
        /// </summary>
        public ushort FieldIndex;

        /// <summary>
        /// The clr metdata token
        /// </summary>
        public ClrArtifactKey FieldKey;

        public Type DataType;

        public ByteSize Size;

        public ushort RenderWidth;

        public FieldInfo Definition;

        public string Name
        {
            [MethodImpl(Inline)]
            get => Definition.Name;
        }

        Type IRecordField.RecordType
            => RecordType;

        ushort IRecordField.FieldIndex
            => FieldIndex;

        string IRecordField.FieldName
            => Name;

        Type IRecordField.FieldType
            => DataType;

        ByteSize IRecordField.FieldSize
            => Size;

        ClrArtifactKey IRecordField.FieldKey
            => FieldKey;
    }
}