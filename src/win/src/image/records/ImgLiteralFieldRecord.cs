//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum ImgLiteralField : ushort
    {
        Sequence = 0,
        
        HeapSize = 1,

        Length = 2,

        Offset = 3,

        Value = 4,
    }

    public readonly struct ImgLiteralFieldRecord
    {
        public int Sequence {get;}

        public int HeapSize {get;}

        public int Length {get;}
        
        public Address32 Offset {get;}
        
        public string Value {get;}

        [MethodImpl(Inline)]
        public ImgLiteralFieldRecord(int Sequence, int HeapSize, int Offset, string Value)
        {
            this.Sequence = Sequence;
            this.HeapSize = HeapSize;
            this.Length = Value.Length;
            this.Offset = (uint)Offset;
            this.Value = Value;
        }                        
    }            
}