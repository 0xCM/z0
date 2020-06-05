//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static MetadataRecords.BlobField;

    partial struct MetaRecordKinds
    {
        public readonly struct BlobRecord : IMetaRecordKind<BlobRecord>
        {
            [MethodImpl(Inline)]
            public static implicit operator MetaRecordKind(BlobRecord src)
                => src.RecordType;

            public MetaRecordKind RecordType => MetaRecordKind.Blob;       

            public byte FieldCount => (byte)RecordFieldCount;
        }
    }
}