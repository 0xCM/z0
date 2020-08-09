//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    public enum FileSystemChangeKind : byte
    {
        None = 0,

        Created = 1,

        Deleted = 2,

        Modified = 4,

        Renamed = 8,
    }        
}