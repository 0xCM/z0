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

    partial class CliMemoryReader
    {
        [MethodImpl(Inline), Op]
        public void Read(TypeDefinitionHandle src, Receiver<TypeDefinition> dst)
            => dst(CliReader.GetTypeDefinition(src));

        [MethodImpl(Inline), Op]
        public void Read(TableSpan<TypeDefinitionHandle> src, Receiver<TypeDefinition> dst)
            => src.Iter(handle => dst(CliReader.GetTypeDefinition(handle)));
    }
}