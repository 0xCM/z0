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
    using System.Reflection.Metadata.Ecma335;
    using Microsoft.CodeAnalysis;

    using static Part;
    using static core;

    [ApiHost]
    public readonly partial struct Cli
    {
        const NumericKind Closure = UnsignedInts;

        public static MetadataReference metaref(FS.FilePath src)
        {
            var xml = src.ChangeExtension(FS.Xml);
            var doc = XmlDocProvider.create(xml);
            var props = default(MetadataReferenceProperties);
            return MetadataReference.CreateFromFile(src.Name, props, doc);
        }

        public static MetadataReference metaref(Assembly src)
        {
            var path = FS.path(src.Location);
            var xml = path.ChangeExtension(FS.Xml);
            var props = default(MetadataReferenceProperties);
            if(xml.Exists)
            {
                var doc = XmlDocProvider.create(xml);
                var reference = MetadataReference.CreateFromFile(path.Name, props, doc);
                return reference;
            }
            else
                return MetadataReference.CreateFromFile(path.Name, props);
        }

        public static Index<MetadataReference> metarefs(ReadOnlySpan<FS.FilePath> src)
        {
            var count = src.Length;
            var dst = alloc<MetadataReference>(count);
            for(var i=0; i<count; i++)
                seek(dst,i) = metaref(skip(src,i));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static MetadataReaderState state(Assembly src)
            => SRM.initialize(src);

        [MethodImpl(Inline)]
        public static T row<T>()
            where T : unmanaged, ICliRecord<T>
                => new T();

        [MethodImpl(Inline)]
        public static ref T row<T>(out T dst)
            where T : unmanaged, ICliRecord<T>
        {
            dst = row<T>();
            return ref dst;
        }

        [Op]
        public static bool valid(FS.FilePath src)
        {
            using var stream = File.OpenRead(src.Name);
            using var reader = new PEReader(stream);
            return reader.HasMetadata;
        }

        public static Index<byte,CliTableKind> TableKinds()
        {
            const byte MaxTableId = (byte)CliTableKind.CustomDebugInformation;
            var values = Enums.literals<CliTableKind,byte>().Where(x => x < MaxTableId).Sort().View;
            var src = recover<CliTableKind>(values);
            var buffer = alloc<CliTableKind>(MaxTableId + 1);
            ref var dst = ref first(buffer);
            for(byte i=0; i<values.Length; i++)
                seek(dst,skip(values,i)) = (CliTableKind)i;
            return buffer;
        }

        public static CliRowKeys keys<K,T>(ReadOnlySpan<T> handles, K k = default)
            where T : unmanaged
            where K : unmanaged, ICliTableKind<K>
        {
            var count = handles.Length;
            var buffer = alloc<CliRowKey>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = key<K,T>(skip(handles,i));
            return buffer;
        }

        public static void visualize(FS.FilePath src, FS.FilePath dst)
            => Mdv.run(src.Name,dst.Name);

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

        // public static MetadataReference MetadataRef(FS.FilePath src)
        // {
        //     var xml = src.ChangeExtension(FS.Xml);
        //     var doc = XmlDocProvider.create(xml);
        //     var props = default(MetadataReferenceProperties);
        //     return MetadataReference.CreateFromFile(src.Name, props, doc);
        // }

        // public static MetadataReference MetadataRef(Assembly src)
        // {
        //     var path = FS.path(src.Location);
        //     var xml = path.ChangeExtension(FS.Xml);
        //     var props = default(MetadataReferenceProperties);
        //     if(xml.Exists)
        //     {
        //         var doc = XmlDocProvider.create(xml);
        //         var reference = MetadataReference.CreateFromFile(path.Name, props, doc);
        //         return reference;
        //     }
        //     else
        //         return MetadataReference.CreateFromFile(path.Name, props);
        // }

    }

    [ApiHost]
    public static partial class XCmd
    {

    }
}