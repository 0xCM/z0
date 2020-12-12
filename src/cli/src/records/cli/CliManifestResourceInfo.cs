//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection.Metadata;
    using System.Reflection;

    /// <summary>
    /// Captures <see cref='ManifestResource'/> data in usable form
    /// </summary>
    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct CliManifestResourceInfo : IRecord<CliManifestResourceInfo>
    {
        public const string TableId = "cli.manifest.resource";

        public string Name;

        public MemoryAddress Offset;

        public ManifestResourceAttributes Attributes;
    }
}