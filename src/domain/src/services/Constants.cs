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
        public ReadOnlySpan<CliConstantRecord> Constants()
        {
            var reader = State.Reader;
            var count = ConstantCount(State);
            var dst = span<CliConstantRecord>(count);
            for(var i=1u; i<=count; i++)
            {
                var k = ConstantHandle(i);
                var entry = reader.GetConstant(k);
                var parent = describe(State, entry.Parent);
                var blob = reader.GetBlobBytes(entry.Value);
                seek(dst, i - 1u) = new CliConstantRecord(i, parent ?? CliHandleToken.Empty, entry.TypeCode, blob);
            }
            return dst;
        }
    }
}