//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static MetadataRecords;

    public interface IMetadataReader : IServiceAllocation
    {        
        ReadOnlySpan<StringValueRecord> ReadStrings();

        ReadOnlySpan<StringValueRecord> ReadUserStrings();

        ReadOnlySpan<BlobRecord> ReadBlobs();

        ReadOnlySpan<ConstantRecord> ReadConstants();

        ReadOnlySpan<FieldRecord> ReadFields();

        ReadOnlySpan<ResourceRecord> ReadManifestResources();
    }
}