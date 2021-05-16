//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection;
    using System.Reflection.PortableExecutable;
    using Microsoft.CodeAnalysis;

    using static Part;
    [ApiHost]
    public readonly partial struct Cli
    {
        const NumericKind Closure = UnsignedInts;

        public static void visualize(FS.FilePath src, FS.FilePath dst)
            => Mdv.run(src.Name,dst.Name);

        public static PdbSymbolStore symbols(IWfRuntime wf)
            => PdbSymbolStore.create(wf);


        [MethodImpl(Inline), Op]
        public unsafe static MetadataReaderProvider ReaderProvider(Assembly src)
        {
            var metadata = Clr.metadata(src);
            return ReaderProvider(metadata.BaseAddress.Pointer<byte>(), metadata.Size);
        }

        [MethodImpl(Inline), Op]
        public unsafe static MetadataReaderProvider ReaderProvider(byte* pSrc, ByteSize size)
            => MetadataReaderProvider.FromMetadataImage(pSrc, size);

        [MethodImpl(Inline), Op]
        public static MetadataReaderProvider ReaderProvider(Stream stream, MetadataStreamOptions options = MetadataStreamOptions.Default)
            => MetadataReaderProvider.FromMetadataStream(stream, options);

        [MethodImpl(Inline), Op]
        public unsafe static MetadataReaderProvider PdbReaderProvider(byte* pSrc, ByteSize size)
            => MetadataReaderProvider.FromPortablePdbImage(pSrc, size);

        [MethodImpl(Inline), Op]
        public static MetadataReaderProvider PdbReaderProvider(Stream src, MetadataStreamOptions options = MetadataStreamOptions.Default)
            => MetadataReaderProvider.FromPortablePdbStream(src, options);


        public static MetadataReference MetadataRef(FS.FilePath src)
        {
            var xml = src.ChangeExtension(FS.Xml);
            var doc = xmldoc(xml);
            var props = default(MetadataReferenceProperties);
            return MetadataReference.CreateFromFile(src.Name, props, doc);
        }

        public static MetadataReference MetadataRef(Assembly src)
        {
            var path = FS.path(src.Location);
            var xml = path.ChangeExtension(FS.Xml);
            var props = default(MetadataReferenceProperties);
            if(xml.Exists)
            {
                var doc = xmldoc(xml);
                var reference = MetadataReference.CreateFromFile(path.Name, props, doc);
                return reference;
            }
            else
                return MetadataReference.CreateFromFile(path.Name, props);
        }


        public static XmlDocProvider xmldoc(FS.FilePath src)
            => new XmlDocProvider(src.Name);

    }

    [ApiHost]
    public static partial class XCmd
    {

    }
}