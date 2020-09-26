//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Konst;
    using static z;

    using I = System.Reflection.Metadata.Ecma335.TableIndex;

    partial class PeTableReader
    {
        internal static TableIndex? index(Handle handle)
        {
            if(MetadataTokens.TryGetTableIndex(handle.Kind, out var table))
                return table;
            else
                return null;
        }

        public static ConstantHandle ConstantHandle(uint row)
            => MetadataTokens.ConstantHandle((int)row);

        public static HandleInfo? describe(in ReaderState state, Handle handle)
        {
            if(!handle.IsNil)
            {
                var table = index(handle);
                var token = state.Reader.GetToken(handle);
                if (table != null)
                    return new HandleInfo(token, table.Value);
            }

            return null;
        }

        [MethodImpl(Inline), Op]
        public static int ConstantCount(in ReaderState state)
            => state.Reader.GetTableRowCount(I.Constant);

        public static ReadOnlySpan<ImageConstantRecord> constants(in ReaderState state)
        {
            var reader = state.Reader;
            var count = ConstantCount(state);
            var dst = span<ImageConstantRecord>(count);
            for(var i=1u; i<=count; i++)
            {
                var k = ConstantHandle(i);
                var entry = reader.GetConstant(k);
                var parent = describe(state, entry.Parent);
                var blob = reader.GetBlobBytes(entry.Value);
                seek(dst, i - 1u) = new ImageConstantRecord(i, parent ?? HandleInfo.Empty, entry.TypeCode, blob);
            }

            return dst;
        }
    }
}