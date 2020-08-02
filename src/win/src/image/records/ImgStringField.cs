//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum ImgStringSource : byte
    {
        System = 1,

        User = 2,
    }

    public enum ImgStringField : ushort
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

    public readonly struct ImgStringRecord 
    {            
        public int Sequence {get;}

        public ImgStringSource Source {get;}

        public int HeapSize {get;}

        public int Length {get;}

        public int Offset {get;}

        public string Value {get;}
    
        [MethodImpl(Inline)]
        public ImgStringRecord(int Sequence,  ImgStringSource src, int HeapSize, int Offset, string Value)
        {
            this.Sequence = Sequence;
            this.Source = src;
            this.HeapSize = HeapSize;
            this.Length = Value.Length;
            this.Offset = Offset;
            this.Value = Value;
        }                     
    }

}