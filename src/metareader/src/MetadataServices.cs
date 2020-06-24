//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020 / Microsoft
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
 
    using static Root;
    using static Konst;

    using static PartRecords;

    struct MetaReader : IPartReader
    {
        public static IPartReader Init(string path)
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
                
        [MethodImpl(Inline)]
        public ReadOnlySpan<R> Read<R>()
            where R : struct, IPartRecord
                => PartReader.read<R>(State);

        public ReadOnlySpan<StringValueRecord> ReadStrings()
            => PartReader.strings(State);

        public ReadOnlySpan<StringValueRecord> ReadUserStrings()
            => PartReader.ustrings(State);

        public ReadOnlySpan<BlobRecord> ReadBlobs()
            => PartReader.blobs(State);

        public ReadOnlySpan<ConstantRecord> ReadConstants()
            => PartReader.constants(State);
            
        public ReadOnlySpan<FieldRecord> ReadFields()
            => PartReader.fields(State);
        
        MetadataReader Reader 
            => State.Reader;        

        static Span<T> alloc<T>(int count)
            => new T[count];
    }
}