//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = FieldRecordField;
    using W = FieldRecordFieldWidth;
    using R = PartRecords.FieldRecord;

    public enum FieldRecordField : ushort
    {
        Sequence,

        Name,

        SigCode, 

        Attributes,
    }

    public enum FieldRecordFieldWidth : ushort
    {
        Sequence = 12,

        Name = 60,

        SigCode = 30,                       

        Attributes = 10,
    }

    partial class PartRecords
    {

        public static RecordFormatter<F,W> formatter(FieldRecord spec)
            => Tabular.Formatter<F,W>();

        public static ref readonly RecordFormatter<F,W> format(in FieldRecord src, in RecordFormatter<F,W> dst, bool eol = true)
        {            
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.SigCode, src.SigCode);
            dst.Delimit(F.Attributes, src.Attributes);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }        

        public readonly struct FieldRecord : IPartRecord<F,R>
        {
            public int Sequence {get;}

            public string Name {get;}
            
            public BinaryCode SigCode {get;}

            public string Attributes {get;}

            public PartRecordKind Kind 
                => PartRecordKind.Field;

            [MethodImpl(Inline)]
            public FieldRecord(int Sequence, LiteralRecord Name, BlobRecord SigCode, string Attributes)
            {
                this.Sequence = Sequence;
                this.Name = Name.Value;
                this.SigCode = SigCode.Value;
                this.Attributes = Attributes;
            }            

            public string Format()
                => format(this, formatter(this), false);

            public void Format(RecordFormatter<F,W> dst)
                => format(this,dst);
        }
    }
}