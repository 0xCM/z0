//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static z;

    [ApiHost(ApiNames.EnumCatalogs, true)]
    public readonly struct ClrEnumCatalogs
    {
        [Op]
        public static Span<EnumLiteral> load(TextDoc src)
        {
            var rc = src.RowCount;
            var dst = alloc<EnumLiteral>(rc);
            var parser = HexByteParser.Service;
            for(var i=0; i<rc; i++)
            {
                ref readonly var row = ref src[i];
                if(row.BlockCount >= 3)
                {
                    var data = row[2];
                    var result = parser.ParseData(data);
                    if(result.Succeeded)
                    {
                        var bytes = span(result.Value);
                        var storage = 0ul;
                        ref var store = ref @as<ulong,byte>(storage);
                        var count = root.min(bytes.Length,8);
                        for(var j=0u; j<count; j++)
                            seek(store,j) = skip(bytes,j);

                        dst[i] = default;
                    }
                }
                else
                    dst[i] = default;
            }
            return dst;
        }

        public static WfExecToken emit(IWfShell wf, Index<Assembly> components, FS.FilePath target)
        {
            var flow = wf.EmittingTable<EnumLiteral>(target);
            var rows = Clr.enums(components).Sort();
            var kRows = rows.Length;
            using var writer = target.Writer();
            var formatter = Records.formatter<EnumLiteral>(16);
            writer.WriteLine(formatter.FormatHeader());

            for(var i=0; i<kRows; i++)
                writer.WriteLine(formatter.Format(rows[i]));

            return wf.EmittedTable<EnumLiteral>(flow, rows.Length, target);
        }

        public static WfExecToken emit(IWfShell wf, FS.FilePath target)
            => emit(wf, wf.Components, target);

        public static void emit(IWfShell wf)
        {
            var target = wf.Db().IndexTable(EnumLiteral.TableId);
            emit(wf, wf.Components, target);
        }
    }
}