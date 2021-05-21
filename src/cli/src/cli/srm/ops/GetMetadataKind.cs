//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Part;
    using static core;

    partial class SRM
    {
        public static MetadataKind GetMetadataKind(string versionString, MetadataReaderOptions options = MetadataReaderOptions.Default)
        {
            // Treat metadata as CLI raw metadata if the client doesn't want to see projections.
            if ((options & MetadataReaderOptions.ApplyWindowsRuntimeProjections) == 0)
                return MetadataKind.Ecma335;

            if (!versionString.Contains("WindowsRuntime"))
                return MetadataKind.Ecma335;
            else if (versionString.Contains("CLR"))
                return MetadataKind.ManagedWindowsMetadata;
            else
                return MetadataKind.WindowsMetadata;
        }
    }
}