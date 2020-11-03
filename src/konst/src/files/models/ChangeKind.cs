//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct FS
    {
        [Flags]
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