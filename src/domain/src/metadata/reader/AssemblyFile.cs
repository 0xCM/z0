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

    partial class ImageMemoryMap
    {
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AssemblyFileHandle> AssemblyFileHandles()
            => Reader.AssemblyFiles.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public AssemblyFile Read(AssemblyFileHandle src)
            => Reader.GetAssemblyFile(src);

        [MethodImpl(Inline), Op]
        public ref AssemblyFile Read(AssemblyFileHandle src, ref AssemblyFile dst)
        {
            dst = Read(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void Read(ReadOnlySpan<AssemblyFileHandle> src, Span<AssemblyFile> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                Read(skip(src,i), ref seek(dst,i));
        }
    }
}