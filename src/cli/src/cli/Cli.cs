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
    using static core;

    [ApiHost]
    public readonly partial struct Cli
    {
        const NumericKind Closure = UnsignedInts;

        public static Index<CliBlobHeap> blobs(ReadOnlySpan<Assembly> src)
        {
            var count = src.Length;
            var buffer = alloc<CliBlobHeap>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var component = ref skip(src,i);
                var reader = Cli.reader(component);
                seek(dst,i) = reader.BlobHeap();
            }
            return buffer;

        }

        [Op]
        public static CliTableSource<T> source<T>(Assembly src)
            where T : struct, IRecord<T>
                => new CliTableSource<T>(src);

        [Op]
        public static CliTableSource<T> source<T>(MetadataReader src)
            where T : struct, IRecord<T>
                => new CliTableSource<T>(src);

        [Op]
        public static CliTableSource<T> source<T>(MemorySeg src)
            where T : struct, IRecord<T>
                => new CliTableSource<T>(src);

        [Op]
        public static CliTableSource<T> source<T>(PEMemoryBlock src)
            where T : struct, IRecord<T>
                => new CliTableSource<T>(src);

        [Op]
        public static CliDataSource source(Assembly src)
            => new CliDataSource(src);

        [Op]
        public static CliDataSource source(MetadataReader src)
            => new CliDataSource(src);

        [Op]
        public static CliDataSource source(MemorySeg src)
            => new CliDataSource(src);

        [Op]
        public static CliDataSource source(PEMemoryBlock src)
            => new CliDataSource(src);
        [Op]
        public static CliReader reader(Assembly src)
            => new CliReader(src);

        [Op]
        public static CliReader reader(MetadataReader src)
            => new CliReader(src);

        [Op]
        public static CliReader reader(MemorySeg src)
            => new CliReader(src);

        [Op]
        public static CliReader reader(PEMemoryBlock src)
            => new CliReader(src);

        [MethodImpl(Inline), Op]
        public static CliToken token(Handle src)
        {
            var _data = data(src);
            return new CliToken(_data.Table, _data.RowId);
        }

        [MethodImpl(Inline), Op]
        public static CliTableKind table(Handle handle)
            => data(handle).Table;

        [MethodImpl(Inline), Op]
        public static CliHandleData data(Handle src)
            => @as<Handle,CliHandleData>(src);

        [MethodImpl(Inline), Op]
        public static CliHandleData data(EntityHandle src)
        {
            var row = uint32(src) & 0xFFFFFF;
            var kind = (CliTableKind)(uint32(src) >> 24);
            return new CliHandleData(kind,row);
        }

        [MethodImpl(Inline), Op]
        public static CliToken token(EntityHandle src)
            => @as<EntityHandle,CliToken>(src);

        [MethodImpl(Inline), Op]
        public static Handle handle(CliHandleData src)
            => @as<CliHandleData,Handle>(src);

        [MethodImpl(Inline), Op]
        public Handle handle(CliToken src)
            => handle(new CliHandleData(src.Table, src.Row));

        [MethodImpl(Inline), Op]
        public static CliRowKey key(Handle src)
        {
            var dat = data(src);
            return new CliRowKey(dat.Table, dat.RowId);
        }

        [MethodImpl(Inline), Op]
        public static EntityHandle handle(uint src)
            => @as<uint,EntityHandle>(src);

        [MethodImpl(Inline), Op]
        public static CliRowKey key(EntityHandle src)
        {
            var dat = data(src);
            return new CliRowKey(dat.Table, dat.RowId);
        }

        [MethodImpl(Inline), Op]
        public static uint row(EntityHandle src)
            => uint32(src) & 0xFFFFFF;

        [MethodImpl(Inline)]
        public static CliRowKey<K> key<K,T>(T handle, K k = default)
            where K : unmanaged, ICliTableKind<K>
            where T : unmanaged
                => uint32(handle);

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