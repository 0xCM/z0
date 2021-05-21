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
        public struct StreamHeader
        {
            public uint Offset;

            public int Size;

            public string Name;
        }

        public static Outcome InitializeStreamReaders(MetadataReaderState state, MetadataKind metadataKind, in MemoryBlock metadataRoot, StreamHeader[] streamHeaders,
            out MetadataStreamKind metadataStreamKind, out MemoryBlock metadataTableStream, out MemoryBlock standalonePdbStream)
        {
            metadataTableStream = default;
            standalonePdbStream = default;
            metadataStreamKind = MetadataStreamKind.Illegal;
            var IsMinimalDelta = false;

            foreach (StreamHeader streamHeader in streamHeaders)
            {
                switch (streamHeader.Name)
                {
                    case COR20Constants.StringStreamName:
                        if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
                        {
                            return (false,BadImageFormat);
                        }

                        //var StringHeap = new StringHeap(metadataRoot.GetMemoryBlockAt((int)streamHeader.Offset, streamHeader.Size), metadataKind);
                        state.StringHeap = new NonVirtualStringHeap(metadataRoot.GetMemoryBlockAt((int)streamHeader.Offset, streamHeader.Size));
                        break;

                    case COR20Constants.BlobStreamName:
                        if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
                        {
                            return (false,BadImageFormat);
                        }

                        var BlobHeap = new BlobHeap(metadataRoot.GetMemoryBlockAt((int)streamHeader.Offset, streamHeader.Size), metadataKind);
                        state.BlobHeap = BlobHeap;
                        break;

                    case COR20Constants.GUIDStreamName:
                        if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
                        {
                            return (false,BadImageFormat);
                        }

                        var GuidHeap = new GuidHeap(metadataRoot.GetMemoryBlockAt((int)streamHeader.Offset, streamHeader.Size));
                        state.GuidHeap = GuidHeap;
                        break;

                    case COR20Constants.UserStringStreamName:
                        if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
                        {
                            return (false,BadImageFormat);
                        }

                        var UserStringHeap = new UserStringHeap(metadataRoot.GetMemoryBlockAt((int)streamHeader.Offset, streamHeader.Size));
                        state.UserStringHeap = UserStringHeap;
                        break;

                    case COR20Constants.CompressedMetadataTableStreamName:
                        if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
                        {
                            return (false,BadImageFormat);
                        }

                        metadataStreamKind = MetadataStreamKind.Compressed;
                        metadataTableStream = metadataRoot.GetMemoryBlockAt((int)streamHeader.Offset, streamHeader.Size);
                        break;

                    case COR20Constants.UncompressedMetadataTableStreamName:
                        if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
                        {
                            return (false,BadImageFormat);
                        }

                        metadataStreamKind = MetadataStreamKind.Uncompressed;
                        metadataTableStream = metadataRoot.GetMemoryBlockAt((int)streamHeader.Offset, streamHeader.Size);
                        break;

                    case COR20Constants.MinimalDeltaMetadataTableStreamName:
                        if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
                            return (false,BadImageFormat);

                        // the content of the stream is ignored
                        IsMinimalDelta = true;
                        break;

                    case COR20Constants.StandalonePdbStreamName:
                        if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
                            return (false,BadImageFormat);

                        standalonePdbStream = metadataRoot.GetMemoryBlockAt((int)streamHeader.Offset, streamHeader.Size);
                        break;

                    default:
                        // Skip unknown streams. Some obfuscators insert invalid streams.
                        continue;
                }
            }

            if (IsMinimalDelta && metadataStreamKind != MetadataStreamKind.Uncompressed)
                return (false,BadImageFormat);
            return true;
        }
    }
}