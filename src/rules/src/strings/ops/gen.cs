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
    using static CsPatterns;

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
        public static uint genrows(StringTableSpec src, Span<StringTableRow> dst)
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

        public static void index(uint margin, in StringTable src, ITextBuffer dst)
        {
            var count = src.EntryCount;
            dst.IndentLine(margin, string.Format("public enum Index : uint"));
            dst.IndentLine(margin, Chars.LBrace);
            margin+=4;
            for(var i=0u; i<count; i++)
            {
                ref readonly var id = ref src.Identifier(i);
                if(id.IsEmpty)
                    break;
                dst.IndentLineFormat(margin, "{0}={1},", id, i);
            }
            margin-=4;
            dst.IndentLine(margin, Chars.RBrace);
        }

        public static void emit(uint margin, in StringTable src, ITextBuffer dst)
        {
            dst.IndentLine(margin, PublicReadonlyStruct(src.Name));
            dst.IndentLine(margin, Open());
            margin+=4;

            var OffsetsProp = nameof(MemoryStrings.Offsets);
            var DataProp = nameof(MemoryStrings.Data);
            var EntryCountProp = nameof(MemoryStrings.EntryCount);
            var CharCountProp = nameof(MemoryStrings.CharCount);
            var CharBaseProp = nameof(MemoryStrings.CharBase);
            var OffsetBaseProp = nameof(MemoryStrings.OffsetBase);

            dst.IndentLine(margin, Constant(EntryCountProp, src.EntryCount));
            dst.AppendLine();

            dst.IndentLine(margin, Constant(CharCountProp, (uint)src.Content.Length));
            dst.AppendLine();

            dst.IndentLine(margin, StaticLambdaProp(nameof(MemoryAddress), CharBaseProp, "address(Data)"));
            dst.AppendLine();

            dst.IndentLine(margin, StaticLambdaProp(nameof(MemoryAddress), OffsetBaseProp, "address(Offsets)"));
            dst.AppendLine();

            index(margin, src, dst);
            dst.AppendLine();

            dst.IndentLine(margin, SpanRes.bytespan(OffsetsProp, src.OffsetStorage).Format());
            dst.AppendLine();
            dst.IndentLine(margin, SpanRes.charspan(DataProp, src.Content).Format());
            margin-=4;
            dst.IndentLine(margin, Close());
        }

        public static string format(in StringTable src, uint margin = 0)
        {
            var dst = text.buffer();
            emit(margin, src, dst);
            return dst.Emit();
        }
    }
}