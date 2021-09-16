//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection.Metadata;
    using System.Linq;

    partial class SRM
    {
        public static Outcome ReadStandalonePortablePdbStream(MemoryBlock pdbStreamBlock, int pdbStreamOffset, out DebugMetadataHeader debugMetadataHeader, out int[] externalTableRowCounts)
        {
            var reader = new BlobReader(pdbStreamBlock);
            debugMetadataHeader = default;
            externalTableRowCounts = sys.empty<int>();

            const int PdbIdSize = 20;
            byte[]? pdbId = reader.ReadBytes(PdbIdSize);

            // ECMA-335 15.4.1.2:
            // The entry point to an application shall be static.
            // This entry point method can be a global method or it can appear inside a type.
            // The entry point method shall either accept no arguments or a vector of strings.
            // The return type of the entry point method shall be void, int32, or unsigned int32.
            // The entry point method cannot be defined in a generic class.
            uint entryPointToken = reader.ReadUInt32();
            int entryPointRowId = (int)(entryPointToken & TokenTypeIds.RIDMask);
            if (entryPointToken != 0 && ((entryPointToken & TokenTypeIds.TypeMask) != TokenTypeIds.MethodDef || entryPointRowId == 0))
            {
                return (false,BadImageFormat);
            }

            ulong externalTableMask = reader.ReadUInt64();

            // EnC & Ptr tables can't be referenced from standalone PDB metadata:
            const ulong validTables = (ulong)TableMask.ValidPortablePdbExternalTables;

            if ((externalTableMask & ~validTables) != 0)
            {
                return (false,BadImageFormat);
            }

            externalTableRowCounts = ReadMetadataTableRowCounts(ref reader, externalTableMask);

            debugMetadataHeader = new DebugMetadataHeader(
                ImmutableByteArrayInterop.DangerousCreateFromUnderlyingArray(ref pdbId).ToArray(),
                core.@as<int,MethodDefinitionHandle>(entryPointRowId),
                idStartOffset: pdbStreamOffset);
            return true;
        }
    }
}