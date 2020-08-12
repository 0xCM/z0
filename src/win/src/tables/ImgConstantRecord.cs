//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using Z0.Data;

    using static Konst;

    public enum ImgConstantField : ushort
    {
        Sequence = 0,

        ParentId = 1,

        Source = 2,

        DataType = 3,

        Value = 4,
    }

    [Table]
    public struct ImgConstantRecord : ITable<ImgConstantField>
    {            
        public int Sequence;

        public int ParentId;
        
        public string Source;

        public ConstantTypeCode DataType;

        public BinaryCode Value;    

        [MethodImpl(Inline)]
        public ImgConstantRecord(int Sequence, HandleInfo Parent, ConstantTypeCode type, BinaryCode value)
        {
            this.Sequence = Sequence;
            this.ParentId = Parent.Token;
            this.Source = Parent.Source.ToString();
            this.DataType = type;
            this.Value = value;
        }            
    }    
}