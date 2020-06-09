//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;
    using System.Reflection.PortableExecutable;
    using System.IO;
    using System.Linq;

    readonly struct ReaderState : IDisposable
    {                
        readonly PEReader PEReader;

        readonly FileStream Stream;

        public readonly MetadataReader Reader;

        public readonly MetadataReader[] Readers;

        public readonly Option<MetadataAggregator> Aggregator;

        readonly ImmutableArray<ImmutableArray<EntityHandle>> Maps;

        internal ReaderState(FileStream stream, PEReader peReader)
        {
            Stream = stream;
            PEReader = peReader;
            Reader = peReader.GetMetadataReader();
            Readers = new MetadataReader[]{Reader};

            if (Readers.Length > 1)
            {
                var deltaReaders = new List<MetadataReader>(Readers.Skip(1));
                Aggregator = new MetadataAggregator(Readers[0], deltaReaders);
                Maps = ImmutableArray.CreateRange(deltaReaders.Select(reader => ImmutableArray.CreateRange(reader.GetEditAndContinueMapEntries())));
            }
            else
            {
                Aggregator = Option.none<MetadataAggregator>();
                Maps = new ImmutableArray<ImmutableArray<EntityHandle>>();
            }

        }

        public void Dispose()
        {
            PEReader?.Dispose();
            Stream?.Dispose();
        }
    }
}