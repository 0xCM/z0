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
        public AssemblyFile ReadFile(AssemblyFileHandle src)
            => MD.GetAssemblyFile(src);

        [MethodImpl(Inline), Op]
        public ref AssemblyFile ReadFile(AssemblyFileHandle src, ref AssemblyFile dst)
        {
            dst = ReadFile(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void ReadFiles(ReadOnlySpan<AssemblyFileHandle> src, Span<AssemblyFile> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                ReadFile(skip(src,i), ref seek(dst,i));
        }
    }
}