//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Linq;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;
    using System.Reflection.PortableExecutable;
    using System.Text;
    using System.Reflection;

    using MT = MetadataTypes;

    using static Control;
    using static Seed;

    public struct MetaReader : IMetadataReader
    {
        public static IMetadataReader Init(string path)
        {
            var stream = File.OpenRead(path);
            var peFile = new PEReader(stream);
            return new MetaReader(new MetaReaderState(stream, peFile));
        }

        MetaReaderState State;

        [MethodImpl(Inline)]
        MetaReader(MetaReaderState src)
        {
            State = src;
        }
        
        public void Dispose()
        {
            State.Dispose();
        }
        
        public ReadOnlySpan<MT.StringValue> ReadStrings()
        {
            var reader = State.Reader;
            int size = reader.GetHeapSize(HeapIndex.String);
            if (size == 0)
                return Span<MT.StringValue>.Empty;

            var values = new List<MT.StringValue>();
            var handle = MetadataTokens.StringHandle(0);
            do
            {
                values.Add(new MT.StringValue(
                    HeapSize:size, 
                    Offset: reader.GetHeapOffset(handle), 
                    Value: reader.GetString(handle))
                    );
            
                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);
            
            return values.ToArray();            
        }

        public ReadOnlySpan<MT.StringValue> ReadUserStrings()
        {
            var reader = State.Reader;
            int size = reader.GetHeapSize(HeapIndex.UserString);
            if (size == 0)
                return Span<MT.StringValue>.Empty;

            var values = new List<MT.StringValue>();
            var handle = MetadataTokens.UserStringHandle(0);
            do
            {                
                values.Add(new MT.StringValue(
                    HeapSize: size, 
                    Offset: reader.GetHeapOffset(handle), 
                    Value: reader.GetUserString(handle)
                    ));

                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);
            
            return values.ToArray();
        }

        public ReadOnlySpan<MT.BlobValue> ReadBlobs()
        {
            var reader = State.Reader;
            int size = reader.GetHeapSize(HeapIndex.Blob);
            if (size == 0)
                return Span<MT.BlobValue>.Empty;

            var handle = MetadataTokens.BlobHandle(0);
            var values = new List<MT.BlobValue>();
            do
            {
                var value = reader.GetBlobBytes(handle);
                values.Add(new MT.BlobValue(
                    HeapSize: size, 
                    Offset: reader.GetHeapOffset(handle), 
                    Value: reader.GetBlobBytes(handle)
                    ));

                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }

        public ReadOnlySpan<MT.Constant> ReadConstants()
        {
            var reader = State.Reader;
            var count = reader.GetTableRowCount(TableIndex.Constant);
            var dst = alloc<MT.Constant>(count);

            for (int i = 1; i <= count; i++)
            {
                var entry = reader.GetConstant(MetadataTokens.ConstantHandle(i));
                seek(dst,i-1) = new MT.Constant(
                    Parent: Token(entry.Parent),
                    Type: ReadEnum(entry.TypeCode),
                    Value: LiteralValue(entry.Value)
                );
            }

            return dst;
        }

        public ReadOnlySpan<MT.Field> ReadFields()
        {
            var handles = Reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = alloc<MT.Field>(count);

            for(var i=0; i<count; i++)
            {
                ref readonly var handle = ref skip(handles,i);
                var entry = Reader.GetFieldDefinition(handle);

                seek(dst,i) = new MT.Field(
                    Rva: entry.GetRelativeVirtualAddress(),                    
                    Offset: entry.GetOffset(),
                    Name: LiteralValue(entry.Name),
                    Signature: LiteralValue(entry.Signature),
                    Attributes: ReadEnum(entry.Attributes),
                    Marshalling: Literal(entry.GetMarshallingDescriptor())
                );
            }
            return dst;
        }

        public ReadOnlySpan<MT.ManifestResource> ReadManifestResources()
        {
            var handles = Reader.ManifestResources.ToReadOnlySpan();
            var count = handles.Length;
            var dst = alloc<MT.ManifestResource>(count);

            for(var i=0; i<count; i++)
            {
                ref readonly var handle = ref skip(handles,i);
                var entry = Reader.GetManifestResource(handle);
                seek(dst,i) = new MT.ManifestResource(
                        Name: Literal(entry.Name),
                        Attribute: entry.Attributes.ToString(),
                        Offset: entry.Offset,
                        Implementation: Token(entry.Implementation)
                );
            }
            return dst;
        }

        string Literal(NamespaceDefinitionHandle handle)
            => Literal(handle, (r, h) => "'" + r.GetString((NamespaceDefinitionHandle)h) + "'");

        string Literal(GuidHandle handle)
            => Literal(handle, (r, h) => "{" + r.GetGuid((GuidHandle)h) + "}");

        string Literal(StringHandle handle)
            => Literal(handle, (r, h) => "'" + r.GetString((StringHandle)h) + "'");

        string Literal(BlobHandle handle)
            => Literal(handle, (r, h) => BitConverter.ToString(r.GetBlobBytes((BlobHandle)h)));
        
        MT.LiteralValue LiteralValue(StringHandle handle)
        {
            var text = State.Reader.GetString(handle);
            var offset = State.Reader.GetHeapOffset(handle);
            var rows = State.Reader.GetTableRowCount(TableIndex.EncLog);
            var value = rows <= 0 ? State.Reader.GetString(handle) : string.Empty;
            return new MT.LiteralValue(offset,value);                    
        }

        MetadataReader Reader 
            => State.Reader;

        MT.BlobValue LiteralValue(BlobHandle handle)
        {
            var offset = Reader.GetHeapOffset(handle);
            var rows = Reader.GetTableRowCount(TableIndex.EncLog);
            var value = rows <= 0 ? Reader.GetBlobBytes(handle) : Control.array<byte>();
            return new MT.BlobValue(0,offset,value);                    
        }

        string Literal(Handle handle, Func<MetadataReader, Handle, string> getValue)
        {
            if (handle.IsNil)
                return "null";

            if (State.Aggregator)
                return Literal(handle, State.Aggregator.Value, getValue);

            var offset = Reader.GetHeapOffset(handle);
            var offsetFmt = PaddedHex(offset);

            if (Reader.GetTableRowCount(TableIndex.EncLog) > 0)
                return offsetFmt;

            var value = getValue(Reader, handle);
            return $"{offsetFmt} | {value}";            
        }

        string Literal(Handle handle, MetadataAggregator aggregator, Func<MetadataReader, Handle, string> getValue)
        {        
            int generation;
            Handle generationHandle = aggregator.GetGenerationHandle(handle, out generation);

            var generationReader = State.Readers[generation];
            string value = getValue(generationReader, generationHandle);
            int offset = generationReader.GetHeapOffset(handle);
            int generationOffset = generationReader.GetHeapOffset(generationHandle);

            if (offset == generationOffset)
                return string.Format("{0} (#{1:x})", value, offset);
            else
                return string.Format("{0} (#{1:x}/{2:x})", value, offset, generationOffset);            
        }

        string ReadEnum<E>(E value) 
            where E : unmanaged, Enum
        {
            return value.ToString();
        }

        TableIndex? ReadTableIndex(Handle handle)
        {
            if(MetadataTokens.TryGetTableIndex(handle.Kind, out var table))
                return table;         
            else
                return null;
        }

        static string Hex(int src)
            => src.FormatHex(zpad:false, specifier:true, prespec:false);
        
        static string PaddedHex(int src)
            => src.FormatHex(zpad:true, specifier:true, prespec:false);
        
        string Token(Handle handle, bool displayTable = true)
        {
            if (handle.IsNil)
                return "null";

            var table = ReadTableIndex(handle);
            var token = State.Reader.GetToken(handle);
            var tokenFmt = PaddedHex(token);
            if (displayTable && table != null)
                return $"{tokenFmt} | {table}";
            else
                return tokenFmt;
        }

        static Span<T> alloc<T>(int count)
            => new T[count];
    }
}