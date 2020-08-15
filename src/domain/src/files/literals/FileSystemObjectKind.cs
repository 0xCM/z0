//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum FileSystemObjectKind : byte
    {
        None = 0,

        Directory,

        File,

        Volume,

        Drive,
    }
}