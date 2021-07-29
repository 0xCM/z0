//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;
    using static SdmModels;

    partial class IntelSdm
    {
        public static Index<TableColumn> columns(ReadOnlySpan<string> src)
            => Tables.columns<ColumnKind>(src);

        public ReadOnlySpan<Table> ReadInstructionTables(FS.FilePath src)
        {
            const string TitleMarker = "# ";
            const string TableMarker = "## ";
            const string Separator = "------";
            const string TableTileFormat = "# {0}";
            const string InstTitleFormat = "# Instruction {0}";
            const string Rejoin = " | ";
            const char ColSep = Chars.Pipe;
            var result = Outcome.Success;
            var foundtable = false;
            var parsingrows = false;
            var tablekind = SdmTableKind.None;
            var rowcount = 0;
            var cols = Index<TableColumn>.Empty;
            var rows = list<TableRow>();
            var rowidx = z16;
            var table = TableBuilder.create();
            var tables = list<Table>();
            using var reader = src.LineReader(TextEncodingKind.Asci);
            while(reader.Next(out var line))
            {
                if((line.IsEmpty || line.StartsWith(Separator)) && !parsingrows)
                    continue;

                if(parsingrows && line.IsEmpty)
                {
                    table.IfNonEmpty(() => tables.Add(table.Emit()));
                    foundtable = false;
                    parsingrows = false;
                    rowcount = 0;
                    continue;
                }

                var content = line.Content;
                if(parsingrows)
                {
                    var values = content.SplitClean(ColSep);
                    var valcount = values.Length;

                    if(valcount != cols.Count)
                        Warn($"{valcount} != {cols.Count}");

                    if(valcount != 0)
                    {
                        table.WithRow(values);
                        rowcount++;
                    }
                    continue;
                }

                if(foundtable && !parsingrows)
                {
                    var labels = content.SplitClean(ColSep);
                    if(labels.Length == 0)
                        Warn(string.Format("Expected header"));

                    if(labels.Length != 0)
                    {
                        cols = columns(labels);
                        table.WithColumns(cols);
                        parsingrows = true;
                    }
                }

                if(content.StartsWith(TableMarker))
                {
                    tablekind = TableKinds.from(content.Remove(TableMarker).Trim());
                    table.Clear();
                    table.WithKind((uint)tablekind);
                    foundtable = true;
                }
            }

            table.IfNonEmpty(() => tables.Add(table.Emit()));

            return tables.ViewDeposited();
        }
    }
}