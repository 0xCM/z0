//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Part;
    using static memory;
    using static CliRecords;

    partial class ImageMetaReader
    {
        [MethodImpl(Inline), Op]
        public void ReadTypeDefs(TypeDefinitionHandle src, Receiver<TypeDefinition> dst)
            => dst(MD.GetTypeDefinition(src));

        [MethodImpl(Inline), Op]
        public void ReadTypeDefs(Index<TypeDefinitionHandle> src, Receiver<TypeDefinition> dst)
            => src.Iter(handle => dst(MD.GetTypeDefinition(handle)));
    }
}