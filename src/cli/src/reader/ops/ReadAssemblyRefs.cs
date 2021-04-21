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
        [Op]
        public ReadOnlySpan<AssemblyRefInfo> ReadAssemblyRefs()
        {
            var src = AssemblyReferenceHandles();
            var dst = alloc<AssemblyRefInfo>(src.Length);
            ReadAssemblyRefs(src, dst);
            return dst;
        }

        [Op]
        public void ReadAssemblyRefs(ReadOnlySpan<AssemblyReferenceHandle> src, Span<AssemblyRefInfo> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                var ar = MetadataReader.GetAssemblyReference(skip(src,i));
                ReadAssemblyRef(ar, ref seek(dst,i));
            }
        }

        [Op]
        public ref AssemblyRefInfo ReadAssemblyRef(AssemblyReference src, ref AssemblyRefInfo dst)
        {
            dst.Source = MetadataReader.GetAssemblyDefinition().GetAssemblyName().ToString().LeftOfFirst(Chars.Comma);
            dst.Target = src.GetAssemblyName().ToString().LeftOfFirst(Chars.Comma);
            dst.Token = ReadBlob(src.PublicKeyOrToken);
            return ref dst;
        }


        [MethodImpl(Inline), Op]
        ReadOnlySpan<AssemblyReferenceHandle> AssemblyReferenceHandles()
            => MetadataReader.AssemblyReferences.ToReadOnlySpan();
    }
}