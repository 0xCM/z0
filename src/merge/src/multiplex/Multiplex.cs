//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static Konst;
    using static z;

    public struct MultiplexSettings
    {
        FS.FolderPath BuildOutput;

        FS.FolderPath SlnRoot;
    }

    public class Multiplex
    {
        public TableSpan<ClrAssembly> Assemblies;

        public TableSpan<NativeDll> Libraries;

        public BuildArchive BuildArchive;

        public ArchiveConfig CaptureArchive;
    }
}