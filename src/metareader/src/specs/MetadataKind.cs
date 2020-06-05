//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Flags]
    public enum MetadataKind : ulong
    {
        None = 0,

        String = 1,

        UserString = 2,

        Blob = 4,

        Constant = 8,

        Field = 16,

        ManifestResource = 32
    }
}