//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    struct Msg
    {
        public static MsgPattern<FS.FileUri> LoadingSpanAccessors => "Loading respack accessors from {0}";

        public static MsgPattern<Count,FS.FileUri> LoadedSpanAccessors => "Loaded {0} respack accessors from {1}";

        public static MsgPattern<Count> LoadingHexFileBlocks => "Loading hex blocks from {0} files";

        public static MsgPattern<Count> LoadedHexBlocks => "Loaded {0} hex blocks";

        public static MsgPattern<Count> ProcessingApiHexFiles => "Processing {0} api hex files";

        public static MsgPattern<Count> AccumulatedDescriptors => "Accumulated {0} descriptors";
    }
}
