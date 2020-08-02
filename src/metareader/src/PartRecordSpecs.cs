//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static PartRecords;

    public readonly struct PartRecordSpecs
    {
        public static ImgStringRecord Strings => default;
        
        public static ImgBlobRecord Blobs => default;
        
        public static ImgConstantRecord Constants => default;

        public static ImgFieldRecord Fields => default;

        public static ImgFieldRva FieldRva => default;
    }
}