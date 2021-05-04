//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiComplete]
    partial struct Msg
    {
        public static MsgPattern<FS.FileUri> CreatingPdbReader => "Creating pdb reader for {0}";

        public static MsgPattern<FS.FileUri> CreatedPdbReader => "Created pdb reader for {0}";
    }
}