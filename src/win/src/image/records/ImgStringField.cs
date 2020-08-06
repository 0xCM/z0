//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;

    using static Konst;

    public enum ImgStringSource : byte
    {
        System = 1,

        User = 2,
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

    public struct ImgStringRecord : ITable<ImgStringField,ImgStringRecord>
    {            
        public int Sequence;

        public ImgStringSource Source;

        public int HeapSize;

        public int Length;

        public int Offset;

        public string Value;
    
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