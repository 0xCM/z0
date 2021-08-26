//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    partial struct StringTables
    {
        public static void gencode(StringTableSpec src, StreamWriter dst)
        {
            var entries = src.Entries;
            var count = entries.Length;
            dst.WriteLine(string.Format("namespace {0}",src.Namespace));
            dst.WriteLine(Chars.LBrace);
            dst.WriteLine(string.Format("    using {0};", "System"));
            dst.WriteLine();
            dst.WriteLine(string.Format("    using static {0};", "core"));
            dst.WriteLine();
            dst.WriteLine(StringTables.create(src.TableName, src.Entries).Format(4));
            dst.WriteLine(Chars.RBrace);
        }

        [Op]
        public static uint rows(StringTableSpec src, Span<StringTableRow> dst)
        {
            var entries = src.Entries;
            var count = (uint)min(entries.Length,dst.Length);
            for(var j=0; j<count; j++)
            {
                ref var row = ref seek(dst,j);
                ref readonly var entry = ref skip(entries,j);
                row.EntryIndex = entry.Index;
                row.EntryName = entry.Content;
                row.TableName = src.TableName;
            }
            return count;
        }

        public static string format(in StringTable src, uint margin = 0)
        {
            var dst = text.buffer();
            emit(margin, src, dst);
            return dst.Emit();
        }
    }
}