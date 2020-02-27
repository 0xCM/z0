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
    /// Characterizes a field in a record
    /// </summary>
    public readonly struct RecordFieldSpec
    {
        [MethodImpl(Inline)]
        public static RecordFieldSpec Define(string FieldName, int Position, ByteSize Offset, string FieldType)
            => new RecordFieldSpec(FieldName, Position, Offset, FieldType);

        [MethodImpl(Inline)]
        public RecordFieldSpec(string FieldName, int Position, ByteSize Offset, string FieldType)
        {
            this.FieldName = FieldName;
            this.Position = Position;
            this.Offset = Offset;
            this.FieldType = FieldType;
        }

        public readonly string FieldName;

        public readonly int Position;
        
        public readonly ByteSize Offset;

        public readonly string FieldType;
    }
}