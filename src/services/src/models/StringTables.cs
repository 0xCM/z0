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

    [ApiHost]
    public readonly struct StringTables
    {
        const NumericKind Closure = UnsignedInts;

        public static void emit(StringTableSpec src, StreamWriter dst)
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

        public static StringTableSpec specify(Identifier ns, Identifier table, ListItem<string>[] entries)
            => new StringTableSpec(ns, table, entries);

        public static StringTableSpec specify(Identifier ns, StringTable src)
        {
            var count = src.EntryCount;
            var buffer = alloc<ListItem<string>>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = (i,text.format(src[i]));
            return specify(ns, src.Name, buffer);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static StringTableRow row(in StringTable src, uint index)
            => new StringTableRow(src.Name, index, text.format(src[index]));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint rows(in StringTable src, uint offset, Span<StringTableRow> dst)
        {
            var j=0u;
            for(var i=offset; i<src.EntryCount && j<dst.Length; i++)
                seek(dst,j++) = row(src,i);
            return j;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<char> chars(StringTable src, uint i)
        {
            var offsets = src.Offsets;
            var i0 = bw32(skip(offsets, i));
            var count = src.EntryCount;
            var data = src.Data;
            if(i < count - 1)
            {
                var i1 = bw32(skip(offsets, i + 1));
                var length = i1 - i0;
                return slice(data, i0, length);
            }
            else
                return slice(data,i0);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<char> chars(in StringTableInfo src, uint index)
        {
            var dst = default(ReadOnlySpan<char>);
            if(index < src.EntryCount)
            {
                var i0 = offset(src, index);
                var i1 = 0u;

                if(index < src.EntryCount - 1)
                    i1 = offset(src, add(index, 1u));
                else
                    i1 = src.CharCount - 1;

                dst = chars(src.CharBase, i0, i1);
            }
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe ReadOnlySpan<char> chars(MemoryAddress @base, uint i0, uint i1)
            => cover(@base.Pointer<char>() + i0, (uint)(i1 - i0));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe uint offset(in StringTableInfo info, uint index)
        {
            var src = recover<uint>(cover(info.OffsetBase.Pointer<byte>(), info.EntryCount*4));
            return skip(src,index);
        }

        [Op, Closures(Closure)]
        public static StringTable create(Identifier name, ReadOnlySpan<string> src)
        {
            var count = src.Length;
            var offset = 0u;
            var offsets = alloc<uint>(count);
            var chars = alloc<char>(text.length(src));
            ref var joined = ref first(chars);
            ref var cuts = ref first(offsets);
            var j = 0u;
            for(var i=0u; i<count; i++)
            {
                ref readonly var entry = ref skip(src,i);
                seek(cuts,i) = j;
                copy(entry, ref j, chars);
            }
            return new StringTable(name, new string(chars), offsets);
        }

        public static StringTable create(Identifier name, ReadOnlySpan<ListItem<string>> src)
        {
            var count = src.Length;
            var strings = span<string>(count);
            for(var i=0; i<count; i++)
            {
                ref readonly var entry = ref skip(src,i);
                seek(strings,entry.Index) = entry.Content;
            }
            return create(name,strings);
        }

        public static StringTable from(FS.FilePath src, string name, char? delimiter = null)
        {
            var lines = src.ReadLines().View;
            var buffer = list<string>();
            for(var i=0; i<lines.Length; i++)
            {
                ref readonly var line = ref skip(lines,i);
                buffer.AddRange(line.SplitClean(delimiter.Value).Select(x => x.Trim()));
            }
            var entries = buffer.ViewDeposited();
            var table = create(name, entries);
            var count = Require.equal(buffer.Count, (int)table.EntryCount);
            for(var i=0u; i<count; i++)
            {
                var data = table[i];
                ref readonly var s0 = ref skip(entries,i);
                var s1 = new string(data);
                Require.equal(s0, s1);
            }
            return table;
        }

        public static string format(in StringTable src, uint margin = 0)
        {
            var dst = text.buffer();
            emit(margin, src, dst);
            return dst.Emit();
        }

        public static void emit(uint margin, in StringTable src, ITextBuffer dst)
        {
            dst.IndentLine(margin, PublicReadonlyStruct(src.Name));
            dst.IndentLine(margin, Open());
            margin+=4;

            dst.IndentLine(margin, Constant("EntryCount", src.EntryCount));
            dst.AppendLine();
            dst.IndentLine(margin, Constant("CharCount", (uint)src.Content.Length));
            dst.AppendLine();
            dst.IndentLine(margin, SpanRes.bytespan("Offsets", src.OffsetStorage).Format());
            dst.AppendLine();
            dst.IndentLine(margin, SpanRes.charspan("Data", src.Content).Format());

            margin-=4;
            dst.IndentLine(margin, Close());
        }

        [MethodImpl(Inline), Op]
        static ulong copy(ReadOnlySpan<char> src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            var count = src.Length;
            for(var j=0; j<count; j++)
                seek(dst,i++) = skip(src,j);
            return i - i0;
        }
    }
}