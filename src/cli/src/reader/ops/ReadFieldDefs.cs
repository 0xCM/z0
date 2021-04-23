//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static memory;
    using static Images;
    using static Part;

    partial class ImageMetaReader
    {
        [MethodImpl(Inline), Op]
        public FieldDefinition ReadFieldDef(FieldDefinitionHandle src)
            => MD.GetFieldDefinition(src);

        [MethodImpl(Inline), Op]
        public ref FieldDefinition ReadFieldDef(FieldDefinitionHandle src, ref FieldDefinition dst)
        {
            dst = ReadFieldDef(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void ReadFieldDefs(ReadOnlySpan<FieldDefinitionHandle> src, Span<FieldDefinition> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                ReadFieldDef(skip(src,i), ref seek(dst,i));
        }
    }
}