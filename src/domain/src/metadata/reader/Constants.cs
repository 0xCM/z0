//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    partial class PeTableReader
    {
        public ReadOnlySpan<ImageConstantRecord> Constants()
        {
            var reader = State.Reader;
            var count = ConstantCount(State);
            var dst = span<ImageConstantRecord>(count);
            for(var i=1u; i<=count; i++)
            {
                var k = ConstantHandle(i);
                var entry = reader.GetConstant(k);
                var parent = describe(State, entry.Parent);
                var blob = reader.GetBlobBytes(entry.Value);
                seek(dst, i - 1u) = new ImageConstantRecord(i, parent ?? HandleToken.Empty, entry.TypeCode, blob);
            }
            return dst;
        }
    }
}