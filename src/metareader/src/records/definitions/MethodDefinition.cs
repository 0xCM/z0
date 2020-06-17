//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using S = MetadataRecords.MethodDefinitionSpec;
    using F = MetadataRecords.MethodDefinitionField;
    using R = MetadataRecords.MethodDefinitionRecord;
    
    partial class MetadataRecords
    {
        public enum MethodDefinitionField : byte
        {
            Sequence = 0,

        }

        public readonly struct MethodDefinitionRecord : IMetadataRecord<R,S,F>
        {
            public int Sequence {get;}

            public string Format()
                => string.Empty;

            public string Format(char delimiter)
                => string.Empty;
        }

        public readonly struct MethodDefinitionSpec : IMetadataRecordSpec<S>
        {
            [MethodImpl(Inline)]
            public static implicit operator MetadataRecordKind(S src)
                => src.RecordType;

            public MetadataRecordKind RecordType 
                => MetadataRecordKind.MethodDefinition;            

            public override string ToString()
                => (this as ITextual).Format();
        }        
    }
}