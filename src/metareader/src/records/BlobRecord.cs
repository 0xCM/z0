//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = BlobField;
    using W = BlobFieldWidth;
    using R = PartRecords.BlobRecord;

    public enum BlobField : ushort
    {
        Sequence = 0,

        HeapSize = 1,

        Offset = 2,

        Value = 3,                    
    }

    public enum BlobFieldWidth : ushort
    {
        Sequence = 12,

        HeapSize = 12,

        Offset = 12,

        Value = 30,                       
    }

    partial class PartRecords
    {
        public static RecordFormatter<F,W> formatter(BlobRecord spec)
            => Tabular.Formatter<F,W>();

        public static DatasetSink<F,BlobRecord> sink(BlobRecord spec)
        {
            var formatter = Tabular.Formatter<F,W>();
            formatter.EmitHeader();
            return new DatasetSink<F,BlobRecord>(formatter, deposit);
        }

        public static void deposit(in BlobRecord src, IDatasetFormatter<BlobField> dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.HeapSize, src.HeapSize);
            dst.Delimit(F.Offset, src.Offset);
            dst.Delimit(F.Value, src.Value);
            dst.EmitEol();            
        }
        
        public static ref readonly RecordFormatter<F,W> format(in BlobRecord src, in RecordFormatter<F,W> dst, bool eol = true)
        {            
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.HeapSize, src.HeapSize);
            dst.Delimit(F.Offset, src.Offset);
            dst.Delimit(F.Value, src.Value);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }        

        public readonly struct BlobRecord : IPartRecord<F,R>
        {
            public int Sequence {get;}
            
            public int HeapSize {get;}

            public Address32 Offset {get;}
            
            public BinaryCode Value {get;}

            public PartRecordKind Kind 
                => PartRecordKind.Blob;

            [MethodImpl(Inline)]
            public BlobRecord(int Sequence, int HeapSize, int Offset, byte[] Value)
            {
                this.Sequence = Sequence;
                this.HeapSize = HeapSize;
                this.Offset = (uint)Offset;
                this.Value = Value;
            }

            public string Format()
                => format(this, formatter(this), false);

            public void Format(RecordFormatter<F,W> dst)
                => format(this,dst);

        }
    
    }
}