//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct ApiCodeDescriptor : IRecord<ApiCodeDescriptor>
    {
        public const string TableId = "apicode";

        public ApiPartKind Part;

        public Name Host;

        public MemoryAddress Base;

        public ByteSize Size;

        public ApiUri<string> Uri;

        public BinaryCode Encoded;
    }
}