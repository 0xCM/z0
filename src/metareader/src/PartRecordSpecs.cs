//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static PartRecords;

    public readonly struct PartRecordSpecs
    {
        public StringValueRecord Strings => default;
        
        public BlobRecord Blobs => default;
        
        public ConstantRecord Constants => default;

        public FieldRecord Fields => default;

        public FieldRvaRecord FieldRva => default;
    }
}