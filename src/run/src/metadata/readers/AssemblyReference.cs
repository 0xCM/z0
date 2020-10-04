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
        [MethodImpl(Inline), Op]
        ReadOnlySpan<AssemblyReferenceHandle> AssemblyReferenceHandles()
            => Reader.AssemblyReferences.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AssemblyReferenceData> AssemblyReferences()
        {
            var src = AssemblyReferenceHandles();
            var dst = alloc<AssemblyReferenceData>(src.Length);
            Read(src,dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public AssemblyReference Read(AssemblyReferenceHandle src)
            => Reader.GetAssemblyReference(src);

        [MethodImpl(Inline), Op]
        public ref AssemblyReference Read(AssemblyReferenceHandle src, ref AssemblyReference dst)
        {
            dst = Read(src);
            return ref dst;
        }

        [Op]
        public ref AssemblyReferenceData Read(AssemblyReference src, ref AssemblyReferenceData dst)
        {
            dst.AssemblyName = src.GetAssemblyName();
            dst.Culture = Read(src.Culture);
            dst.Flags = src.Flags;
            dst.HashValue = Read(src.HashValue);
            dst.Name = Read(src.Name);
            dst.PublicKeyOrToken = Read(src.PublicKeyOrToken);
            dst.Version = src.Version;
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void Read(ReadOnlySpan<AssemblyReferenceHandle> src, Span<AssemblyReferenceData> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                Read(Read(skip(src,i)), ref seek(dst,i));
        }

        [MethodImpl(Inline), Op]
        public void Read(ReadOnlySpan<AssemblyReference> src, Span<AssemblyReferenceData> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                Read(skip(src,i), ref seek(dst,i));
        }
    }
}