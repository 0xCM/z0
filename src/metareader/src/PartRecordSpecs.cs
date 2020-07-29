//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static PartRecords;

    public readonly struct PartRecordSpecs
    {
        public static StringValueRecord Strings => default;
        
        public static BlobRecord Blobs => default;
        
        public static ConstantRecord Constants => default;

        public static FieldRecord Fields => default;

        public static FieldRvaRecord FieldRva => default;
    }
}