//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.IO;
    using System.Linq;

    using static Part;
    using static memory;

    partial class CliDataReader
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
            dst.Source = MetadataReader.GetAssemblyDefinition().GetAssemblyName();
            dst.Target = src.GetAssemblyName();
            dst.Token = ReadBlob(src.PublicKeyOrToken);
            return ref dst;
        }


        [MethodImpl(Inline), Op]
        ReadOnlySpan<AssemblyReferenceHandle> AssemblyReferenceHandles()
            => MetadataReader.AssemblyReferences.ToReadOnlySpan();
    }
}