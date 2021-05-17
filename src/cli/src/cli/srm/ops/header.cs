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
        public static unsafe Outcome<CliHeader> header(MemoryBlock src)
        {
            if(BlobReader.create(src.Pointer, src.Length, out var reader))
            {
                var outcome = ReadHeader(ref reader, out var header);
                if(outcome)
                    return header;
                else
                    return outcome;
            }
            else
                return false;
        }

        [Op]
        static Outcome ReadHeader(ref BlobReader reader, out CliHeader dst)
        {
            dst = default;
            if (reader.RemainingBytes < MetadataStreamConstants.SizeOfMetadataTableHeader)
                return false;

            // reserved (shall be ignored):
            reader.ReadUInt32();

            // major version (shall be ignored):
            reader.ReadByte();

            // minor version (shall be ignored):
            reader.ReadByte();

            // heap sizes:
            dst.HeapSizes = (HeapSizes)reader.ReadByte();

            // reserved (shall be ignored):
            reader.ReadByte();

            var presentTables = reader.ReadUInt64();
            dst.Tables = (TableMask)reader.ReadUInt64();

            // According to ECMA-335, MajorVersion and MinorVersion have fixed values and,
            // based on recommendation in 24.1 Fixed fields: When writing these fields it
            // is best that they be set to the value indicated, on reading they should be ignored.
            // We will not be checking version values. We will continue checking that the set of
            // present tables is within the set we understand.

            var validTables = (ulong)(TableMask.TypeSystemTables | TableMask.DebugTables);

            if ((presentTables & ~validTables) != 0)
                return false;

            dst.RowCounts = RowCounts(ref reader, presentTables);

            if ((dst.HeapSizes & HeapSizes.ExtraData) == HeapSizes.ExtraData)
            {
                // Skip "extra data" used by some obfuscators. Although it is not mentioned in the CLI spec,
                // it is honored by the native metadata reader.
                reader.ReadUInt32();
            }
            return true;
        }
    }
}