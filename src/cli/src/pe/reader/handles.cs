//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    partial class PeTableReader
    {
        public static ManifestResourceHandle ManifestResourceHandle(uint row)
            => MetadataTokens.ManifestResourceHandle((int)row);
    }
}