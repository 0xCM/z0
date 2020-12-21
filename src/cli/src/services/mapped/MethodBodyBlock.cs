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

    partial class CliMemoryMap
    {
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<MethodDefinitionHandle> MethodDefinitionHandles()
            => CliReader.MethodDefinitions.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ref MethodBodyBlock Read(MethodDefinition src, ref MethodBodyBlock dst)
        {
            dst = PeReader.GetMethodBody(src.RelativeVirtualAddress);
            return ref dst;
        }
    }
}