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
        public static Outcome ReadMetadataTableHeader(MetadataStreamKind kind, ref BlobReader reader, out HeapSizes heapSizes, out int[] metadataTableRowCounts, out TableMask sortedTables)
        {
            heapSizes = default;
            metadataTableRowCounts = sys.empty<int>();
            sortedTables = default;

            if (reader.RemainingBytes < MetadataStreamConstants.SizeOfMetadataTableHeader)
            {
                return (false, BadImageFormat);
                //throw new BadImageFormatException(SR.MetadataTableHeaderTooSmall);
            }

            // reserved (shall be ignored):
            reader.ReadUInt32();

            // major version (shall be ignored):
            reader.ReadByte();

            // minor version (shall be ignored):
            reader.ReadByte();

            // heap sizes:
            heapSizes = (HeapSizes)reader.ReadByte();

            // reserved (shall be ignored):
            reader.ReadByte();

            ulong presentTables = reader.ReadUInt64();
            sortedTables = (TableMask)reader.ReadUInt64();

            // According to ECMA-335, MajorVersion and MinorVersion have fixed values and,
            // based on recommendation in 24.1 Fixed fields: When writing these fields it
            // is best that they be set to the value indicated, on reading they should be ignored.
            // We will not be checking version values. We will continue checking that the set of
            // present tables is within the set we understand.

            ulong validTables = (ulong)(TableMask.TypeSystemTables | TableMask.DebugTables);

            if ((presentTables & ~validTables) != 0)
            {
                return (false, BadImageFormat);
                //throw new BadImageFormatException(SR.Format(SR.UnknownTables, presentTables));
            }

            if (kind == MetadataStreamKind.Compressed)
            {
                // In general Ptr tables and EnC tables are not allowed in a compressed stream.
                // However when asked for a snapshot of the current metadata after an EnC change has been applied
                // the CLR includes the EnCLog table into the snapshot. We need to be able to read the image,
                // so we'll allow the table here but pretend it's empty later.
                if ((presentTables & (ulong)(TableMask.PtrTables | TableMask.EnCMap)) != 0)
                {
                    //throw new BadImageFormatException(SR.IllegalTablesInCompressedMetadataStream);
                }
            }

            metadataTableRowCounts = ReadMetadataTableRowCounts(ref reader, presentTables);

            if ((heapSizes & HeapSizes.ExtraData) == HeapSizes.ExtraData)
            {
                // Skip "extra data" used by some obfuscators. Although it is not mentioned in the CLI spec,
                // it is honored by the native metadata reader.
                reader.ReadUInt32();
            }

            return true;
        }

        static int[] ReadMetadataTableRowCounts(ref BlobReader memReader, ulong presentTableMask)
        {
            ulong currentTableBit = 1;

            var rowCounts = new int[MetadataTokens.TableCount];
            for (int i = 0; i < rowCounts.Length; i++)
            {
                if ((presentTableMask & currentTableBit) != 0)
                {
                    if (memReader.RemainingBytes < sizeof(uint))
                    {
                        //throw new BadImageFormatException(SR.TableRowCountSpaceTooSmall);
                    }

                    uint rowCount = memReader.ReadUInt32();
                    if (rowCount > TokenTypeIds.RIDMask)
                    {
                        //throw new BadImageFormatException(SR.Format(SR.InvalidRowCount, rowCount));
                    }

                    rowCounts[i] = (int)rowCount;
                }

                currentTableBit <<= 1;
            }

            return rowCounts;
        }
    }
}