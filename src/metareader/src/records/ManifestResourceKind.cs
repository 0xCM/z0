//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial struct MetaRecordKinds
    {
        public readonly struct ManifestResourceRecord : IMetaRecordKind<ManifestResourceRecord>
        {
            [MethodImpl(Inline)]
            public static implicit operator MetaRecordKind(ManifestResourceRecord src)
                => src.RecordType;

            public MetaRecordKind RecordType => MetaRecordKind.ManifestResource;            
        }
    }
}