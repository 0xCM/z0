//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum ImgFieldRecordField : ushort
    {
        Sequence,

        Name,

        Signature, 

        Attributes,
    }

    public readonly struct ImgFieldRecord
    {
        public int Sequence {get;}

        public string Name {get;}
        
        public BinaryCode Signature {get;}

        public string Attributes {get;}

        [MethodImpl(Inline)]
        public ImgFieldRecord(int Sequence, ImgLiteralFieldRecord Name, ImgBlobRecord SigCode, string Attributes)
        {
            this.Sequence = Sequence;
            this.Name = Name.Value;
            this.Signature = SigCode.Value;
            this.Attributes = Attributes;
        }                
    }

    public enum FieldRecordFieldWidth : ushort
    {
        Sequence = 12,

        Name = 60,

        Signature = 30,                       

        Attributes = 10,
    }
}