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

        Signature, 

        Attributes,
    }

    public enum FieldRecordFieldWidth : ushort
    {
        Sequence = 12,

        Name = 60,

        Signature = 30,                       

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
            dst.Delimit(F.Signature, src.Signature);
            dst.Delimit(F.Attributes, src.Attributes);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }        

        public readonly struct FieldRecord
        {
            public int Sequence {get;}

            public string Name {get;}
            
            public BinaryCode Signature {get;}

            public string Attributes {get;}

            [MethodImpl(Inline)]
            public FieldRecord(int Sequence, LiteralFieldRecord Name, BlobRecord SigCode, string Attributes)
            {
                this.Sequence = Sequence;
                this.Name = Name.Value;
                this.Signature = SigCode.Value;
                this.Attributes = Attributes;
            }            

            public string Format()
                => format(this, formatter(this), false);

            public void Format(RecordFormatter<F,W> dst)
                => format(this,dst);
        }
    }
}