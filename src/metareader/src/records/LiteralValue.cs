//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = PartRecords.LiteralField;
    using W = PartRecords.LiteralFieldWidth;
    using R = PartRecords.LiteralFieldRecord;

    partial class PartRecords
    {
        public enum LiteralField : ushort
        {
            Sequence = 0,
            
            HeapSize = 1,

            Length = 2,

            Offset = 3,

            Value = 4,
        }

        public enum LiteralFieldWidth : ushort
        {
            Sequence = 12,
            
            HeapSize = 12,

            Length = 12,

            Offset = 12,

            Value = 30,

        }

        public static RecordFormatter<F,W> formatter(LiteralFieldRecord spec)
            => Tabular.Formatter<F,W>();

        public static ref readonly RecordFormatter<F,W> format(in LiteralFieldRecord src, in RecordFormatter<F,W> dst, bool eol = true)
        {            
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.HeapSize, hex(src.HeapSize));
            dst.Delimit(F.Length, src.Length);
            dst.Delimit(F.Offset, src.Offset);
            dst.Delimit(F.Value, src.Value);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }        

        public readonly struct LiteralFieldRecord : IPartRecord<F,R>
        {
            public int Sequence {get;}

            public int HeapSize {get;}

            public int Length {get;}
            
            public Address32 Offset {get;}
            
            public string Value {get;}

            public PartRecordKind Kind 
                => PartRecordKind.Literal;

            [MethodImpl(Inline)]
            public LiteralFieldRecord(int Sequence, int HeapSize, int Offset, string Value)
            {
                this.Sequence = Sequence;
                this.HeapSize = HeapSize;
                this.Length = Value.Length;
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