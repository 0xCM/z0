//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Konst;

    using F = PartRecords.ConstantField;
    using W = PartRecords.ConstantFieldWidth;
    using R = PartRecords.ConstantRecord;

    partial class PartRecords
    {
        public enum ConstantField : ushort
        {
            Sequence = 0,

            Parent = 1,

            DataType = 2,

            HeapSize = 3,

            Offset = 4,

            Code = 5,
            
        }

        public enum ConstantFieldWidth : ushort
        {
            Sequence = 12,

            Parent = 20,

            DataType = 20,

            HeapSize = 12,

            Offset = 12,

            Code = 30,                       

        }

        public static RecordFormatter<F,W> formatter(ConstantRecord spec)
            => Tabular.Formatter<F,W>();

        public static ref readonly RecordFormatter<F,W> format(in ConstantRecord src, in RecordFormatter<F,W> dst, bool eol = true)
        {            
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Parent, src.Parent);
            dst.Delimit(F.DataType, src.DataType);
            dst.Delimit(F.HeapSize, src.HeapSize);
            dst.Delimit(F.Offset, src.Offset);
            dst.Delimit(F.Code, src.Code);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }        

        public readonly struct ConstantRecord : IPartRecord<F,R>
        {            
            public int Sequence {get;}

            public string Parent {get;}

            public ConstantTypeCode DataType {get;}

            public int HeapSize {get;}

            public Address32 Offset {get;}
            
            public BinaryCode Code {get;}

            public PartRecordKind Kind 
                => PartRecordKind.Constant;

            [MethodImpl(Inline)]
            internal ConstantRecord(int Sequence, string Parent, ConstantTypeCode Type, BlobRecord data)
            {
                this.Sequence = Sequence;
                this.Parent = Parent;
                this.DataType = Type;
                this.HeapSize = data.HeapSize;
                this.Offset = data.Offset;
                this.Code =  data.Value;
            }            

            public string Format()
                => format(this, formatter(this), false);

            public void Format(RecordFormatter<F,W> dst)
                => format(this,dst);
        }
    }
}