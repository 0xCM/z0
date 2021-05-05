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
    using static ImageRecords;
    using static CliRecords;

    partial class ImageMetaReader
    {
        public ReadOnlySpan<AssemblyRefRow> AssemblyRefRows()
        {
            var handles = CliReader.AssemblyRefHandles();
            var count = handles.Length;
            var buffer = alloc<AssemblyRefRow>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var handle = ref skip(handles,i);
                ref var row = ref seek(dst,i);
                var src = MD.GetAssemblyReference(handle);
                row.Key = Cli.key(CliTableKind.AssemblyRef, handle);
                row.Culture = src.Culture;
                row.Flags = src.Flags;
                row.Hash = src.HashValue;
                row.Token = src.PublicKeyOrToken;
                row.Version = src.Version;
            }
            return buffer;
        }

        [Op]
        public ReadOnlySpan<AssemblyRefInfo> ReadAssemblyRefs()
        {
            var src = CliReader.AssemblyRefHandles();
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
                var ar = MD.GetAssemblyReference(skip(src,i));
                ReadAssemblyRef(ar, ref seek(dst,i));
            }
        }

        [Op]
        public ref AssemblyRefInfo ReadAssemblyRef(AssemblyReference src, ref AssemblyRefInfo dst)
        {
            dst.Source = MD.GetAssemblyDefinition().GetAssemblyName();
            dst.Target = src.GetAssemblyName();
            dst.Token = CliReader.Read(src.PublicKeyOrToken);
            return ref dst;
        }
    }
}