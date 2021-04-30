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
    using static Images;

    partial class ImageMetaReader
    {
        [MethodImpl(Inline), Op]
        public ref MethodDefinition ReadMethodDef(MethodDefinitionHandle src, ref MethodDefinition dst)
        {
            dst = CliReader.Read(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void ReadMeathodDefs(ReadOnlySpan<MethodDefinitionHandle> src, Span<MethodDefinition> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                 ReadMethodDef(skip(src,i), ref seek(dst,i));
        }
    }
}