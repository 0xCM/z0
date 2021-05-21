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
        [Op]
        public static unsafe Outcome<CliMetadataHeader> ReadMetadataHeader(MemoryBlock src)
        {
            if(BlobReader.create(src.Pointer, src.Length, out var reader))
            {
                var outcome = ReadMetadataHeader(ref reader, out var header);
                if(outcome)
                    return header;
                else
                    return outcome;
            }
            else
                return false;
        }

        [Op]
        static Outcome ReadMetadataHeader(ref BlobReader reader, out CliMetadataHeader dst)
        {
            dst = default;
            if (reader.RemainingBytes < MetadataStreamConstants.SizeOfMetadataTableHeader)
                return (false, "Insufficient data");

            uint signature = reader.ReadUInt32();
            if (signature != COR20Constants.COR20MetadataSignature)
                return (false, "Unmagical");

            dst.Magic = signature;

            // major version
            dst.MajorVersion = reader.ReadUInt16();

            // minor version
            dst.MinorVersion = reader.ReadUInt16();

            // reserved:
            reader.ReadUInt32();

            int versionStringSize = reader.ReadInt32();
            if (reader.RemainingBytes < versionStringSize)
                return (false, "VersionString");

            dst.VersionSize = (byte)versionStringSize;

            int numberOfBytesRead;
            var versionBlock = reader.GetMemoryBlockAt(0, versionStringSize);
            dst.VersionText = versionBlock.PeekUtf8NullTerminated(0, null, MetadataStringDecoder.DefaultUTF8, out numberOfBytesRead, '\0');
            reader.Offset += versionStringSize;
            return true;
        }
    }
}