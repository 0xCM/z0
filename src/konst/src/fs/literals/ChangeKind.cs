//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static Konst;

    partial struct FS
    {
        public enum ChangeKind : byte
        {
            None = 0,

            Created = 1,

            Deleted = 2,

            Modified = 4,

            Renamed = 8,
        }                
    }
}