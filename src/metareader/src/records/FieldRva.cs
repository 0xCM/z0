//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = FieldRvaRecordField;
    using W = FieldRvaFieldWidth;
    using R = PartRecords.FieldRvaRecord;

    public enum FieldRvaRecordField : ushort
    {
        Sequence,

        SigOffset,
        
        SigCode, 
        
        Rva
    }

    public enum FieldRvaFieldWidth : ushort
    {
        Sequence = 12,

        SigOffset = 12,

        SigCode = 24,

        Rva = 12,            
    }

    partial class PartRecords
    {        

        public static RecordFormatter<F,W> formatter(FieldRvaRecord spec)
            => Tabular.Formatter<F,W>();

        public static ref readonly RecordFormatter<F,W> format(in FieldRvaRecord src, in RecordFormatter<F,W> dst, bool eol = true)
        {            
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.SigOffset, src.SigOffset);
            dst.Delimit(F.SigCode, src.SigCode);
            dst.Delimit(F.Rva, src.Rva);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }        

        public readonly struct FieldRvaRecord : IPartRecord<F,R>
        {
            public int Sequence {get;}
            
            public Address32 SigOffset  {get;}
            
            public BinaryCode SigCode {get;}

            public Address32 Rva {get;}

            public PartRecordKind Kind 
                => PartRecordKind.FieldRva;

            [MethodImpl(Inline)]
            internal FieldRvaRecord(int Sequence, BlobRecord Signature, Address32 Rva)
            {
                this.Sequence = Sequence;
                this.SigOffset = Signature.Offset;
                this.SigCode = Signature.Value;
                this.Rva = Rva;
            }            

            public string Format()
                => format(this, formatter(this), false);

            public void Format(RecordFormatter<F,W> dst)
                => format(this,dst);
        }
    }
}
