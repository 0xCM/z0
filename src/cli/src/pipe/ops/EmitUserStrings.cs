//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static core;

    partial class CliPipe
    {
        public ReadOnlySpan<CliUserString> EmitUserStringInfo()
            => EmitUserStringInfo(Wf.Components);

        public ReadOnlySpan<CliUserString> EmitUserStringInfo(ReadOnlySpan<Assembly> src)
        {
            var buffer = DataList.create<CliUserString>();
            var count = src.Length;
            for(var i=0; i<count; i++)
                EmitUserStrings(skip(src,i), buffer);
            return buffer.Emit();
        }

        void EmitUserStrings(Assembly src, DataList<CliUserString> buffer)
        {
            var reader = Cli.reader(src);
            var records = reader.ReadUserStringInfo();
            buffer.Add(records);
            Db.EmitTable<CliUserString>(records, src.GetSimpleName());
        }
    }
}