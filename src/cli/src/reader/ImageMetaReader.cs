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
    using static Images;

    [ApiHost]
    public partial class ImageMetaReader : IDisposable
    {
        public static ImageMetaReader create(FS.FilePath src)
            => new ImageMetaReader(src);

        [Op]
        public static bool create(FS.FilePath src, out ImageMetaReader dst)
        {
            if(HasMetadata(src))
            {
                dst = new ImageMetaReader(src);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        [Op]
        public static bool HasMetadata(FS.FilePath src)
        {
            using var stream = File.OpenRead(src.Name);
            using var reader = new PEReader(stream);
            return reader.HasMetadata;
        }

        readonly FS.FilePath Source;

        readonly FileStream Stream;

        public PEReader PeReader {get;}

        public MetadataReader MetadataReader {get;}

        public PEMemoryBlock MetadataBlock {get;}

        public ImageMetaReader(FS.FilePath src)
        {
            Source = src;
            Stream = File.OpenRead(src.Name);
            PeReader = new PEReader(Stream);
            MetadataReader = PeReader.GetMetadataReader();
            MetadataBlock = PeReader.GetMetadata();
        }

        public void Dispose()
        {
            PeReader?.Dispose();
            Stream?.Dispose();
        }

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<MethodDefinitionHandle> MethodDefHandles()
            => MetadataReader.MethodDefinitions.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public void ReadAttributes(Index<CustomAttributeHandle> src, Receiver<CustomAttribute> dst)
            => src.Iter(handle => dst(MetadataReader.GetCustomAttribute(handle)));
    }
}