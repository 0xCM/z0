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

    using static PartRecords;

    public enum StringSource : byte
    {
        System = 1,

        User = 2,
    }

    public enum StringValueField : ushort
    {
        Sequence = 0,
        
        Source = 1,
        
        HeapSize = 2,

        Length = 3,

        Offset = 4,

        Value = 5,        
    }

    public enum StringValueWidths : ushort
    {
        Sequence = 12,
        
        Source = 12,

        HeapSize = 12,

        Length = 12,

        Offset = 12,

        Value = 12,            
    }

    public readonly struct StringValueRecord 
    {            
        public int Sequence {get;}

        public StringSource Source {get;}

        public int HeapSize {get;}

        public int Length {get;}

        public int Offset {get;}

        public string Value {get;}
    
        [MethodImpl(Inline)]
        public StringValueRecord(int Sequence,  StringSource src, int HeapSize, int Offset, string Value)
        {
            this.Sequence = Sequence;
            this.Source = src;
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


    partial class PartRecords
    {
        public static RecordFormatter<F,W> formatter(StringValueRecord spec)
            => Tabular.Formatter<F,W>();

        [Op]
        public static ref readonly RecordFormatter<F,W> format(in StringValueRecord src, in RecordFormatter<F,W> dst, bool eol = true)
        {            
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Source, src.Source);
            dst.Delimit(F.HeapSize, src.HeapSize);
            dst.Delimit(F.Length, src.Length);
            dst.Delimit(F.Offset, src.Offset);
            dst.Delimit(F.Value, src.Value);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }
    }

}