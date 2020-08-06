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

    public readonly struct ImgBlobRecord : ITable<ImgBlobField, ImgBlobRecord>
    {
        public int Sequence {get;}
        
        public int HeapSize {get;}

        public Address32 Offset {get;}
        
        public BinaryCode Value {get;}

        [MethodImpl(Inline)]
        public ImgBlobRecord(int Sequence, int HeapSize, int Offset, byte[] Value)
        {
            this.Sequence = Sequence;
            this.HeapSize = HeapSize;
            this.Offset = (uint)Offset;
            this.Value = Value;
        }
    }

    public enum ImgBlobField : ushort
    {
        Sequence = 0,

        HeapSize = 1,

        Offset = 2,

        Value = 3,                    
    }

    public enum BlobFieldWidth : ushort
    {
        Sequence = 12,

        HeapSize = 12,

        Offset = 12,

        Value = 30,                       
    }
}