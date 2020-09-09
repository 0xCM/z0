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

    partial class PeTableReader
    {
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