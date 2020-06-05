//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using MT = MetadataRecords;

    public interface IMetadataReader : IServiceAllocation
    {
        ReadOnlySpan<R> Read<R>(R r = default)
            where R : unmanaged, IMetaRecordKind;        
        
        ReadOnlySpan<MT.StringValue> ReadStrings();

        ReadOnlySpan<MT.StringValue> ReadUserStrings();

        ReadOnlySpan<MT.BlobValue> ReadBlobs();

        ReadOnlySpan<MT.ConstantValue> ReadConstants();

        ReadOnlySpan<MT.MemberField> ReadFields();

        ReadOnlySpan<MT.ManifestResource> ReadManifestResources();
    }
}