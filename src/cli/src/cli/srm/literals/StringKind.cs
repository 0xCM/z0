//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata/src/System/Reflection/Metadata/MetadataReader.cs
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class SRM
    {
        public enum StringKind : byte
        {
            Plain = (byte)(StringHandleType.String >> HeapHandleType.OffsetBitCount),

            Virtual = (byte)(StringHandleType.VirtualString >> HeapHandleType.OffsetBitCount),

            WinRTPrefixed = (byte)(StringHandleType.WinRTPrefixedString >> HeapHandleType.OffsetBitCount),

            DotTerminated = (byte)(StringHandleType.DotTerminatedString >> HeapHandleType.OffsetBitCount),
        }
    }
}