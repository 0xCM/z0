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
        public readonly struct ManifestResource : IMetadataRecord<ManifestResource,ManifestResourceRecord>
        {
            public const MetaRecordKind RecordKind = MetaRecordKind.ManifestResource;

            public long Offset {get;}

            public string Name {get;}

            public string Attribute {get;}

            public string Implementation {get;}

            public MetaRecordKind Kind => RecordKind;

            [MethodImpl(Inline)]
            internal ManifestResource(string Name, string Attribute, long Offset, string Implementation)
            {
                this.Name = Name;
                this.Attribute = Attribute;
                this.Offset = Offset;
                this.Implementation = Implementation;
            }            
            public string Format()
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

    }
}