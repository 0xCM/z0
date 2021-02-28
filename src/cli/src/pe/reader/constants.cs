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

    using static Part;
    using static memory;

    partial class PeTableReader
    {
        public static ConstantHandle ConstantHandle(uint row)
            => MetadataTokens.ConstantHandle((int)row);

        public ReadOnlySpan<CliConstantInfo> constants(ref uint counter)
        {
            var reader = State.Reader;
            var count = ConstantCount(State);
            var dst = span<CliConstantInfo>(count);
            for(var i=1u; i<=count; i++)
            {
                var k = ConstantHandle(i);
                var entry = reader.GetConstant(k);
                var parent = index(State, entry.Parent);
                var blob = reader.GetBlobBytes(entry.Value);
                ref var target = ref seek(dst, i - 1u);
                target.Sequence = counter++;
                target.ParentId = (parent ?? CliTableIndex.Empty).Key;
                target.Source = (parent ?? CliTableIndex.Empty).Source.ToString();
                target.DataType = entry.TypeCode;
                target.Content = blob;
            }
            return dst;
        }
    }
}