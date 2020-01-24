//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    /// <summary>
    /// Characterizes a record field
    /// </summary>
    public class RecordField
    {
        public RecordField(string FieldName, int Position, ByteSize Offset, string FieldType)
        {
            this.FieldName = FieldName;
            this.Position = Position;
            this.Offset = Offset;
            this.FieldType = FieldType;
        }

        public string FieldName {get;}

        public int Position {get;}
        
        public ByteSize Offset {get;}

        public string FieldType {get;}        
    }
}