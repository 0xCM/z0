//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Root;
    using static core;
    using static CliRows;

    partial class CliReader
    {
        public uint Rows(ReadOnlySpan<MethodDefinitionHandle> src, Span<MethodDefRow> dst)
        {
            var count = (uint)root.min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
                 Row(skip(src,i), ref seek(dst,i));
            return count;
        }
    }
}
