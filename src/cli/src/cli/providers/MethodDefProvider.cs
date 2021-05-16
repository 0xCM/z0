//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static CliRows;
    using static core;

    public sealed class MethodDefProvider : CliTableProvider<MethodDefProvider,MethodDefRow>
    {
        public override ReadOnlySpan<MethodDefRow> Load(CliTableSource<MethodDefRow> src)
        {
            var handles = src.Reader.MethodDefHandles();
            var count = handles.Length;
            var dst = span<MethodDefRow>(count);
            src.Reader.Rows(handles,dst);
            return dst;
        }
    }
}