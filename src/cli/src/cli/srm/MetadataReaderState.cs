//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;
    using System.Runtime.InteropServices;
    using System.Linq;

    using static Part;
    using static core;
    using static SRM;

    using static CliRows;

    public sealed class MetadataReaderState
    {
        public SRM.MemoryBlock RootBlock {get; internal set;}

        public CliMetadataHeader MetadataHeader {get; internal set;}

        public MetadataKind MetadataKind {get; internal set;}

        public MetadataStreamKind StreamKind {get; internal set;}

        public Index<SRM.StreamHeader> StreamHeaders {get; internal set;}

        public SRM.MemoryBlock MetadataBlock {get; internal set;}

        public int[] ExternalTableRowCount {get; internal set;}
            = sys.empty<int>();

        public int[] TableRowCounts {get; internal set;}
            = sys.empty<int>();

        public SRM.MemoryBlock PdbBlock {get; internal set;}
            = SRM.MemoryBlock.Empty;

        public SRM.DebugMetadataHeader DebugHeader {get; internal set;}
            = SRM.DebugMetadataHeader.Empty;

        public SRM.HeapSizes HeapSizes {get; internal set;}

        public SRM.TableMask SortedTables {get; internal set;}

        public SRM.MemoryBlock MetadataTableBlock {get; internal set;}

        public CodedTokenRefSizes CodedTokenRefSizes {get; internal set;}

        public PointerTableRefSizes PointerTableRefSizes {get; internal set;}

    }
}