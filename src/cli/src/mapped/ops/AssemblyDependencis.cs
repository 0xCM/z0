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

    partial class CliMemoryMap
    {
        [MethodImpl(Inline), Op]
        ReadOnlySpan<AssemblyReferenceHandle> AssemblyReferenceHandles()
            => CliReader.AssemblyReferences.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AssemblyRefInfo> AssemblyDependencies()
        {
            var src = AssemblyReferenceHandles();
            var dst = alloc<AssemblyRefInfo>(src.Length);
            Read(src, dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public void Read(ReadOnlySpan<AssemblyReferenceHandle> src, Span<AssemblyRefInfo> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                var ar = CliReader.GetAssemblyReference(skip(src,i));
                Read(ar, ref seek(dst,i));
            }
        }

        [Op]
        public ref AssemblyRefInfo Read(AssemblyReference src, ref AssemblyRefInfo dst)
        {
            dst.Source = CliReader.GetAssemblyDefinition().GetAssemblyName().ToString().LeftOfFirst(Chars.Comma);
            dst.Target = src.GetAssemblyName().ToString().LeftOfFirst(Chars.Comma);
            dst.Token = Read(src.PublicKeyOrToken);
            return ref dst;
        }
    }
}