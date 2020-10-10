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

    partial class ImageMap
    {
        [MethodImpl(Inline), Op]
        public MethodDefinition Read(MethodDefinitionHandle src)
            => CliReader.GetMethodDefinition(src);

        [MethodImpl(Inline), Op]
        public ref MethodDefinition Read(MethodDefinitionHandle src, ref MethodDefinition dst)
        {
            dst = Read(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void Read(ReadOnlySpan<MethodDefinitionHandle> src, Span<MethodDefinition> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                 Read(skip(src,i), ref seek(dst,i));
        }
    }
}