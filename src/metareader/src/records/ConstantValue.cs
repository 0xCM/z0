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
    using static PartRecords;

    using F = PartRecords.ConstantField;
    using W = PartRecords.ConstantFieldWidth;

    public struct ConstantRecord
    {            
        public int Sequence;

        public int ParentId;
        
        public string Source;

        public ConstantTypeCode DataType;

        public BinaryCode Value;    

        [MethodImpl(Inline)]
        public ConstantRecord(int Sequence, HandleInfo Parent, ConstantTypeCode type, BinaryCode value)
        {
            this.Sequence = Sequence;
            this.ParentId = Parent.Token;
            this.Source = Parent.Source.ToString();
            this.DataType = type;
            this.Value = value;
        }            

        public string Format()
            => format(this, formatter(this), false);

        public void Format(RecordFormatter<F,W> dst)
            => format(this,dst);
    }
    
    partial class PartRecords
    {
        public enum ConstantField : ushort
        {
            Sequence = 0,

            ParentId = 1,

            Source = 2,

            DataType = 3,

            Value = 4,
        }

        public enum ConstantFieldWidth : ushort
        {
            Sequence = 12,

            ParentId = 20,

            Source = 20,

            DataType = 20,

            Value = 30,            
        }

        public static RecordFormatter<F,W> formatter(ConstantRecord spec)
            => Tabular.Formatter<F,W>();

        public static ref readonly RecordFormatter<F,W> format(in ConstantRecord src, in RecordFormatter<F,W> dst, bool eol = true)
        {            
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.ParentId, src.ParentId);
            dst.Delimit(F.Source, src.Source);
            dst.Delimit(F.DataType, src.DataType);
            dst.Delimit(F.Value, src.Value);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }        
    }
}