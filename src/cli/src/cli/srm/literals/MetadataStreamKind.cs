//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata/src/System/Reflection/Metadata/MetadataReader.cs
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class SRM
    {
        public enum MetadataStreamKind
        {
            Illegal,
            Compressed,
            Uncompressed,
        }
    }
}