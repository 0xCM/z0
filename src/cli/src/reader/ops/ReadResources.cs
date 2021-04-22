//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Part;
    using static memory;
    using static Images;

    partial class ImageMetaReader
    {
        [MethodImpl(Inline), Op]
        public static ManifestResource ReadResource(MetadataReader reader, ManifestResourceHandle src)
            => reader.GetManifestResource(src);

        [MethodImpl(Inline), Op]
        public static ref ManifestResource ReadResource(MetadataReader reader, ManifestResourceHandle src, out ManifestResource dst)
        {
            dst = ReadResource(reader, src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public ref ManifestResource ReadResource(ManifestResourceHandle src, out ManifestResource dst)
        {
            dst = ReadResource(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public ManifestResource ReadResource(ManifestResourceHandle src)
            => MetadataReader.GetManifestResource(src);

        [Op]
        public unsafe bool ResourceSearch(string name, out ResSegment dst)
        {
            dst = default;

            var directory = ReadSectionData(ResourcesDirectory);
            var descriptions = ReadResDescriptions();
            var count = descriptions.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var description = ref skip(descriptions, i);
                if(description.Name.Equals(name))
                {
                    var blobReader = directory.GetReader((int)description.Offset, directory.Length - (int)description.Offset);
                    var length = blobReader.ReadUInt32();
                    MemoryAddress address = blobReader.CurrentPointer;
                    dst = new ResSegment(name, new MemorySegment(address,length));
                    return true;
                }
            }
            return false;
        }

        [Op]
        public unsafe ReadOnlySpan<ResSegment> ReadResSegments()
        {
            var resources = ReadResDescriptions();
            var count = resources.Length;
            var dst = span<ResSegment>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var res = ref skip(resources, i);
                var resdir = ReadSectionData(ResourcesDirectory);
                var blobReader = resdir.GetReader((int)res.Offset, resdir.Length - (int)res.Offset);
                var length = blobReader.ReadUInt32();
                MemoryAddress address = blobReader.CurrentPointer;
                seek(dst,i) = new ResSegment(res.Name, new MemorySegment(address,length));
            }
            return dst;
        }

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<ManifestResourceHandle> ResourceHandles()
            => MetadataReader.ManifestResources.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public static ManifestResourceHandle ResourceHandle(uint row)
            => MetadataTokens.ManifestResourceHandle((int)row);

        public static TableIndex? table(Handle handle)
        {
            if(MetadataTokens.TryGetTableIndex(handle.Kind, out var table))
                return table;
            else
                return null;
        }

        public ClrTableEntry? metaindex(Handle handle)
        {
            if(!handle.IsNil)
            {
                var table = ImageMetaReader.table(handle);
                var token = MetadataReader.GetToken(handle);
                if (table != null)
                    return new ClrTableEntry(token, table.Value);
            }

            return null;
        }
    }
}