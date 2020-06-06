//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static MetadataRecords;

    public readonly struct MetadataSpecs
    {
        public static StringValueSpec Strings => default;
        
        public static BlobSpec Blobs => default;
        
        public static ConstantRecordSpec Constants => default;

        public static FieldRecordSpec Fields => default;

        public static ResourceSpec Resources => default;

        public static LiteralRecordSpec Literals => default;
    }
}