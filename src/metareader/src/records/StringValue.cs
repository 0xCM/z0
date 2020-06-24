//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = StringValueField;
    using W = StringValueWidths;
    using R = PartRecords.StringValueRecord;

    public enum StringValueField : ushort
    {
        Sequence = 0,
        
        HeapSize = 1,

        Length = 2,

        Offset = 3,

        Value = 4,
        
    }

    public enum StringValueWidths : ushort
    {
        Sequence = 12,
        
        HeapSize = 12,

        Length = 12,

        Offset = 12,

        Value = 12,            
    }

    partial class PartRecords
    {

        public static RecordFormatter<F,W> formatter(StringValueRecord spec)
            => Tabular.Formatter<F,W>();

        [Op]
        public static ref readonly RecordFormatter<F,W> format(in StringValueRecord src, in RecordFormatter<F,W> dst, bool eol = true)
        {            
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.HeapSize, src.HeapSize);
            dst.Delimit(F.Length, src.Length);
            dst.Delimit(F.Offset, src.Offset);
            dst.Delimit(F.Value, src.Value);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }

        public readonly struct StringValueRecord : IPartRecord<F,R>
        {            
            public int Sequence {get;}

            public int HeapSize {get;}

            public int Length {get;}

            public int Offset {get;}

            public string Value {get;}

            public PartRecordKind Kind => PartRecordKind.String;

            [MethodImpl(Inline)]
            public StringValueRecord(int Sequence, int HeapSize, int Offset, string Value)
            {
                this.Sequence = Sequence;
                this.HeapSize = HeapSize;
                this.Length = Value.Length;
                this.Offset = Offset;
                this.Value = Value;
            }                     

            public string Format()
                => format(this, formatter(this), false);

            public void Format(RecordFormatter<F,W> dst)
                => format(this,dst);            
        }
    }
}