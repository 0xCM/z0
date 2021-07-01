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
    }
}
