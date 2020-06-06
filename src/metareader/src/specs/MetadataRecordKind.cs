//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum MetadataRecordKind : byte
    {
        None = 0,

        String = 1,

        Blob = 2,

        Constant = 3,

        Field = 4,

        ManifestResource = 5,

        Literal = 6,

        MethodDefinition = 7,
    }
}