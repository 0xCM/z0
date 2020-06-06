//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020 / Microsoft
// License     :  MIT
// Derived from sample code obtained from https://github.com/microsoft/dotnet-samples
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
 
    using static Control;
    using static Seed;

    using static MetadataRecords;

    public readonly struct MetadataServices
    {
        [MethodImpl(Inline)]
        public static IMetadataReader Reader(FilePath src)
            => MetaReader.Init(src.Name);
    }

    struct MetaReader : IMetadataReader
    {
        public static IMetadataReader Init(string path)
        {
            var stream = File.OpenRead(path);
            var peFile = new PEReader(stream);
            return new MetaReader(new ReaderState(stream, peFile));
        }

        readonly ReaderState State;

        [MethodImpl(Inline)]
        MetaReader(ReaderState src)
        {
            State = src;
        }
        
        public void Dispose()
        {
            State.Dispose();
        }
                
        public ReadOnlySpan<StringValueRecord> ReadStrings()
            => MetadataRead.strings(State);

        public ReadOnlySpan<StringValueRecord> ReadUserStrings()
            => MetadataRead.ustrings(State);

        public ReadOnlySpan<BlobRecord> ReadBlobs()
            => MetadataRead.blobs(State);

        public ReadOnlySpan<ConstantRecord> ReadConstants()
            => MetadataRead.constants(State);
            
        public ReadOnlySpan<FieldRecord> ReadFields()
            => MetadataRead.fields(State);
        
        public ReadOnlySpan<ResourceRecord> ReadManifestResources()
            => MetadataRead.resources(State);

        MetadataReader Reader 
            => State.Reader;        

        static Span<T> alloc<T>(int count)
            => new T[count];
    }
}