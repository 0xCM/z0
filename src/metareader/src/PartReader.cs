//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata.Ecma335;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.IO;
        
    using static Konst;    
    using static PartRecords;

    [ApiHost]
    public partial class PartReader : IPartReader
    {
        [MethodImpl(Inline)]
        public static IPartReader open(FilePath src)
        {
            var stream = File.OpenRead(src.Name);
            var peFile = new PEReader(stream);
            return new PartReader(new ReaderState(stream, peFile));
        }

        static MetadataRootBuilder build()
            => new MetadataRootBuilder(new MetadataBuilder());

        readonly ReaderState State;

        [MethodImpl(Inline)]
        PartReader(ReaderState src)
            => State = src;
        
        public void Dispose()
            => State.Dispose();
                
        [MethodImpl(Inline)]
        public ReadOnlySpan<R> Read<R>()
            where R : struct, IPartRecord
                => read<R>(State);

        public ReadOnlySpan<StringValueRecord> ReadStrings()
            => strings(State);

        public ReadOnlySpan<StringValueRecord> ReadUserStrings()
            => ustrings(State);

        public ReadOnlySpan<BlobRecord> ReadBlobs()
            => blobs(State);

        public ReadOnlySpan<ConstantRecord> ReadConstants()
            => constants(State);
            
        public ReadOnlySpan<FieldRecord> ReadFields()
            => fields(State);     
    }
}