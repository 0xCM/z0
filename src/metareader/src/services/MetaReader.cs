//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020 / Microsoft
// License     :  MIT
// Derived from sample code obtained from https://github.com/microsoft/dotnet-samples
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
 
    using static MetaRecordKinds;
    using static Control;
    using static Seed;

    using MT = MetadataRecords;

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
                
        [MethodImpl(Inline)]
        public ReadOnlySpan<R> Read<R>(R r = default)
            where R : unmanaged, IMetaRecordKind
        {
            if(typeof(R) == typeof(StringRecord))
                return Control.cast<MT.StringValue,R>(MetaRead.ustrings(State));
            else if(typeof(R) == typeof(ConstantValueRecord))
                return Control.cast<MT.ConstantValue,R>(MetaRead.constants(State));
            else if(typeof(R) == typeof(FieldRecord))
                return Control.cast<MT.MemberField,R>(MetaRead.fields(State));
            else
                throw Unsupported.define<R>();                        
        }

        public ReadOnlySpan<MT.StringValue> ReadStrings()
            => MetaRead.strings(State);

        public ReadOnlySpan<MT.StringValue> ReadUserStrings()
            => MetaRead.ustrings(State);

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

        public ReadOnlySpan<MT.ConstantValue> ReadConstants()
            => MetaRead.constants(State);
            
        public ReadOnlySpan<MT.MemberField> ReadFields()
            => MetaRead.fields(State);
        
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
                        Name: MetaRead.Literal(State, entry.Name),
                        Attribute: entry.Attributes.ToString(),
                        Offset: entry.Offset,
                        Implementation: MetaRead.Token(State, entry.Implementation)
                );
            }
            return dst;
        }

        MetadataReader Reader 
            => State.Reader;        

        static Span<T> alloc<T>(int count)
            => new T[count];
    }
}