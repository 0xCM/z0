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

    using static Konst;
    using static z;

    partial class CliMemoryMap
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ManifestResourceHandle> ManifestResourceHandles(MetadataReader reader)
            => reader.ManifestResources.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public static ManifestResource Read(MetadataReader reader, ManifestResourceHandle src)
            => reader.GetManifestResource(src);


        [MethodImpl(Inline), Op]
        public static ref ManifestResource Read(MetadataReader reader, ManifestResourceHandle src, out ManifestResource dst)
        {
            dst = Read(reader, src);
            return ref dst;
        }

        public DirectoryEntry ResourcesDirectory
            => CorHeader.ResourcesDirectory;

        [Op]
        public unsafe bool Search(string name, out ResourceSegment dst)
        {
            dst = default;

            var directory = SectonData(ResourcesDirectory);
            var descriptions = ManifestResourceDescriptions();
            var count = descriptions.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var description = ref skip(descriptions, i);
                if(description.Name.Equals(name))
                {
                    var blobReader = directory.GetReader((int)description.Offset, directory.Length - (int)description.Offset);
                    var length = blobReader.ReadUInt32();
                    MemoryAddress address = blobReader.CurrentPointer;
                    dst = new ResourceSegment(name, new SegRef(address,length));
                    return true;
                }
            }
            return false;
        }


        [Op]
        public unsafe ReadOnlySpan<ResourceSegment> ResourceSegments()
        {
            var resources = ManifestResourceDescriptions();
            var count = resources.Length;
            var dst = span<ResourceSegment>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var res = ref skip(resources, i);
                var resdir = SectonData(ResourcesDirectory);
                var blobReader = resdir.GetReader((int)res.Offset, resdir.Length - (int)res.Offset);
                var length = blobReader.ReadUInt32();
                MemoryAddress address = blobReader.CurrentPointer;
                seek(dst,i) = new ResourceSegment(res.Name, new SegRef(address,length));
            }
            return dst;
        }

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<CliManifestResourceInfo> ManifestResourceDescriptions()
        {
            var handles = ManifestResourceHandles();
            return Read(handles, alloc<CliManifestResourceInfo>(handles.Length));
        }

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<ManifestResourceHandle> ManifestResourceHandles()
            => CliReader.ManifestResources.ToReadOnlySpan();


        [MethodImpl(Inline), Op]
        public ManifestResource Read(ManifestResourceHandle src)
            => CliReader.GetManifestResource(src);


        [MethodImpl(Inline), Op]
        public ref ManifestResource Read(ManifestResourceHandle src, out ManifestResource dst)
        {
            dst = Read(src);
            return ref dst;
        }



        [MethodImpl(Inline), Op]
        public Span<CliManifestResourceInfo> Read(ReadOnlySpan<ManifestResourceHandle> src, Span<CliManifestResourceInfo> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                Read(Read(skip(src,i), out var _), ref seek(dst,i));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public ref CliManifestResourceInfo Read(in ManifestResource src, ref CliManifestResourceInfo dst)
        {
            dst.Name = Read(src.Name);
            dst.Offset = (ulong)src.Offset;
            dst.Attributes = src.Attributes;
            return ref dst;
        }
    }
}