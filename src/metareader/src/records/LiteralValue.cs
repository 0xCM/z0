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
        public readonly struct LiteralValue : IMetadataRecord<LiteralValue,LiteralRecord>
        {
            public const MetaRecordKind RecordKind = MetaRecordKind.Literal;

            public int Offset {get;}
            
            public string Value {get;}

            public MetaRecordKind Kind => RecordKind;

            [MethodImpl(Inline)]
            public LiteralValue(int Offset, string Value)
            {
                this.Offset = Offset;
                this.Value = Value;
            }            
            public string Format()
            {
                var dst = text.build();
                dst.Append(Offset.FormatHex(zpad:false, specifier:false).PadRight(6));
                dst.Append(Delimiter);
                dst.Append(Value);

                return dst.ToString();
            }
        }            
    }
}