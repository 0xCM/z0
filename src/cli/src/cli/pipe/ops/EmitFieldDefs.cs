//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static core;
    using static CliRows;

    partial class CliPipe
    {
        public uint EmitFieldDefs(ReadOnlySpan<Assembly> src, FS.FilePath dst)
        {
            var counter = 0u;
            var flow = Wf.EmittingTable<FieldDefInfo>(dst);
            using var writer = dst.Writer();
            var formatter = Tables.formatter<FieldDefInfo>();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var a = ref skip(src,i);
                var assname = a.GetSimpleName();
                var reader = Cli.reader(a);
                var handles = reader.FieldDefHandles();
                var count = handles.Length;
                for(var j=0; j<count; j++)
                {
                    var row = new FieldDefRow();
                    var info = new FieldDefInfo();
                    ref readonly var handle = ref skip(handles,j);
                    reader.Row(handle, ref row);
                    info.Token = Cli.token(handle);
                    info.Component = assname;
                    info.Attributes = row.Attributes;
                    info.Offset = row.Offset;
                    info.CliSig = reader.Read(row.Signature);
                    info.Name = reader.Read(row.Name);
                    writer.WriteLine(formatter.Format(info));
                    counter++;
                }
            }
            Wf.EmittedTable(flow, counter);
            return counter;
        }

    }
}