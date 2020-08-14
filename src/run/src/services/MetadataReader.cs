//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;

    using static Konst;
    using static z;

    public unsafe partial class MetadataReader : IDisposable
    {
        public MetadataReader(IWfContext wf, FilePath src)
        {
            Source = MemoryFile.open(src.Name);
            Wf = wf;
            Pe = new PEReader(Source.BaseAddress.Pointer<byte>(), (int)Source.Size);
            Reader = Pe.GetMetadataReader();
            PeMemory = Pe.GetMetadata();        
        }

        public DebugMetadataHeader DebugMetadataHeader
            => Reader.DebugMetadataHeader;

        public void Dispose()
        {
            Pe.Dispose();
            Source.Dispose();
        }
    }
}