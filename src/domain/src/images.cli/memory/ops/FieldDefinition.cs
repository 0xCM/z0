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

    partial class CliMemoryMap
    {
        [MethodImpl(Inline), Op]
        public FieldDefinition Read(FieldDefinitionHandle src)
            => CliReader.GetFieldDefinition(src);

        [MethodImpl(Inline), Op]
        public ref FieldDefinition Read(FieldDefinitionHandle src, ref FieldDefinition dst)
        {
            dst = Read(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void Read(ReadOnlySpan<FieldDefinitionHandle> src, Span<FieldDefinition> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                Read(skip(src,i), ref seek(dst,i));
        }
    }
}