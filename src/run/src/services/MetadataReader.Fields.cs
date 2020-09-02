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
    using System.Collections.Generic;

    using SysReader = System.Reflection.Metadata.MetadataReader;

    using static Konst;
    using static z;

    partial class MetadataReader
    {
        public IWfShell Wf;

        readonly MemoryFile Source;

        readonly PEReader Pe;

        readonly SysReader Reader;

        readonly PEMemoryBlock PeMemory;

        TableSpan<AssemblyFileHandle> _AssemblyFileHandles;

        TableSpan<ManifestResourceHandle> _ManifestResourceHandles;

        TableSpan<FieldDefinitionHandle> _FieldDefinitionHandles;

        TableSpan<AssemblyReferenceHandle> _AssemblyReferenceHandles;
    }
}