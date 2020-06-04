//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using MT = MetadataTypes;

    public interface IMetadataReader : IServiceAllocation
    {
        ReadOnlySpan<MT.StringValue> ReadStrings();

        ReadOnlySpan<MT.StringValue> ReadUserStrings();

        ReadOnlySpan<MT.BlobValue> ReadBlobs();

        ReadOnlySpan<MT.Constant> ReadConstants();

        ReadOnlySpan<MT.Field> ReadFields();

        ReadOnlySpan<MT.ManifestResource> ReadManifestResources();
    }
}