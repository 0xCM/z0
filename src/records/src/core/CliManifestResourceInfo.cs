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

    using static Konst;
    using static z;

    /// <summary>
    /// Captures <see cref='ManifestResource'/> data in usable form
    /// </summary>
    [StructLayout(LayoutKind.Sequential), Table(TableId, FieldCount)]
    public struct CliManifestResourceInfo
    {
        public const string TableId = "cli.manifest.resource";

        public const byte FieldCount = 3;

        public string Name;

        public MemoryAddress Offset;

        public ManifestResourceAttributes Attributes;
    }
}