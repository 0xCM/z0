//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Konst;
    using static z;

    partial class MetadataReader
    {
        public void Read(TypeDefinitionHandle src, Receiver<TypeDefinition> dst)
            => dst(Reader.GetTypeDefinition(src));

        public void Read(TableSpan<TypeDefinitionHandle> src, Receiver<TypeDefinition> dst)
            => src.Iter(handle => dst(Reader.GetTypeDefinition(handle)));
    }
}