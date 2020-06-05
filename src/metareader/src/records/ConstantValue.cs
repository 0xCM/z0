//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Seed;
    using static MetaRecordKinds;
    
    partial class MetadataRecords
    {
        public enum ConstantField : byte
        {
            Sequence = 0,

            Parent = 1,

            DataType = 2,

            Value = 3,

            RecordFieldCount = 4,
        }
        
        public readonly struct ConstantValue : IMetadataRecord<ConstantValue,ConstantValueRecord,ConstantField>
        {            
            public int Sequence {get;}

            public string Parent {get;}

            public ConstantTypeCode DataType {get;}

            public BlobValue Value {get;}

            public ConstantValueRecord Kind => default;

            [MethodImpl(Inline)]
            internal ConstantValue(int Sequence, string Parent, ConstantTypeCode Type, BlobValue Value)
            {
                this.Sequence = Sequence;
                this.Parent = Parent;
                this.DataType = Type;
                this.Value = Value;
            }            

            public string Format()
                => MetaFormat.format(this);
        }
    }
}