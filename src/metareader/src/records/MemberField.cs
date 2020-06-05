//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static MetaRecordKinds;
    
    partial class MetadataRecords
    {
        public enum MemberFieldField : byte
        {
            Sequence = 0,
            
            Rva = 1,

            Offset = 2,

            Name = 3,

            Signature = 4,

            Attributes = 5,

            Marshalling = 6,
            
            RecordFieldCount = 7,
        }

        public readonly struct MemberField : IMetadataRecord<MemberField,FieldRecord,MemberFieldField>
        {
            public int Sequence {get;}
            
            public int Rva {get;}

            public int Offset {get;}

            public LiteralValue Name {get;}

            public BlobValue Signature {get;}

            public string Attributes {get;}

            public string Marshalling {get;}

            public FieldRecord Kind => default;

            [MethodImpl(Inline)]
            internal MemberField(int Sequence, int Rva, int Offset, LiteralValue Name, BlobValue Signature, string Attributes, string Marshalling)
            {
                this.Sequence = Sequence;
                this.Rva = Rva == -1 ? 0 : Rva;
                this.Offset = Offset == -1 ? 0 : Offset;
                this.Name = Name;
                this.Signature = Signature;
                this.Attributes = Attributes;
                this.Marshalling = Marshalling;
            }            
            
            public string Format()
                => MetaFormat.format(this);
        }
        //     {
        //         var dst = text.build();
        //         dst.Append(Rva.FormatHex(zpad:true, specifier:false).PadRight(14));
        //         dst.Append(Delimiter);
        //         dst.Append(Offset.FormatHex(zpad:false, specifier:false).PadRight(6));
        //         dst.Append(Delimiter);
        //         dst.Append(Name.Format().PadRight(40));
        //         dst.Append(Delimiter);
        //         dst.Append(Signature.Format());
        //         dst.Append(Delimiter);
        //         dst.Append(Marshalling.PadRight(20));
        //         return dst.ToString();
        //     }
        // }        
    }
}