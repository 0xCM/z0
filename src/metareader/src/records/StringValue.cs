//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static MetaRecordKinds;

    partial class MetadataRecords
    {
        public enum StringValueField : byte
        {
            Sequence = 0,
            
            HeapSize = 1,

            Length = 2,

            Offset = 3,

            Value = 4,

            RecordFieldCount = 5,
        }

        public readonly struct StringValue : IMetadataRecord<StringValue,StringRecord,StringValueField>
        {
            public int Sequence {get;}

            public int HeapSize {get;}

            public int Length {get;}

            public int Offset {get;}

            public string Value {get;}

            public StringRecord Kind => default;

            [MethodImpl(Inline)]
            public StringValue(int Sequence, int HeapSize, int Offset, string Value)
            {
                this.Sequence = Sequence;
                this.HeapSize = HeapSize;
                this.Length = Value.Length;
                this.Offset = Offset;
                this.Value = Value;
            }
                                    
            public string Format()
                => MetaFormat.format(this);
        }
    }
}