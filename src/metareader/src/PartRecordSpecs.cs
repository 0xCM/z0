//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static PartRecords;

    public readonly struct PartRecordSpecs
    {
        public static StringValueRecord Strings => default;
        
        public static BlobRecord Blobs => default;
        
        public static ConstantRecord Constants => default;

        public static FieldRecord Fields => default;

        public static LiteralRecord Literals => default;

        public static FieldRvaRecord FieldRva => default;
    }
}