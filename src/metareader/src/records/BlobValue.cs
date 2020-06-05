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
        public enum BlobField : byte
        {
            Sequence = 0,

            HeapSize = 1,

            Offset = 2,

            Value = 3,

            RecordFieldCount = 4,            
        }

        public readonly struct BlobValue : IMetadataRecord<BlobValue,BlobRecord, BlobField>
        {

            public int HeapSize {get;}

            public int Offset {get;}
            
            public byte[] Value {get;}

            public BlobRecord Kind => default;

            [MethodImpl(Inline)]
            public BlobValue(int HeapSize, int Offset, byte[] Value)
            {
                this.HeapSize = HeapSize;
                this.Offset = Offset;
                this.Value = Value;
            }

            public string Format()
            {
                var dst = text.build();
                dst.Append(HeapSize.FormatHex(zpad:false, specifier:false).PadRight(8));
                dst.Append(Delimiter);
                dst.Append(Offset.FormatHex(zpad:false, specifier:false).PadRight(6));
                dst.Append(Delimiter);
                dst.Append(Value.FormatHexBytes());

                return dst.ToString();
            }
        }
    }
}