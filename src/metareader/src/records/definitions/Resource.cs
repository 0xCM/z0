//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using S = MetadataRecords.ResourceSpec;
    using R = MetadataRecords.ResourceRecord;
    
    partial class MetadataRecords
    {
        public readonly struct ResourceRecord : IMetadataRecord<R,S>
        {
            public long Offset {get;}

            public string Name {get;}

            public string Attribute {get;}

            public string Implementation {get;}

            public S Kind => default;

            [MethodImpl(Inline)]
            internal ResourceRecord(string Name, string Attribute, long Offset, string Implementation)
            {
                this.Name = Name;
                this.Attribute = Attribute;
                this.Offset = Offset;
                this.Implementation = Implementation;
            }            
            public string Format()
                => Format(FieldDelimiter);
            
            public string Format(char delimiter)
            {
                var dst = text.build();
                dst.Append(Offset.FormatHex(zpad:true, specifier:false).PadRight(6));
                dst.Append(Delimiter);
                dst.Append(Name.PadRight(20));
                dst.Append(Delimiter);
                dst.Append(Attribute.PadRight(20));
                dst.Append(Delimiter);
                dst.Append(Implementation.PadRight(20));
                return dst.ToString();
            }
        }                    

        public readonly struct ResourceSpec : IMetadataRecordSpec<ResourceSpec>
        {
            [MethodImpl(Inline)]
            public static implicit operator MetadataRecordKind(ResourceSpec src)
                => src.RecordType;

            public MetadataRecordKind RecordType 
                => MetadataRecordKind.ManifestResource;  

            public override string ToString()
                => (this as ITextual).Format();
        }
    }
}