//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum CommentTargetKind : byte
    {
        None = 0,

        Type = 1,

        Method = 2,

        Field = 3,

        Property = 4,
    }

}