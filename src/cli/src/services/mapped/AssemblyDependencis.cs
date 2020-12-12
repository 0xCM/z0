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
        ReadOnlySpan<AssemblyReferenceHandle> AssemblyReferenceHandles()
            => CliReader.AssemblyReferences.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AssemblyRef> AssemblyDependencies()
        {
            var src = AssemblyReferenceHandles();
            var dst = alloc<AssemblyRef>(src.Length);
            Read(src, dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public void Read(ReadOnlySpan<AssemblyReferenceHandle> src, Span<AssemblyRef> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                var ar = CliReader.GetAssemblyReference(skip(src,i));
                Read(ar, ref seek(dst,i));
            }
        }

        [Op]
        public ref AssemblyRef Read(AssemblyReference src, ref AssemblyRef dst)
        {
            dst.Source = CliReader.GetAssemblyDefinition().GetAssemblyName();
            dst.Target = src.GetAssemblyName();
            // dst.Culture = Read(src.Culture);
            // dst.Flags = src.Flags;
            // dst.HashValue = Read(src.HashValue);
            // dst.Name = Read(src.Name);
            // dst.PublicKeyOrToken = Read(src.PublicKeyOrToken);
            // dst.Version = src.Version;
            return ref dst;
        }
    }
}