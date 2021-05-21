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
        public static Index<uint> RowCounts(ref BlobReader reader, ulong presentTableMask)
        {
            var currentTableBit = 1ul;
            var Empty = Index<uint>.Empty;
            var buffer = new uint[MetadataTokens.TableCount];
            RowCounts(ref reader, presentTableMask, buffer);
            return buffer;
        }

        [Op]
        static uint RowCounts(ref BlobReader reader, ulong presentTableMask, Span<uint> dst)
        {
            var currentTableBit = 1ul;
            var Empty = Index<uint>.Empty;
            var count = (uint)dst.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                if ((presentTableMask & currentTableBit) != 0)
                {
                    if (reader.RemainingBytes < sizeof(uint))
                        break;

                    var rowCount = reader.ReadUInt32();
                    if (rowCount > TokenTypeIds.RIDMask)
                        break;

                    seek(dst, counter++) = (uint)rowCount;
                }

                currentTableBit <<= 1;
            }

            return counter;
        }
    }
}